using AS2ProjectTeam03.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using static AS2ProjectTeam03.DataTypes;

namespace AS2ProjectTeam03
{
    public partial class AS2ProjectTeam03Form : Form
    {
        //setup EF context
        private CoinTrackerEntities context;
        public AS2ProjectTeam03Form()
        {

            InitializeComponent();
            //setup EF dbset

            context = new CoinTrackerEntities();
            //onload event

            this.Load += AS2ProjectTream03Form_Load;

            //async request
            try
            {
                //jsonList = WebRequest().Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //format datagridview
            FormatDataGridView();
            //get portfolio value
            double portfolioValue = 0.0;
            //set portfolio label value
            labelCurrentValue.Text = portfolioValue.ToString("C2");
            //add new record test
            //Console.WriteLine(new AddNewRecord());
        }
        async Task<List<Datum>> WebRequest()
        {
            return await WebApiRequest.AccessTheWebAsync();
        }
        void FormatDataGridView()
        {
            //hide id column
            //dataGridViewCoins.Columns["CoinId"].Visible = false;
            //format colums
            //dataGridViewCoins.Columns["CoinVolume24hr"].DefaultCellStyle.Format = "C0";
            //dataGridViewCoins.Columns["CoinQuote"].DefaultCellStyle.Format = "C2";
            //dataGridViewCoins.Columns["Coin24hr"].DefaultCellStyle.Format = "P2";
            //right-align number columns
            //dataGridViewCoins.Columns["CoinVolume24hr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridViewCoins.Columns["CoinQuote"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridViewCoins.Columns["Coin24hr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //get app width
            //int formWidth = this.Width;
            //get combobox centre point x
            //int comboBoxPortfolioCentreX = (formWidth / 2) - (comboBoxPortfolio.Width / 2);
            //center the combobox
            //comboBoxPortfolio.Location = new Point(comboBoxPortfolioCentreX, 8);
            //Default Portfolio
            comboBoxPortfolio.SelectedItem = "My Portfolio";
        }

        private void comboBoxPortfolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Portfolio selected index: {comboBoxPortfolio.SelectedIndex.ToString()}");
        }
        private void AS2ProjectTream03Form_Load(object sender, EventArgs e)
        {
            SeedTransactionDataTables();
        }
        private void SeedTransactionDataTables()
        {
            //Entities framework initialization
            context.Database.Log = s => Debug.WriteLine(s);

            context.Database.Delete();
            context.Database.Create();
            context.SaveChanges();
            //context.Coins.Load();
            //seed initial data into dbset
            List<Coin> testCoinList = new List<Coin>()
            {
                new Coin {coinId = 1000, coinName = "Bitcoin", coinSymbol="BTC", coinMaxSupply=21000000, },
                new Coin {coinId = 1002, coinName = "Ethereum", coinSymbol="ETH"},
            };
            context.Coins.AddRange(testCoinList);
            context.SaveChanges();

            //load initial data into a list of datum
            List<Datum> datumList = new InitialData().GetInitialData();
            //pases a Datum list and gets a CoinRow list
            List<CoinRow> initialCoinRows = new ListDatumToListCoinRow().GetCoinRows(datumList);
            //set initial coins into database context
            context.Coins.AddRange((from coin in datumList
                                    select new Coin
                                    {
                                        coinName = coin.name,
                                        coinId = coin.id,
                                        coinSymbol = coin.symbol
                                    }).ToList());
            context.SaveChanges();
            dataGridViewCoins.DataSource = context.Coins.Local.ToBindingList();
            //testing
            List<Portfolio> testPortfolioList = new List<Portfolio>()
            {
                new Portfolio { portfolioId = 1, portfolioName = "Muh Test Portfolio"}
            };
            context.Portfolios.AddRange(testPortfolioList);
            context.SaveChanges();
            List<Quote> testQuoteList = new List<Quote>()
            {
                new Quote {quoteId=1, quoteCoinId=1, quote24Hr = 0.12, quotePrice=1300,quoteVolume=100000, quoteDateTime=new DateTime(2017, 5, 1, 8, 30, 52)}
            };
            context.Quotes.AddRange(testQuoteList);
            context.SaveChanges();
            List<Transaction> testTransactionList = new List<Transaction>()
            {
                new Transaction {transactionId=1,transactionPorfolioId=1, transactionCoinId=1, transactionAmount=1, transactionPricePerCoin=1250}
            };
            context.Transactions.AddRange(testTransactionList);
            context.SaveChanges();
            //seed initial data into datagridview
            dataGridViewPortfolio.DataSource =
                (from transaction in context.Transactions
                 join coin in context.Coins on transaction.transactionCoinId equals coin.coinId
                 select new CoinRow
                 {
                     CoinId = coin.coinId,
                     CoinName = coin.coinName,
                     CoinSymbol = coin.coinSymbol,
                     TransactionAmount = transaction.transactionAmount,
                     TransactionPricePerCoin = transaction.transactionPricePerCoin
                 }).ToList();
                //context.Transactions.Local.ToBindingList()
                ;
            //set quote date
            labelDateTime.Text = datumList[0].last_updated.ToString();//rootObject.status.timestamp.ToString();

        }


    }
}

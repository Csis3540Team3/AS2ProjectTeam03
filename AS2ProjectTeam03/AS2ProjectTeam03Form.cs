using AS2ProjectTeam03.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        private CoinTrackerEntities context;
        public AS2ProjectTeam03Form()
        {
            InitializeComponent();
            //setup EF dbset
            context = new CoinTrackerEntities();
            //context.Database.Delete();
            //context.Database.Create();
            //context.SaveChanges();
            //context.Coins.Load();

            //initial data
            JavaScriptSerializer js = new JavaScriptSerializer();
            RootObject rootObject = js.Deserialize<RootObject>(new InitialJson().InitialJsonString);
            List<Datum> jsonList = rootObject.data;
            //get initial coin data
            List<CoinRow> coinRows = new InitializeData().GetCoinRows(jsonList);
            //seed initial data into dbset
            List<Coin> testCoinList = new List<Coin>()
            {
                new Coin {coinId = 1, coinName = "Bitcoin", coinSymbol="BTC", coinMaxSupply=21000000, },
                new Coin {coinId = 2, coinName = "Ethereum", coinSymbol="ETH"},
            };
            context.Coins.AddRange(testCoinList);
            context.SaveChanges();
            List<Portfolio> testPortfolioList = new List<Portfolio>()
            {
                new Portfolio { portfolioId = 1, portfolioName = "Muh Test Portfolio"}
            };
            context.Portfolios.AddRange(testPortfolioList);
            context.SaveChanges();
            List<Quote> testQuoteList = new List<Quote>()
            {
                new Quote {quoteId=1, quoteCoinId=1, quote24Hr = 0.12, quotePrice=3900,quoteVolume=100000, quoteDateTime=new DateTime(2008, 5, 1, 8, 30, 52)}
            };
            context.Quotes.AddRange(testQuoteList);
            context.SaveChanges();
            List<Transaction> testTransactionList = new List<Transaction>()
            {
                new Transaction {transactionId=1,transactionPorfolioId=1, transactionCoinId=1}
            };
            context.Transactions.AddRange(testTransactionList);
            context.SaveChanges();
            //seed initial data into datagridview
            dataGridViewCoins.DataSource = context.Transactions.Local.ToBindingList();
            //async request
            try
            {
                jsonList = WebRequest().Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //format datagridview
            FormatDataGridView();
            //set quote date
            labelDateTime.Text = "Muh Date";
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
            dataGridViewCoins.Columns["CoinId"].Visible = false;
            //format colums
            dataGridViewCoins.Columns["CoinVolume24hr"].DefaultCellStyle.Format = "C0";
            dataGridViewCoins.Columns["CoinQuote"].DefaultCellStyle.Format = "C2";
            dataGridViewCoins.Columns["Coin24hr"].DefaultCellStyle.Format = "P2";
            //right-align number columns
            dataGridViewCoins.Columns["CoinVolume24hr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCoins.Columns["CoinQuote"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCoins.Columns["Coin24hr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            Console.WriteLine(comboBoxPortfolio.SelectedIndex.ToString());
            switch (comboBoxPortfolio.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                //case 3:
                //    NewPortfolioForm newPortfolio = new NewPortfolioForm();
                //    // Show newPortfolio as a modal dialog and determine if DialogResult = OK.
                //    if (newPortfolio.ShowDialog(this) == DialogResult.OK)
                //    {
                //        // Read the contents of newPortfolio's TextBox.
                //        this.comboBoxPortfolio.Text = newPortfolio.portfolioUserInput.Text;
                //    }
                //    else
                //    {
                //        this.comboBoxPortfolio.Text = "Cancelled";
                //    }
                //    newPortfolio.Dispose();
                //    break;
                default:
                    Console.WriteLine(comboBoxPortfolio.SelectedIndex);
                    break;
            }
        }
    }
}

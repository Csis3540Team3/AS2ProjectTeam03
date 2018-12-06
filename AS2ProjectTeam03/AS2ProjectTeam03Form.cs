using AS2ProjectTeam03.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            //onclick placeholder
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
            textBoxTransactionAmount.Click += AmountResetText;
            textBoxTransactionAmount.LostFocus += AmountRestoreText;
            textBoxCost.Click += CostResetText;
            textBoxCost.LostFocus += CostRestoreText;
            comboBoxSymbol.Click += ShowSymbols;
            comboBoxSymbol.SelectedItem = "Select Coin";
        }
        private void ShowSymbols(object sender, EventArgs e)
        {
            comboBoxSymbol.DroppedDown = true;
        }
        private void AmountResetText(object sender, EventArgs e)
        {
            //clear if not already filled
            if (textBoxTransactionAmount.Text == "Amount of Units")
            {
                textBoxTransactionAmount.Text = "";
                textBoxTransactionAmount.ForeColor = Color.Black;
            }
        }
        private void AmountRestoreText(object sender, EventArgs e)
        {
            //if left blank
            if (textBoxTransactionAmount.Text == "")
            {
                textBoxTransactionAmount.Text = "Amount of Units";
                textBoxTransactionAmount.ForeColor = Color.Gray;
            }
        }
        private void CostResetText(object sender, EventArgs e)
        {
            //if not filled already
            if (textBoxCost.Text == "Cost per Unit")
            {
                textBoxCost.Text = "";
                textBoxCost.ForeColor = Color.Black;
            }
        }
        private void CostRestoreText(object sender, EventArgs e)
        {
            //if left blank
            if (textBoxCost.Text == "")
            {
                textBoxCost.Text = "Cost per Unit";
                textBoxCost.ForeColor = Color.Gray;
            }
        }
        private void comboBoxPortfolio_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            //seed coin data
            List<Datum> datumList = SeedCoinData();
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
                new Transaction {transactionId=1,transactionPorfolioId=1, transactionCoinId=1, transactionAmount=3.14, transactionPricePerCoin=1255.15},
                new Transaction {transactionId=2,transactionPorfolioId=1, transactionCoinId=1027, transactionAmount=4.23, transactionPricePerCoin=15.21}
            };
            context.Transactions.AddRange(testTransactionList);
            context.SaveChanges();
            //seed coins into combobox
            comboBoxSymbol.Items.AddRange((
                from coin in context.Coins
                orderby coin.coinSymbol
                select coin.coinSymbol
                ).ToArray());
            //set DataSource for dataGridView
            DataGridViewPortfolioDataSource();
            //set quote date
            labelDateTime.Text = datumList[0].last_updated.ToString();
        }
        List<Datum> SeedCoinData()
        {
            //load initial data into a list of datum
            List<Datum> datumList = new InitialData().GetInitialData();
            //pases a Datum list and gets a CoinRow list
            List<CoinRow> initialCoinRows = new ListDatumToListCoinRow().GetCoinRows(datumList);
            //set initial coins into database context
            context.Coins.AddRange((from coin in datumList
                                    where (checkBoxMaxSupply.Checked == true && coin.max_supply > 0 || checkBoxMaxSupply.Checked == false)
                                    select new Coin
                                    {
                                        coinName = coin.name,
                                        coinId = coin.id,
                                        coinSymbol = coin.symbol,
                                        coinMaxSupply = coin.max_supply
                                    }).ToList());
            context.SaveChanges();
            dataGridViewCoins.Refresh();
            dataGridViewCoins.DataSource = context.Coins.Local.ToBindingList();
            return datumList;
        }
        /// <summary>
        /// returns a list to use as datasouce in portfolio data grid view
        /// </summary>
        /// <returns></returns>
        private List<PortfolioRow> DataGridViewPortfolioDataSource()
        {
            List<PortfolioRow> portfolioRowList = new List<PortfolioRow>();
            portfolioRowList =
                (from transaction in context.Transactions
                 join coin in context.Coins on transaction.transactionCoinId equals coin.coinId
                 where (checkBoxMaxSupply.Checked==true && coin.coinMaxSupply>0 || checkBoxMaxSupply.Checked == false)
                 select new PortfolioRow
                 {
                     CoinId = coin.coinId,
                     CoinName = coin.coinName,
                     CoinSymbol = coin.coinSymbol,
                     TransactionAmount = transaction.transactionAmount,
                     TransactionPricePerCoin = transaction.transactionPricePerCoin,
                     TransactionTotal = transaction.transactionAmount * transaction.transactionPricePerCoin
                 }).ToList();
            //calculate total value of portfolio
            double calculateTotalPortfolioValue = (from entry in portfolioRowList select entry.TransactionTotal).Sum();
            //publish total value of portfolio
            labelCurrentValue.Text = calculateTotalPortfolioValue.ToString("C2");
            //seed initial data into datagridview
            dataGridViewPortfolio.DataSource = portfolioRowList;
            return portfolioRowList;
        }
        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            if (comboBoxSymbol.SelectedItem.ToString() != "Select Coin" && textBoxTransactionAmount.Text != "Amount of Units" && textBoxCost.Text != "Cost per Unit")
            {
                Console.WriteLine($"{comboBoxSymbol.SelectedItem} {textBoxTransactionAmount.Text} ${textBoxCost.Text}");
                int maxTransactionId = (from transaction in context.Transactions
                                        select transaction.transactionId).Max() + 1;
                int thisCoinId = (from coin in context.Coins
                                  where coin.coinSymbol == comboBoxSymbol.SelectedItem.ToString()
                                  select coin.coinId).First();
                Transaction userTransaction = new Transaction
                {
                    transactionId = maxTransactionId,
                    transactionCoinId = thisCoinId,
                    transactionAmount = double.Parse(textBoxTransactionAmount.Text),
                    transactionPorfolioId = 1,
                    transactionPricePerCoin = double.Parse(textBoxCost.Text),
                };
                context.Transactions.Add(userTransaction);
                context.SaveChanges();
                dataGridViewPortfolio.Refresh();
                DataGridViewPortfolioDataSource();
            }
            else
            {
                MessageBox.Show("Please enter all Coin, Amount, and Cost", "Enter all info");
            }
        }

        private void buttonExportPortfolio_Click(object sender, EventArgs e)
        {
            List<PortfolioRow> portfolioRowList = DataGridViewPortfolioDataSource();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<PortfolioRow>));
            using (TextWriter writer = new StreamWriter(Path.GetFullPath(Application.StartupPath + "\\..\\..\\..\\xmlExport.xml")))
            {
                xmlSerializer.Serialize(writer, portfolioRowList);
            }
            MessageBox.Show("Exported to the project folder as xmlExport.xml!", "Success");
        }

        private void checkBoxMaxSupply_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPortfolio.Refresh();
            DataGridViewPortfolioDataSource();
            dataGridViewCoins.Refresh();
            //SeedCoinData();
        }
    }
}

using AS2ProjectTeam03.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AS2ProjectTeam03Form()
        {
            InitializeComponent();
            //async request
            List<Datum> jsonList = WebRequest().Result;
            //initial data
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //RootObject rootObject = js.Deserialize<RootObject>(new InitialJson().InitialJsonString);
            //List<Datum> initialJson = rootObject.data;
            //get initial coin data
            List<CoinRow> coinRows = new InitializeData().GetCoinRows(jsonList);
            //seed initial data into datagridview
            dataGridViewCoins.DataSource = coinRows;
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
            int formWidth = this.Width;
            //get combobox centre point x
            int comboBoxPortfolioCentreX = (formWidth / 2) - (comboBoxPortfolio.Width / 2);
            //center the combobox
            comboBoxPortfolio.Location = new Point(comboBoxPortfolioCentreX, 8);
            comboBoxPortfolio.SelectedItem = "All Coins";
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

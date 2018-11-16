using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static AS2ProjectTeam03.DataTypes;

namespace AS2ProjectTeam03
{
    public partial class AS2ProjectTeam03Form : Form
    {
        public AS2ProjectTeam03Form()
        {
            //run
            InitializeComponent();

            // Get Initial Coin Data
            var coinRows = new InitializeData().GetCoinRows();
            //seed initial data into datagridview
            dataGridViewCoins.DataSource = coinRows;

        }
    }
}

﻿using System;
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
            InitializeComponent();

            //get initial coin data (from RestSharp)
            var coinRows = new InitializeData().GetCoinRows();
            //seed initial data into datagridview
            dataGridViewCoins.DataSource = coinRows;
            //get portfolio value
            double portfolioValue = 0.0;
            //set portfolio label value
            labelCurrentValue.Text = portfolioValue.ToString("C2");
        }
    }
}

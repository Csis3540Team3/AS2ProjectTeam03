﻿namespace AS2ProjectTeam03
{
    partial class AS2ProjectTeam03Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCurrentValue = new System.Windows.Forms.Label();
            this.dataGridViewCoins = new System.Windows.Forms.DataGridView();
            this.comboBoxPortfolio = new System.Windows.Forms.ComboBox();
            this.labelAddTransaction = new System.Windows.Forms.Label();
            this.textBoxTransactionAmount = new System.Windows.Forms.TextBox();
            this.comboBoxCoins = new System.Windows.Forms.ComboBox();
            this.textBoxCostUnit = new System.Windows.Forms.TextBox();
            this.buttonExportPortfolio = new System.Windows.Forms.Button();
            this.buttonRestorePortfolio = new System.Windows.Forms.Button();
            this.labelFilterBy = new System.Windows.Forms.Label();
            this.labelValueMin = new System.Windows.Forms.Label();
            this.labelValueMax = new System.Windows.Forms.Label();
            this.textBoxValueMin = new System.Windows.Forms.TextBox();
            this.textBoxValueMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxMaxSupply = new System.Windows.Forms.CheckBox();
            this.buttonUpdateQuotes = new System.Windows.Forms.Button();
            this.dataGridViewPortfolio = new System.Windows.Forms.DataGridView();
            this.labelAddAPortfolio = new System.Windows.Forms.Label();
            this.textBoxPortfolioName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLatestQuotes = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.checkBoxIsMineable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPortfolio)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentValue
            // 
            this.labelCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCurrentValue.Location = new System.Drawing.Point(658, 16);
            this.labelCurrentValue.Name = "labelCurrentValue";
            this.labelCurrentValue.Size = new System.Drawing.Size(491, 32);
            this.labelCurrentValue.TabIndex = 1;
            this.labelCurrentValue.Text = "$3,721.39";
            this.labelCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewCoins
            // 
            this.dataGridViewCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoins.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewCoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCoins.Name = "dataGridViewCoins";
            this.dataGridViewCoins.RowTemplate.Height = 24;
            this.dataGridViewCoins.Size = new System.Drawing.Size(1137, 303);
            this.dataGridViewCoins.TabIndex = 2;
            // 
            // comboBoxPortfolio
            // 
            this.comboBoxPortfolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPortfolio.FormattingEnabled = true;
            this.comboBoxPortfolio.Items.AddRange(new object[] {
            "My Portfolio"});
            this.comboBoxPortfolio.Location = new System.Drawing.Point(12, 6);
            this.comboBoxPortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPortfolio.Name = "comboBoxPortfolio";
            this.comboBoxPortfolio.Size = new System.Drawing.Size(184, 37);
            this.comboBoxPortfolio.TabIndex = 0;
            this.comboBoxPortfolio.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortfolio_SelectedIndexChanged);
            // 
            // labelAddTransaction
            // 
            this.labelAddTransaction.AutoSize = true;
            this.labelAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTransaction.Location = new System.Drawing.Point(12, 246);
            this.labelAddTransaction.Name = "labelAddTransaction";
            this.labelAddTransaction.Size = new System.Drawing.Size(145, 20);
            this.labelAddTransaction.TabIndex = 3;
            this.labelAddTransaction.Text = "Add a transaction:";
            // 
            // textBoxTransactionAmount
            // 
            this.textBoxTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransactionAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxTransactionAmount.Location = new System.Drawing.Point(163, 243);
            this.textBoxTransactionAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTransactionAmount.Name = "textBoxTransactionAmount";
            this.textBoxTransactionAmount.Size = new System.Drawing.Size(152, 26);
            this.textBoxTransactionAmount.TabIndex = 4;
            this.textBoxTransactionAmount.Text = "Amount of Units...";
            // 
            // comboBoxCoins
            // 
            this.comboBoxCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCoins.FormattingEnabled = true;
            this.comboBoxCoins.Items.AddRange(new object[] {
            "Select Coin to Add...",
            "BTC",
            "ETH",
            "XLM"});
            this.comboBoxCoins.Location = new System.Drawing.Point(456, 241);
            this.comboBoxCoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCoins.Name = "comboBoxCoins";
            this.comboBoxCoins.Size = new System.Drawing.Size(201, 28);
            this.comboBoxCoins.TabIndex = 5;
            // 
            // textBoxCostUnit
            // 
            this.textBoxCostUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostUnit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxCostUnit.Location = new System.Drawing.Point(321, 242);
            this.textBoxCostUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCostUnit.Name = "textBoxCostUnit";
            this.textBoxCostUnit.Size = new System.Drawing.Size(129, 27);
            this.textBoxCostUnit.TabIndex = 6;
            this.textBoxCostUnit.Text = "Cost per unit";
            // 
            // buttonExportPortfolio
            // 
            this.buttonExportPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportPortfolio.Location = new System.Drawing.Point(769, 231);
            this.buttonExportPortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportPortfolio.Name = "buttonExportPortfolio";
            this.buttonExportPortfolio.Size = new System.Drawing.Size(187, 39);
            this.buttonExportPortfolio.TabIndex = 7;
            this.buttonExportPortfolio.Text = "Export Portfolio";
            this.buttonExportPortfolio.UseVisualStyleBackColor = true;
            // 
            // buttonRestorePortfolio
            // 
            this.buttonRestorePortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestorePortfolio.Location = new System.Drawing.Point(962, 231);
            this.buttonRestorePortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestorePortfolio.Name = "buttonRestorePortfolio";
            this.buttonRestorePortfolio.Size = new System.Drawing.Size(187, 39);
            this.buttonRestorePortfolio.TabIndex = 7;
            this.buttonRestorePortfolio.Text = "Restore Portfolio";
            this.buttonRestorePortfolio.UseVisualStyleBackColor = true;
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.AutoSize = true;
            this.labelFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterBy.Location = new System.Drawing.Point(12, 635);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(74, 20);
            this.labelFilterBy.TabIndex = 3;
            this.labelFilterBy.Text = "Filter by:";
            // 
            // labelValueMin
            // 
            this.labelValueMin.AutoSize = true;
            this.labelValueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueMin.Location = new System.Drawing.Point(10, 664);
            this.labelValueMin.Name = "labelValueMin";
            this.labelValueMin.Size = new System.Drawing.Size(88, 20);
            this.labelValueMin.TabIndex = 3;
            this.labelValueMin.Text = "Value Min:";
            // 
            // labelValueMax
            // 
            this.labelValueMax.AutoSize = true;
            this.labelValueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueMax.Location = new System.Drawing.Point(10, 707);
            this.labelValueMax.Name = "labelValueMax";
            this.labelValueMax.Size = new System.Drawing.Size(92, 20);
            this.labelValueMax.TabIndex = 3;
            this.labelValueMax.Text = "Value Max:";
            // 
            // textBoxValueMin
            // 
            this.textBoxValueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueMin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxValueMin.Location = new System.Drawing.Point(104, 661);
            this.textBoxValueMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValueMin.Name = "textBoxValueMin";
            this.textBoxValueMin.Size = new System.Drawing.Size(129, 27);
            this.textBoxValueMin.TabIndex = 6;
            // 
            // textBoxValueMax
            // 
            this.textBoxValueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueMax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxValueMax.Location = new System.Drawing.Point(104, 703);
            this.textBoxValueMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValueMax.Name = "textBoxValueMax";
            this.textBoxValueMax.Size = new System.Drawing.Size(129, 27);
            this.textBoxValueMax.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volume Max:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(366, 661);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Location = new System.Drawing.Point(366, 703);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 27);
            this.textBox3.TabIndex = 6;
            // 
            // checkBoxMaxSupply
            // 
            this.checkBoxMaxSupply.AutoSize = true;
            this.checkBoxMaxSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMaxSupply.Location = new System.Drawing.Point(569, 663);
            this.checkBoxMaxSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMaxSupply.Name = "checkBoxMaxSupply";
            this.checkBoxMaxSupply.Size = new System.Drawing.Size(167, 24);
            this.checkBoxMaxSupply.TabIndex = 8;
            this.checkBoxMaxSupply.Text = "Has a Max Supply";
            this.checkBoxMaxSupply.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateQuotes
            // 
            this.buttonUpdateQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateQuotes.Location = new System.Drawing.Point(962, 278);
            this.buttonUpdateQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateQuotes.Name = "buttonUpdateQuotes";
            this.buttonUpdateQuotes.Size = new System.Drawing.Size(187, 37);
            this.buttonUpdateQuotes.TabIndex = 9;
            this.buttonUpdateQuotes.Text = "Update Quotes";
            this.buttonUpdateQuotes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPortfolio
            // 
            this.dataGridViewPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPortfolio.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewPortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPortfolio.Name = "dataGridViewPortfolio";
            this.dataGridViewPortfolio.RowTemplate.Height = 24;
            this.dataGridViewPortfolio.Size = new System.Drawing.Size(1137, 177);
            this.dataGridViewPortfolio.TabIndex = 2;
            // 
            // labelAddAPortfolio
            // 
            this.labelAddAPortfolio.AutoSize = true;
            this.labelAddAPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAPortfolio.Location = new System.Drawing.Point(202, 16);
            this.labelAddAPortfolio.Name = "labelAddAPortfolio";
            this.labelAddAPortfolio.Size = new System.Drawing.Size(124, 20);
            this.labelAddAPortfolio.TabIndex = 3;
            this.labelAddAPortfolio.Text = "Add a Portfolio:";
            // 
            // textBoxPortfolioName
            // 
            this.textBoxPortfolioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPortfolioName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPortfolioName.Location = new System.Drawing.Point(343, 13);
            this.textBoxPortfolioName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPortfolioName.Name = "textBoxPortfolioName";
            this.textBoxPortfolioName.Size = new System.Drawing.Size(152, 26);
            this.textBoxPortfolioName.TabIndex = 4;
            this.textBoxPortfolioName.Text = "Portfolio Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(501, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "New Portfolio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLatestQuotes
            // 
            this.labelLatestQuotes.AutoSize = true;
            this.labelLatestQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestQuotes.Location = new System.Drawing.Point(12, 299);
            this.labelLatestQuotes.Name = "labelLatestQuotes";
            this.labelLatestQuotes.Size = new System.Drawing.Size(120, 20);
            this.labelLatestQuotes.TabIndex = 3;
            this.labelLatestQuotes.Text = "Latest Quotes:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(138, 299);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(82, 20);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "DateTime";
            // 
            // checkBoxIsMineable
            // 
            this.checkBoxIsMineable.AutoSize = true;
            this.checkBoxIsMineable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsMineable.Location = new System.Drawing.Point(569, 703);
            this.checkBoxIsMineable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsMineable.Name = "checkBoxIsMineable";
            this.checkBoxIsMineable.Size = new System.Drawing.Size(116, 24);
            this.checkBoxIsMineable.TabIndex = 10;
            this.checkBoxIsMineable.Text = "Is Mineable";
            this.checkBoxIsMineable.UseVisualStyleBackColor = true;
            // 
            // AS2ProjectTeam03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 751);
            this.Controls.Add(this.checkBoxIsMineable);
            this.Controls.Add(this.buttonUpdateQuotes);
            this.Controls.Add(this.checkBoxMaxSupply);
            this.Controls.Add(this.buttonRestorePortfolio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExportPortfolio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxValueMax);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxValueMin);
            this.Controls.Add(this.textBoxCostUnit);
            this.Controls.Add(this.comboBoxCoins);
            this.Controls.Add(this.textBoxPortfolioName);
            this.Controls.Add(this.textBoxTransactionAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelValueMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelValueMin);
            this.Controls.Add(this.labelFilterBy);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelLatestQuotes);
            this.Controls.Add(this.labelAddAPortfolio);
            this.Controls.Add(this.labelAddTransaction);
            this.Controls.Add(this.comboBoxPortfolio);
            this.Controls.Add(this.dataGridViewPortfolio);
            this.Controls.Add(this.dataGridViewCoins);
            this.Controls.Add(this.labelCurrentValue);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AS2ProjectTeam03Form";
            this.Text = "Coin Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPortfolio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentValue;
        private System.Windows.Forms.DataGridView dataGridViewCoins;
        private System.Windows.Forms.ComboBox comboBoxPortfolio;
        private System.Windows.Forms.Label labelAddTransaction;
        private System.Windows.Forms.TextBox textBoxTransactionAmount;
        private System.Windows.Forms.ComboBox comboBoxCoins;
        private System.Windows.Forms.TextBox textBoxCostUnit;
        private System.Windows.Forms.Button buttonExportPortfolio;
        private System.Windows.Forms.Button buttonRestorePortfolio;
        private System.Windows.Forms.Label labelFilterBy;
        private System.Windows.Forms.Label labelValueMin;
        private System.Windows.Forms.Label labelValueMax;
        private System.Windows.Forms.TextBox textBoxValueMin;
        private System.Windows.Forms.TextBox textBoxValueMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxMaxSupply;
        private System.Windows.Forms.Button buttonUpdateQuotes;
        private System.Windows.Forms.DataGridView dataGridViewPortfolio;
        private System.Windows.Forms.Label labelAddAPortfolio;
        private System.Windows.Forms.TextBox textBoxPortfolioName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLatestQuotes;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.CheckBox checkBoxIsMineable;
    }
}

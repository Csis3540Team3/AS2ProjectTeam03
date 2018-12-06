namespace AS2ProjectTeam03
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
            this.comboBoxSymbol = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
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
            this.buttonAddTransaction = new System.Windows.Forms.Button();
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
            this.dataGridViewCoins.Location = new System.Drawing.Point(12, 336);
            this.dataGridViewCoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCoins.Name = "dataGridViewCoins";
            this.dataGridViewCoins.RowTemplate.Height = 24;
            this.dataGridViewCoins.Size = new System.Drawing.Size(1137, 288);
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
            this.comboBoxPortfolio.Visible = false;
            this.comboBoxPortfolio.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortfolio_SelectedIndexChanged);
            // 
            // labelAddTransaction
            // 
            this.labelAddTransaction.AutoSize = true;
            this.labelAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTransaction.Location = new System.Drawing.Point(12, 241);
            this.labelAddTransaction.Name = "labelAddTransaction";
            this.labelAddTransaction.Size = new System.Drawing.Size(145, 20);
            this.labelAddTransaction.TabIndex = 3;
            this.labelAddTransaction.Text = "Add a transaction:";
            // 
            // textBoxTransactionAmount
            // 
            this.textBoxTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransactionAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxTransactionAmount.Location = new System.Drawing.Point(308, 238);
            this.textBoxTransactionAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTransactionAmount.Name = "textBoxTransactionAmount";
            this.textBoxTransactionAmount.Size = new System.Drawing.Size(152, 26);
            this.textBoxTransactionAmount.TabIndex = 4;
            this.textBoxTransactionAmount.Text = "Amount of Units";
            // 
            // comboBoxSymbol
            // 
            this.comboBoxSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSymbol.FormattingEnabled = true;
            this.comboBoxSymbol.Items.AddRange(new object[] {
            "Select Coin"});
            this.comboBoxSymbol.Location = new System.Drawing.Point(181, 238);
            this.comboBoxSymbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSymbol.Name = "comboBoxSymbol";
            this.comboBoxSymbol.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSymbol.TabIndex = 5;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxCost.Location = new System.Drawing.Point(466, 237);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(129, 27);
            this.textBoxCost.TabIndex = 6;
            this.textBoxCost.Text = "Cost per Unit";
            // 
            // buttonExportPortfolio
            // 
            this.buttonExportPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportPortfolio.Location = new System.Drawing.Point(962, 231);
            this.buttonExportPortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportPortfolio.Name = "buttonExportPortfolio";
            this.buttonExportPortfolio.Size = new System.Drawing.Size(187, 39);
            this.buttonExportPortfolio.TabIndex = 7;
            this.buttonExportPortfolio.Text = "Export Portfolio";
            this.buttonExportPortfolio.UseVisualStyleBackColor = true;
            this.buttonExportPortfolio.Click += new System.EventHandler(this.buttonExportPortfolio_Click);
            // 
            // buttonRestorePortfolio
            // 
            this.buttonRestorePortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestorePortfolio.Location = new System.Drawing.Point(769, 232);
            this.buttonRestorePortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestorePortfolio.Name = "buttonRestorePortfolio";
            this.buttonRestorePortfolio.Size = new System.Drawing.Size(187, 39);
            this.buttonRestorePortfolio.TabIndex = 7;
            this.buttonRestorePortfolio.Text = "Restore Portfolio";
            this.buttonRestorePortfolio.UseVisualStyleBackColor = true;
            this.buttonRestorePortfolio.Visible = false;
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
            this.labelValueMin.Location = new System.Drawing.Point(443, 635);
            this.labelValueMin.Name = "labelValueMin";
            this.labelValueMin.Size = new System.Drawing.Size(88, 20);
            this.labelValueMin.TabIndex = 3;
            this.labelValueMin.Text = "Value Min:";
            this.labelValueMin.Visible = false;
            // 
            // labelValueMax
            // 
            this.labelValueMax.AutoSize = true;
            this.labelValueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueMax.Location = new System.Drawing.Point(443, 678);
            this.labelValueMax.Name = "labelValueMax";
            this.labelValueMax.Size = new System.Drawing.Size(92, 20);
            this.labelValueMax.TabIndex = 3;
            this.labelValueMax.Text = "Value Max:";
            this.labelValueMax.Visible = false;
            // 
            // textBoxValueMin
            // 
            this.textBoxValueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueMin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxValueMin.Location = new System.Drawing.Point(537, 632);
            this.textBoxValueMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValueMin.Name = "textBoxValueMin";
            this.textBoxValueMin.Size = new System.Drawing.Size(129, 27);
            this.textBoxValueMin.TabIndex = 6;
            this.textBoxValueMin.Visible = false;
            // 
            // textBoxValueMax
            // 
            this.textBoxValueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueMax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxValueMax.Location = new System.Drawing.Point(537, 674);
            this.textBoxValueMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValueMax.Name = "textBoxValueMax";
            this.textBoxValueMax.Size = new System.Drawing.Size(129, 27);
            this.textBoxValueMax.TabIndex = 6;
            this.textBoxValueMax.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume Min:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volume Max:";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(799, 632);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Location = new System.Drawing.Point(799, 674);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 27);
            this.textBox3.TabIndex = 6;
            this.textBox3.Visible = false;
            // 
            // checkBoxMaxSupply
            // 
            this.checkBoxMaxSupply.AutoSize = true;
            this.checkBoxMaxSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMaxSupply.Location = new System.Drawing.Point(104, 634);
            this.checkBoxMaxSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMaxSupply.Name = "checkBoxMaxSupply";
            this.checkBoxMaxSupply.Size = new System.Drawing.Size(167, 24);
            this.checkBoxMaxSupply.TabIndex = 8;
            this.checkBoxMaxSupply.Text = "Has a Max Supply";
            this.checkBoxMaxSupply.UseVisualStyleBackColor = true;
            this.checkBoxMaxSupply.CheckedChanged += new System.EventHandler(this.checkBoxMaxSupply_CheckedChanged);
            // 
            // buttonUpdateQuotes
            // 
            this.buttonUpdateQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateQuotes.Location = new System.Drawing.Point(962, 293);
            this.buttonUpdateQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateQuotes.Name = "buttonUpdateQuotes";
            this.buttonUpdateQuotes.Size = new System.Drawing.Size(187, 37);
            this.buttonUpdateQuotes.TabIndex = 9;
            this.buttonUpdateQuotes.Text = "Update Quotes";
            this.buttonUpdateQuotes.UseVisualStyleBackColor = true;
            this.buttonUpdateQuotes.Visible = false;
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
            this.labelAddAPortfolio.Visible = false;
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
            this.textBoxPortfolioName.Visible = false;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTransaction.Location = new System.Drawing.Point(601, 231);
            this.buttonAddTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(84, 39);
            this.buttonAddTransaction.TabIndex = 7;
            this.buttonAddTransaction.Text = "Add";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
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
            this.checkBoxIsMineable.Location = new System.Drawing.Point(298, 634);
            this.checkBoxIsMineable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsMineable.Name = "checkBoxIsMineable";
            this.checkBoxIsMineable.Size = new System.Drawing.Size(116, 24);
            this.checkBoxIsMineable.TabIndex = 10;
            this.checkBoxIsMineable.Text = "Is Mineable";
            this.checkBoxIsMineable.UseVisualStyleBackColor = true;
            this.checkBoxIsMineable.Visible = false;
            // 
            // AS2ProjectTeam03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 719);
            this.Controls.Add(this.checkBoxIsMineable);
            this.Controls.Add(this.buttonUpdateQuotes);
            this.Controls.Add(this.checkBoxMaxSupply);
            this.Controls.Add(this.buttonRestorePortfolio);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.buttonExportPortfolio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxValueMax);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxValueMin);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.comboBoxSymbol);
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
        private System.Windows.Forms.ComboBox comboBoxSymbol;
        private System.Windows.Forms.TextBox textBoxCost;
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
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Label labelLatestQuotes;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.CheckBox checkBoxIsMineable;
    }
}


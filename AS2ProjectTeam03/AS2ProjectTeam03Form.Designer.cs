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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentValue
            // 
            this.labelCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentValue.Location = new System.Drawing.Point(9, 45);
            this.labelCurrentValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentValue.Name = "labelCurrentValue";
            this.labelCurrentValue.Size = new System.Drawing.Size(720, 51);
            this.labelCurrentValue.TabIndex = 1;
            this.labelCurrentValue.Text = "$3,721.39";
            this.labelCurrentValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewCoins
            // 
            this.dataGridViewCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoins.Location = new System.Drawing.Point(9, 150);
            this.dataGridViewCoins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCoins.Name = "dataGridViewCoins";
            this.dataGridViewCoins.RowTemplate.Height = 24;
            this.dataGridViewCoins.Size = new System.Drawing.Size(720, 153);
            this.dataGridViewCoins.TabIndex = 2;
            // 
            // comboBoxPortfolio
            // 
            this.comboBoxPortfolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPortfolio.FormattingEnabled = true;
            this.comboBoxPortfolio.Items.AddRange(new object[] {
            "My Portfolio",
            "Favorites",
            "New..."});
            this.comboBoxPortfolio.Location = new System.Drawing.Point(320, 10);
            this.comboBoxPortfolio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPortfolio.Name = "comboBoxPortfolio";
            this.comboBoxPortfolio.Size = new System.Drawing.Size(139, 32);
            this.comboBoxPortfolio.TabIndex = 0;
            // 
            // labelAddTransaction
            // 
            this.labelAddTransaction.AutoSize = true;
            this.labelAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTransaction.Location = new System.Drawing.Point(13, 109);
            this.labelAddTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddTransaction.Name = "labelAddTransaction";
            this.labelAddTransaction.Size = new System.Drawing.Size(123, 17);
            this.labelAddTransaction.TabIndex = 3;
            this.labelAddTransaction.Text = "Add a transaction:";
            // 
            // textBoxTransactionAmount
            // 
            this.textBoxTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransactionAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxTransactionAmount.Location = new System.Drawing.Point(126, 106);
            this.textBoxTransactionAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTransactionAmount.Name = "textBoxTransactionAmount";
            this.textBoxTransactionAmount.Size = new System.Drawing.Size(115, 23);
            this.textBoxTransactionAmount.TabIndex = 4;
            this.textBoxTransactionAmount.Text = "Amount of Units...";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select Coin to Add...",
            "BTC",
            "ETH",
            "XLM"});
            this.comboBox1.Location = new System.Drawing.Point(346, 106);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(244, 106);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Cost per unit";
            // 
            // buttonExportPortfolio
            // 
            this.buttonExportPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportPortfolio.Location = new System.Drawing.Point(494, 101);
            this.buttonExportPortfolio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExportPortfolio.Name = "buttonExportPortfolio";
            this.buttonExportPortfolio.Size = new System.Drawing.Size(113, 32);
            this.buttonExportPortfolio.TabIndex = 7;
            this.buttonExportPortfolio.Text = "Export Portfolio";
            this.buttonExportPortfolio.UseVisualStyleBackColor = true;
            // 
            // buttonRestorePortfolio
            // 
            this.buttonRestorePortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestorePortfolio.Location = new System.Drawing.Point(616, 101);
            this.buttonRestorePortfolio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRestorePortfolio.Name = "buttonRestorePortfolio";
            this.buttonRestorePortfolio.Size = new System.Drawing.Size(113, 32);
            this.buttonRestorePortfolio.TabIndex = 7;
            this.buttonRestorePortfolio.Text = "Restore Portfolio";
            this.buttonRestorePortfolio.UseVisualStyleBackColor = true;
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.AutoSize = true;
            this.labelFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterBy.Location = new System.Drawing.Point(14, 326);
            this.labelFilterBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(62, 17);
            this.labelFilterBy.TabIndex = 3;
            this.labelFilterBy.Text = "Filter by:";
            // 
            // labelValueMin
            // 
            this.labelValueMin.AutoSize = true;
            this.labelValueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueMin.Location = new System.Drawing.Point(92, 349);
            this.labelValueMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValueMin.Name = "labelValueMin";
            this.labelValueMin.Size = new System.Drawing.Size(74, 17);
            this.labelValueMin.TabIndex = 3;
            this.labelValueMin.Text = "Value Min:";
            // 
            // labelValueMax
            // 
            this.labelValueMax.AutoSize = true;
            this.labelValueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueMax.Location = new System.Drawing.Point(92, 384);
            this.labelValueMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValueMax.Name = "labelValueMax";
            this.labelValueMax.Size = new System.Drawing.Size(77, 17);
            this.labelValueMax.TabIndex = 3;
            this.labelValueMax.Text = "Value Max:";
            // 
            // textBoxValueMin
            // 
            this.textBoxValueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueMin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxValueMin.Location = new System.Drawing.Point(176, 347);
            this.textBoxValueMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValueMin.Name = "textBoxValueMin";
            this.textBoxValueMin.Size = new System.Drawing.Size(98, 23);
            this.textBoxValueMin.TabIndex = 6;
            // 
            // textBoxValueMax
            // 
            this.textBoxValueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueMax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxValueMax.Location = new System.Drawing.Point(176, 381);
            this.textBoxValueMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValueMax.Name = "textBoxValueMax";
            this.textBoxValueMax.Size = new System.Drawing.Size(98, 23);
            this.textBoxValueMax.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volume Max:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(420, 347);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Location = new System.Drawing.Point(420, 381);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 23);
            this.textBox3.TabIndex = 6;
            // 
            // checkBoxMaxSupply
            // 
            this.checkBoxMaxSupply.AutoSize = true;
            this.checkBoxMaxSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMaxSupply.Location = new System.Drawing.Point(589, 345);
            this.checkBoxMaxSupply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMaxSupply.Name = "checkBoxMaxSupply";
            this.checkBoxMaxSupply.Size = new System.Drawing.Size(140, 21);
            this.checkBoxMaxSupply.TabIndex = 8;
            this.checkBoxMaxSupply.Text = "Has a Max Supply";
            this.checkBoxMaxSupply.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateQuotes
            // 
            this.buttonUpdateQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateQuotes.Location = new System.Drawing.Point(589, 378);
            this.buttonUpdateQuotes.Name = "buttonUpdateQuotes";
            this.buttonUpdateQuotes.Size = new System.Drawing.Size(140, 30);
            this.buttonUpdateQuotes.TabIndex = 9;
            this.buttonUpdateQuotes.Text = "Update Quotes";
            this.buttonUpdateQuotes.UseVisualStyleBackColor = true;
            // 
            // AS2ProjectTeam03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 471);
            this.Controls.Add(this.buttonUpdateQuotes);
            this.Controls.Add(this.checkBoxMaxSupply);
            this.Controls.Add(this.buttonRestorePortfolio);
            this.Controls.Add(this.buttonExportPortfolio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxValueMax);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxValueMin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxTransactionAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelValueMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelValueMin);
            this.Controls.Add(this.labelFilterBy);
            this.Controls.Add(this.labelAddTransaction);
            this.Controls.Add(this.comboBoxPortfolio);
            this.Controls.Add(this.dataGridViewCoins);
            this.Controls.Add(this.labelCurrentValue);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AS2ProjectTeam03Form";
            this.Text = "Cryptocurrency Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentValue;
        private System.Windows.Forms.DataGridView dataGridViewCoins;
        private System.Windows.Forms.ComboBox comboBoxPortfolio;
        private System.Windows.Forms.Label labelAddTransaction;
        private System.Windows.Forms.TextBox textBoxTransactionAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}


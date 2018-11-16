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
            this.labelPortfolio = new System.Windows.Forms.Label();
            this.labelCadValue = new System.Windows.Forms.Label();
            this.dataGridViewCoins = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPortfolio
            // 
            this.labelPortfolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPortfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortfolio.Location = new System.Drawing.Point(12, 9);
            this.labelPortfolio.Name = "labelPortfolio";
            this.labelPortfolio.Size = new System.Drawing.Size(960, 32);
            this.labelPortfolio.TabIndex = 0;
            this.labelPortfolio.Text = "My Portfolio";
            this.labelPortfolio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCadValue
            // 
            this.labelCadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadValue.Location = new System.Drawing.Point(12, 45);
            this.labelCadValue.Name = "labelCadValue";
            this.labelCadValue.Size = new System.Drawing.Size(960, 63);
            this.labelCadValue.TabIndex = 1;
            this.labelCadValue.Text = "$3,721.39";
            this.labelCadValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewCoins
            // 
            this.dataGridViewCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoins.Location = new System.Drawing.Point(12, 218);
            this.dataGridViewCoins.Name = "dataGridViewCoins";
            this.dataGridViewCoins.RowTemplate.Height = 24;
            this.dataGridViewCoins.Size = new System.Drawing.Size(960, 188);
            this.dataGridViewCoins.TabIndex = 2;
            // 
            // AS2ProjectTeam03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 628);
            this.Controls.Add(this.dataGridViewCoins);
            this.Controls.Add(this.labelCadValue);
            this.Controls.Add(this.labelPortfolio);
            this.Name = "AS2ProjectTeam03Form";
            this.Text = "Cryptocurrency Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPortfolio;
        private System.Windows.Forms.Label labelCadValue;
        private System.Windows.Forms.DataGridView dataGridViewCoins;
    }
}


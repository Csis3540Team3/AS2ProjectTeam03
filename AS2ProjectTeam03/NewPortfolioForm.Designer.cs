namespace AS2ProjectTeam03
{
    partial class NewPortfolioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.portfolioUserInput = new System.Windows.Forms.TextBox();
            this.newPortfolioCancel = new System.Windows.Forms.Button();
            this.newPortfolioOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type a New Portfolio Name";
            // 
            // portfolioUserInput
            // 
            this.portfolioUserInput.Location = new System.Drawing.Point(13, 37);
            this.portfolioUserInput.Name = "portfolioUserInput";
            this.portfolioUserInput.Size = new System.Drawing.Size(213, 22);
            this.portfolioUserInput.TabIndex = 1;
            // 
            // newPortfolioCancel
            // 
            this.newPortfolioCancel.Location = new System.Drawing.Point(17, 66);
            this.newPortfolioCancel.Name = "newPortfolioCancel";
            this.newPortfolioCancel.Size = new System.Drawing.Size(75, 23);
            this.newPortfolioCancel.TabIndex = 2;
            this.newPortfolioCancel.Text = "Cancel";
            this.newPortfolioCancel.UseVisualStyleBackColor = true;
            // 
            // newPortfolioOk
            // 
            this.newPortfolioOk.Location = new System.Drawing.Point(150, 65);
            this.newPortfolioOk.Name = "newPortfolioOk";
            this.newPortfolioOk.Size = new System.Drawing.Size(75, 23);
            this.newPortfolioOk.TabIndex = 3;
            this.newPortfolioOk.Text = "OK";
            this.newPortfolioOk.UseVisualStyleBackColor = true;
            // 
            // NewPortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.newPortfolioOk);
            this.Controls.Add(this.newPortfolioCancel);
            this.Controls.Add(this.portfolioUserInput);
            this.Controls.Add(this.label1);
            this.Name = "NewPortfolioForm";
            this.Text = "New Portfolio Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portfolioUserInput;
        private System.Windows.Forms.Button newPortfolioCancel;
        private System.Windows.Forms.Button newPortfolioOk;
    }
}
namespace LloydMinsterBank
{
    partial class WithdrawTranscationForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDifferent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(72, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "###";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(72, 144);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(76, 43);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "###";
            // 
            // lblDifferent
            // 
            this.lblDifferent.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold);
            this.lblDifferent.Location = new System.Drawing.Point(331, 240);
            this.lblDifferent.Name = "lblDifferent";
            this.lblDifferent.Size = new System.Drawing.Size(125, 23);
            this.lblDifferent.TabIndex = 3;
            this.lblDifferent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WithdrawTranscationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.lblDifferent);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WithdrawTranscationForm";
            this.Text = "TransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDifferent;
    }
}
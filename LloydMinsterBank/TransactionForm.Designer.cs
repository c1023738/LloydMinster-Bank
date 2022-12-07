namespace LloydMinsterBank
{
    partial class TransactionForm
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
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(356, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "###";
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold);
            this.lblEnterPin.Location = new System.Drawing.Point(346, 251);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(76, 43);
            this.lblEnterPin.TabIndex = 1;
            this.lblEnterPin.Text = "###";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(356, 155);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(76, 43);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "###";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 411);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblEnterPin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.Label lblBalance;
    }
}
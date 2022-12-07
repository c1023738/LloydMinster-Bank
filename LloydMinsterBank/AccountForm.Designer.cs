namespace LloydMinsterBank
{
    partial class AccountForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblCurrentAccount = new System.Windows.Forms.Label();
            this.lblSimpleAccount = new System.Windows.Forms.Label();
            this.lblLongAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Holder: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Account: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "Simple Deposit Account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Long Term Deposit Account:";
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolder.Location = new System.Drawing.Point(13, 53);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(76, 43);
            this.lblAccountHolder.TabIndex = 5;
            this.lblAccountHolder.Text = "###";
            // 
            // lblCurrentAccount
            // 
            this.lblCurrentAccount.AutoSize = true;
            this.lblCurrentAccount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAccount.Location = new System.Drawing.Point(13, 147);
            this.lblCurrentAccount.Name = "lblCurrentAccount";
            this.lblCurrentAccount.Size = new System.Drawing.Size(76, 43);
            this.lblCurrentAccount.TabIndex = 6;
            this.lblCurrentAccount.Text = "###";
            // 
            // lblSimpleAccount
            // 
            this.lblSimpleAccount.AutoSize = true;
            this.lblSimpleAccount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimpleAccount.Location = new System.Drawing.Point(13, 251);
            this.lblSimpleAccount.Name = "lblSimpleAccount";
            this.lblSimpleAccount.Size = new System.Drawing.Size(76, 43);
            this.lblSimpleAccount.TabIndex = 7;
            this.lblSimpleAccount.Text = "###";
            // 
            // lblLongAccount
            // 
            this.lblLongAccount.AutoSize = true;
            this.lblLongAccount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongAccount.Location = new System.Drawing.Point(13, 355);
            this.lblLongAccount.Name = "lblLongAccount";
            this.lblLongAccount.Size = new System.Drawing.Size(76, 43);
            this.lblLongAccount.TabIndex = 8;
            this.lblLongAccount.Text = "###";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblAccountHolder);
            this.panel1.Controls.Add(this.lblCurrentAccount);
            this.panel1.Controls.Add(this.lblLongAccount);
            this.panel1.Controls.Add(this.lblSimpleAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(465, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 450);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 450);
            this.panel2.TabIndex = 10;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Label lblCurrentAccount;
        private System.Windows.Forms.Label lblSimpleAccount;
        private System.Windows.Forms.Label lblLongAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
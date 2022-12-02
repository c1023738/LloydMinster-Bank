namespace LloydMinsterBank
{
    partial class MainMenu
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
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.Current_Account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Simple_Deposit_Account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Long_Term_Deposit_Account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lbl_Information = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(475, 536);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(200, 54);
            this.btn_Withdraw.TabIndex = 4;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(868, 536);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(200, 54);
            this.btn_Deposit.TabIndex = 5;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Current_Account,
            this.Simple_Deposit_Account,
            this.Long_Term_Deposit_Account});
            this.listViewAccounts.FullRowSelect = true;
            this.listViewAccounts.GridLines = true;
            this.listViewAccounts.HideSelection = false;
            this.listViewAccounts.Location = new System.Drawing.Point(413, 94);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(750, 392);
            this.listViewAccounts.TabIndex = 6;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            // 
            // Current_Account
            // 
            this.Current_Account.DisplayIndex = 1;
            this.Current_Account.Text = "Current Account";
            this.Current_Account.Width = 250;
            // 
            // Simple_Deposit_Account
            // 
            this.Simple_Deposit_Account.DisplayIndex = 2;
            this.Simple_Deposit_Account.Text = "Simple Deposit Account";
            this.Simple_Deposit_Account.Width = 250;
            // 
            // Long_Term_Deposit_Account
            // 
            this.Long_Term_Deposit_Account.DisplayIndex = 3;
            this.Long_Term_Deposit_Account.Text = "Long Term Deposit Account";
            this.Long_Term_Deposit_Account.Width = 250;
            // 
            // Lbl_Information
            // 
            this.Lbl_Information.AutoSize = true;
            this.Lbl_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Information.Location = new System.Drawing.Point(130, 135);
            this.Lbl_Information.Name = "Lbl_Information";
            this.Lbl_Information.Size = new System.Drawing.Size(155, 25);
            this.Lbl_Information.TabIndex = 7;
            this.Lbl_Information.Text = "Your Account\'s: ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 643);
            this.Controls.Add(this.Lbl_Information);
            this.Controls.Add(this.listViewAccounts);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_Withdraw);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.Label Lbl_Information;
        private System.Windows.Forms.ColumnHeader Current_Account;
        private System.Windows.Forms.ColumnHeader Simple_Deposit_Account;
        private System.Windows.Forms.ColumnHeader Long_Term_Deposit_Account;
    }
}


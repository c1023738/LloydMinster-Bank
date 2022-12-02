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
            this.Lbl_Information01 = new System.Windows.Forms.Label();
            this.btn_CurrentAccount = new System.Windows.Forms.Button();
            this.btn_SimpleDepositAccount = new System.Windows.Forms.Button();
            this.btn_LongTermDepositAccount = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Information01
            // 
            this.Lbl_Information01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Lbl_Information01.Location = new System.Drawing.Point(48, 52);
            this.Lbl_Information01.Name = "Lbl_Information01";
            this.Lbl_Information01.Size = new System.Drawing.Size(227, 78);
            this.Lbl_Information01.TabIndex = 0;
            this.Lbl_Information01.Text = "Select Account Below";
            this.Lbl_Information01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CurrentAccount
            // 
            this.btn_CurrentAccount.Location = new System.Drawing.Point(51, 154);
            this.btn_CurrentAccount.Name = "btn_CurrentAccount";
            this.btn_CurrentAccount.Size = new System.Drawing.Size(224, 57);
            this.btn_CurrentAccount.TabIndex = 1;
            this.btn_CurrentAccount.Text = "Current Account";
            this.btn_CurrentAccount.UseVisualStyleBackColor = true;
            this.btn_CurrentAccount.Click += new System.EventHandler(this.btn_CurrentAccount_Click);
            // 
            // btn_SimpleDepositAccount
            // 
            this.btn_SimpleDepositAccount.Location = new System.Drawing.Point(51, 281);
            this.btn_SimpleDepositAccount.Name = "btn_SimpleDepositAccount";
            this.btn_SimpleDepositAccount.Size = new System.Drawing.Size(224, 57);
            this.btn_SimpleDepositAccount.TabIndex = 2;
            this.btn_SimpleDepositAccount.Text = "Simple deposit Account";
            this.btn_SimpleDepositAccount.UseVisualStyleBackColor = true;
            this.btn_SimpleDepositAccount.Click += new System.EventHandler(this.btn_SimpleDepositAccount_Click);
            // 
            // btn_LongTermDepositAccount
            // 
            this.btn_LongTermDepositAccount.Location = new System.Drawing.Point(51, 413);
            this.btn_LongTermDepositAccount.Name = "btn_LongTermDepositAccount";
            this.btn_LongTermDepositAccount.Size = new System.Drawing.Size(224, 57);
            this.btn_LongTermDepositAccount.TabIndex = 3;
            this.btn_LongTermDepositAccount.Text = "Long Term Deposit Account";
            this.btn_LongTermDepositAccount.UseVisualStyleBackColor = true;
            this.btn_LongTermDepositAccount.Click += new System.EventHandler(this.btn_LongTermDepositAccount_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(668, 547);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(156, 43);
            this.btn_Withdraw.TabIndex = 4;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(960, 547);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(156, 43);
            this.btn_Deposit.TabIndex = 5;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 643);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_LongTermDepositAccount);
            this.Controls.Add(this.btn_SimpleDepositAccount);
            this.Controls.Add(this.btn_CurrentAccount);
            this.Controls.Add(this.Lbl_Information01);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Information01;
        private System.Windows.Forms.Button btn_CurrentAccount;
        private System.Windows.Forms.Button btn_SimpleDepositAccount;
        private System.Windows.Forms.Button btn_LongTermDepositAccount;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Deposit;
    }
}


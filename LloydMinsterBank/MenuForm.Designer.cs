namespace LloydMinsterBank
{
    partial class MenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWithdrawForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccountForm = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWithdrawForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 209);
            this.panel1.TabIndex = 0;
            // 
            // btnWithdrawForm
            // 
            this.btnWithdrawForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWithdrawForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWithdrawForm.Location = new System.Drawing.Point(0, 0);
            this.btnWithdrawForm.Name = "btnWithdrawForm";
            this.btnWithdrawForm.Size = new System.Drawing.Size(880, 209);
            this.btnWithdrawForm.TabIndex = 0;
            this.btnWithdrawForm.Text = "Withdraw";
            this.btnWithdrawForm.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTransfer);
            this.panel2.Controls.Add(this.btnAccountForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 219);
            this.panel2.TabIndex = 1;
            // 
            // btnAccountForm
            // 
            this.btnAccountForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccountForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccountForm.Location = new System.Drawing.Point(0, 0);
            this.btnAccountForm.Name = "btnAccountForm";
            this.btnAccountForm.Size = new System.Drawing.Size(440, 219);
            this.btnAccountForm.TabIndex = 0;
            this.btnAccountForm.Text = "Account Info";
            this.btnAccountForm.UseVisualStyleBackColor = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTransfer.Location = new System.Drawing.Point(440, 0);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(440, 219);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWithdrawForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccountForm;
        private System.Windows.Forms.Button btnTransfer;
    }
}
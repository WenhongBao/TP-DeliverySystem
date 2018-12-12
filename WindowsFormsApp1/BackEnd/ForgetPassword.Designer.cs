namespace BackEnd
{
    partial class ForgetPassword
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
            this.lblCution = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnGotoLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCution
            // 
            this.lblCution.AutoSize = true;
            this.lblCution.Location = new System.Drawing.Point(207, 165);
            this.lblCution.Name = "lblCution";
            this.lblCution.Size = new System.Drawing.Size(419, 12);
            this.lblCution.TabIndex = 0;
            this.lblCution.Text = "Please input your account and submit, password will send you by Email";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(415, 247);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxAccount
            // 
            this.tbxAccount.Location = new System.Drawing.Point(353, 200);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(137, 21);
            this.tbxAccount.TabIndex = 2;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(279, 203);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(59, 12);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Account: ";
            // 
            // btnGotoLogin
            // 
            this.btnGotoLogin.Location = new System.Drawing.Point(52, 42);
            this.btnGotoLogin.Name = "btnGotoLogin";
            this.btnGotoLogin.Size = new System.Drawing.Size(75, 23);
            this.btnGotoLogin.TabIndex = 4;
            this.btnGotoLogin.Text = "<-Back";
            this.btnGotoLogin.UseVisualStyleBackColor = true;
            this.btnGotoLogin.Click += new System.EventHandler(this.btnGotoLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(207, 368);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 12);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "[Error]";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 522);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGotoLogin);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.tbxAccount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCution);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCution;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnGotoLogin;
        private System.Windows.Forms.Label lblError;
    }
}
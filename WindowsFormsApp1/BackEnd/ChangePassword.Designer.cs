namespace BackEnd
{
    partial class ChangePassword
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblComfirmNewPass = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirmNewPass = new System.Windows.Forms.TextBox();
            this.btnBacktoLogin = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(283, 164);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 12);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(259, 223);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(83, 12);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblComfirmNewPass
            // 
            this.lblComfirmNewPass.AutoSize = true;
            this.lblComfirmNewPass.Location = new System.Drawing.Point(211, 276);
            this.lblComfirmNewPass.Name = "lblComfirmNewPass";
            this.lblComfirmNewPass.Size = new System.Drawing.Size(131, 12);
            this.lblComfirmNewPass.TabIndex = 2;
            this.lblComfirmNewPass.Text = "Confirm New Password:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(348, 161);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 21);
            this.tbxPassword.TabIndex = 3;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(348, 220);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(100, 21);
            this.tbxNewPassword.TabIndex = 4;
            // 
            // tbxConfirmNewPass
            // 
            this.tbxConfirmNewPass.Location = new System.Drawing.Point(348, 273);
            this.tbxConfirmNewPass.Name = "tbxConfirmNewPass";
            this.tbxConfirmNewPass.Size = new System.Drawing.Size(100, 21);
            this.tbxConfirmNewPass.TabIndex = 5;
            // 
            // btnBacktoLogin
            // 
            this.btnBacktoLogin.Location = new System.Drawing.Point(54, 47);
            this.btnBacktoLogin.Name = "btnBacktoLogin";
            this.btnBacktoLogin.Size = new System.Drawing.Size(75, 23);
            this.btnBacktoLogin.TabIndex = 6;
            this.btnBacktoLogin.Text = "<-Back";
            this.btnBacktoLogin.UseVisualStyleBackColor = true;
            this.btnBacktoLogin.Click += new System.EventHandler(this.btnBacktoLogin_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(373, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(211, 419);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 12);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "[Error]";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 522);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBacktoLogin);
            this.Controls.Add(this.tbxConfirmNewPass);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblComfirmNewPass);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblComfirmNewPass;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxConfirmNewPass;
        private System.Windows.Forms.Button btnBacktoLogin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblError;
    }
}
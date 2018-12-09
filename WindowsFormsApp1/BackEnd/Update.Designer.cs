namespace BackEnd
{
    partial class Update
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
            this.lblCaution = new System.Windows.Forms.Label();
            this.lblChangeStates = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbbSelectStates = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGotoIndex = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaution
            // 
            this.lblCaution.AutoSize = true;
            this.lblCaution.Location = new System.Drawing.Point(305, 150);
            this.lblCaution.Name = "lblCaution";
            this.lblCaution.Size = new System.Drawing.Size(59, 12);
            this.lblCaution.TabIndex = 0;
            this.lblCaution.Text = "[Caution]";
            // 
            // lblChangeStates
            // 
            this.lblChangeStates.AutoSize = true;
            this.lblChangeStates.Location = new System.Drawing.Point(305, 214);
            this.lblChangeStates.Name = "lblChangeStates";
            this.lblChangeStates.Size = new System.Drawing.Size(113, 12);
            this.lblChangeStates.TabIndex = 1;
            this.lblChangeStates.Text = "Change states to: ";
            // 
            // cbbSelectStates
            // 
            this.cbbSelectStates.FormattingEnabled = true;
            this.cbbSelectStates.Items.AddRange(new object[] {
            "Order Placed",
            "Collecting",
            "Packaging",
            "Dispatching",
            "Payment Done",
            "Parcel Arrive",
            "Waiting Payment",
            "Order Finished"});
            this.cbbSelectStates.Location = new System.Drawing.Point(424, 211);
            this.cbbSelectStates.Name = "cbbSelectStates";
            this.cbbSelectStates.Size = new System.Drawing.Size(121, 20);
            this.cbbSelectStates.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(382, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGotoIndex
            // 
            this.btnGotoIndex.Location = new System.Drawing.Point(47, 26);
            this.btnGotoIndex.Name = "btnGotoIndex";
            this.btnGotoIndex.Size = new System.Drawing.Size(103, 26);
            this.btnGotoIndex.TabIndex = 4;
            this.btnGotoIndex.Text = "<-Back";
            this.btnGotoIndex.UseVisualStyleBackColor = true;
            this.btnGotoIndex.Click += new System.EventHandler(this.btnGotoIndex_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.ForeColor = System.Drawing.Color.Yellow;
            this.lblError.Location = new System.Drawing.Point(45, 390);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 12);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "[Error]";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 522);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGotoIndex);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbbSelectStates);
            this.Controls.Add(this.lblChangeStates);
            this.Controls.Add(this.lblCaution);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaution;
        private System.Windows.Forms.Label lblChangeStates;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbbSelectStates;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGotoIndex;
        private System.Windows.Forms.Label lblError;
    }
}
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCaution
            // 
            this.lblCaution.AutoSize = true;
            this.lblCaution.Location = new System.Drawing.Point(118, 66);
            this.lblCaution.Name = "lblCaution";
            this.lblCaution.Size = new System.Drawing.Size(47, 12);
            this.lblCaution.TabIndex = 0;
            this.lblCaution.Text = "Caution";
            // 
            // lblChangeStates
            // 
            this.lblChangeStates.AutoSize = true;
            this.lblChangeStates.Location = new System.Drawing.Point(124, 155);
            this.lblChangeStates.Name = "lblChangeStates";
            this.lblChangeStates.Size = new System.Drawing.Size(113, 12);
            this.lblChangeStates.TabIndex = 1;
            this.lblChangeStates.Text = "Change states to: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Order Placed",
            "Collecting",
            "Packaging",
            "Dispatching",
            "Payment Done",
            "Parcel Arrive",
            "Waiting Payment",
            "Order Finished"});
            this.comboBox1.Location = new System.Drawing.Point(243, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 522);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
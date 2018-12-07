namespace BackEnd
{
    partial class Index
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
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.lblSearchOrderNo = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxSearchOrderNo = new System.Windows.Forms.TextBox();
            this.lbxOrderInfor = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitDate = new System.Windows.Forms.Button();
            this.btnSubmitOrderNo = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(25, 26);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(83, 12);
            this.lblSearchDate.TabIndex = 0;
            this.lblSearchDate.Text = "Search Date: ";
            // 
            // lblSearchOrderNo
            // 
            this.lblSearchOrderNo.AutoSize = true;
            this.lblSearchOrderNo.Location = new System.Drawing.Point(25, 53);
            this.lblSearchOrderNo.Name = "lblSearchOrderNo";
            this.lblSearchOrderNo.Size = new System.Drawing.Size(101, 12);
            this.lblSearchOrderNo.TabIndex = 2;
            this.lblSearchOrderNo.Text = "Search orderNo: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(693, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Order";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxSearchOrderNo
            // 
            this.tbxSearchOrderNo.Location = new System.Drawing.Point(132, 50);
            this.tbxSearchOrderNo.Name = "tbxSearchOrderNo";
            this.tbxSearchOrderNo.Size = new System.Drawing.Size(122, 21);
            this.tbxSearchOrderNo.TabIndex = 4;
            // 
            // lbxOrderInfor
            // 
            this.lbxOrderInfor.FormattingEnabled = true;
            this.lbxOrderInfor.ItemHeight = 12;
            this.lbxOrderInfor.Location = new System.Drawing.Point(27, 97);
            this.lbxOrderInfor.Name = "lbxOrderInfor";
            this.lbxOrderInfor.Size = new System.Drawing.Size(628, 376);
            this.lbxOrderInfor.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2018, 12, 7, 11, 24, 57, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnSubmitDate
            // 
            this.btnSubmitDate.Location = new System.Drawing.Point(338, 21);
            this.btnSubmitDate.Name = "btnSubmitDate";
            this.btnSubmitDate.Size = new System.Drawing.Size(116, 23);
            this.btnSubmitDate.TabIndex = 7;
            this.btnSubmitDate.Text = "Filter by Date";
            this.btnSubmitDate.UseVisualStyleBackColor = true;
            // 
            // btnSubmitOrderNo
            // 
            this.btnSubmitOrderNo.Location = new System.Drawing.Point(338, 53);
            this.btnSubmitOrderNo.Name = "btnSubmitOrderNo";
            this.btnSubmitOrderNo.Size = new System.Drawing.Size(116, 23);
            this.btnSubmitOrderNo.TabIndex = 8;
            this.btnSubmitOrderNo.Text = "Filter by orderNo";
            this.btnSubmitOrderNo.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(25, 485);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 12);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "[Error]";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 522);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmitOrderNo);
            this.Controls.Add(this.btnSubmitDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbxOrderInfor);
            this.Controls.Add(this.tbxSearchOrderNo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSearchOrderNo);
            this.Controls.Add(this.lblSearchDate);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.Label lblSearchOrderNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxSearchOrderNo;
        private System.Windows.Forms.ListBox lbxOrderInfor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSubmitDate;
        private System.Windows.Forms.Button btnSubmitOrderNo;
        private System.Windows.Forms.Label lblError;
    }
}
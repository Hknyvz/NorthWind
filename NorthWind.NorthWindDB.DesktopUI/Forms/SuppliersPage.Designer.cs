
namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class SuppliersPage
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
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.tbxContactTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxRegion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSuppliers.Location = new System.Drawing.Point(0, 226);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowTemplate.Height = 25;
            this.dgvSuppliers.Size = new System.Drawing.Size(775, 224);
            this.dgvSuppliers.TabIndex = 0;
            this.dgvSuppliers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellDoubleClick);
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(106, 42);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(229, 23);
            this.tbxCompanyName.TabIndex = 1;
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(106, 71);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(229, 23);
            this.tbxContactName.TabIndex = 2;
            // 
            // tbxContactTitle
            // 
            this.tbxContactTitle.Location = new System.Drawing.Point(106, 100);
            this.tbxContactTitle.Name = "tbxContactTitle";
            this.tbxContactTitle.Size = new System.Drawing.Size(229, 23);
            this.tbxContactTitle.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxContactTitle);
            this.groupBox1.Controls.Add(this.tbxCompanyName);
            this.groupBox1.Controls.Add(this.tbxContactName);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phone:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(106, 129);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(229, 23);
            this.tbxPhone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contact Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxRegion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxStreet);
            this.groupBox2.Controls.Add(this.tbxCity);
            this.groupBox2.Controls.Add(this.tbxCountry);
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 179);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Region:";
            // 
            // tbxRegion
            // 
            this.tbxRegion.Location = new System.Drawing.Point(88, 108);
            this.tbxRegion.Name = "tbxRegion";
            this.tbxRegion.Size = new System.Drawing.Size(230, 23);
            this.tbxRegion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Street:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "City:";
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(88, 79);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(230, 23);
            this.tbxStreet.TabIndex = 3;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(88, 21);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(230, 23);
            this.tbxCity.TabIndex = 1;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(88, 50);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(230, 23);
            this.tbxCountry.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(418, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Postal Code:";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(498, 150);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(229, 23);
            this.tbxPostalCode.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(304, 197);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(409, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SuppliersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxPostalCode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSuppliers);
            this.Name = "SuppliersPage";
            this.Text = "SupplierPage";
            this.Load += new System.EventHandler(this.SuppliersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.TextBox tbxContactTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxStreet;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDelete;
    }
}
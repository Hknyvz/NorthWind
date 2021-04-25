
namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class ShippersPage
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
            this.dgvShippers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShippers
            // 
            this.dgvShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShippers.Location = new System.Drawing.Point(0, 195);
            this.dgvShippers.Name = "dgvShippers";
            this.dgvShippers.RowTemplate.Height = 25;
            this.dgvShippers.Size = new System.Drawing.Size(510, 255);
            this.dgvShippers.TabIndex = 0;
            this.dgvShippers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShippers_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxCompanyName);
            this.groupBox1.Controls.Add(this.tbxPhone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company Name:";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(6, 46);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(229, 23);
            this.tbxCompanyName.TabIndex = 1;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(254, 46);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(229, 23);
            this.tbxPhone.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 22);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(165, 145);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 22);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ShippersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShippers);
            this.Name = "ShippersPage";
            this.Text = "ShippersPage";
            this.Load += new System.EventHandler(this.ShippersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShippers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSend;
    }
}
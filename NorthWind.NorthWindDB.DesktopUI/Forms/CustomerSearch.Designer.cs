
namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class CustomerSearch
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 50);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(801, 399);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(109, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer  Company Name:";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(447, 11);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(214, 23);
            this.tbxCustomerName.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(693, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(64, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "CustomerSearch";
            this.Text = "Search:";
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.Button btnOk;
    }
}
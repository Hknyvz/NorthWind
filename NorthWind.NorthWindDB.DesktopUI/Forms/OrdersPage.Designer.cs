
namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class OrdersPage
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxShipper = new System.Windows.Forms.ComboBox();
            this.dtpRequireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOerderDate = new System.Windows.Forms.DateTimePicker();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.btnCustomerSerach = new System.Windows.Forms.Button();
            this.tbxFreight = new System.Windows.Forms.TextBox();
            this.tbxShipName = new System.Windows.Forms.TextBox();
            this.tbxEmployee = new System.Windows.Forms.TextBox();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxRegion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrders.Location = new System.Drawing.Point(0, 302);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.Size = new System.Drawing.Size(974, 228);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.TabStop = false;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpShippedDate);
            this.groupBox1.Controls.Add(this.cbxShipper);
            this.groupBox1.Controls.Add(this.dtpRequireDate);
            this.groupBox1.Controls.Add(this.dtpOerderDate);
            this.groupBox1.Controls.Add(this.btnEmployeeSearch);
            this.groupBox1.Controls.Add(this.btnCustomerSerach);
            this.groupBox1.Controls.Add(this.tbxFreight);
            this.groupBox1.Controls.Add(this.tbxShipName);
            this.groupBox1.Controls.Add(this.tbxEmployee);
            this.groupBox1.Controls.Add(this.tbxCustomer);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbProducts);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Date:";
            // 
            // cbxShipper
            // 
            this.cbxShipper.FormattingEnabled = true;
            this.cbxShipper.Location = new System.Drawing.Point(103, 161);
            this.cbxShipper.Name = "cbxShipper";
            this.cbxShipper.Size = new System.Drawing.Size(252, 23);
            this.cbxShipper.TabIndex = 5;
            // 
            // dtpRequireDate
            // 
            this.dtpRequireDate.Location = new System.Drawing.Point(103, 109);
            this.dtpRequireDate.Name = "dtpRequireDate";
            this.dtpRequireDate.Size = new System.Drawing.Size(252, 23);
            this.dtpRequireDate.TabIndex = 4;
            // 
            // dtpOerderDate
            // 
            this.dtpOerderDate.Location = new System.Drawing.Point(103, 83);
            this.dtpOerderDate.Name = "dtpOerderDate";
            this.dtpOerderDate.Size = new System.Drawing.Size(252, 23);
            this.dtpOerderDate.TabIndex = 3;
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.Location = new System.Drawing.Point(282, 55);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeSearch.TabIndex = 2;
            this.btnEmployeeSearch.Text = "Search";
            this.btnEmployeeSearch.UseVisualStyleBackColor = true;
            this.btnEmployeeSearch.Click += new System.EventHandler(this.btnEmployeeSearch_Click);
            // 
            // btnCustomerSerach
            // 
            this.btnCustomerSerach.Location = new System.Drawing.Point(282, 28);
            this.btnCustomerSerach.Name = "btnCustomerSerach";
            this.btnCustomerSerach.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerSerach.TabIndex = 1;
            this.btnCustomerSerach.Text = "Search";
            this.btnCustomerSerach.UseVisualStyleBackColor = true;
            this.btnCustomerSerach.Click += new System.EventHandler(this.btnCustomerSerach_Click);
            // 
            // tbxFreight
            // 
            this.tbxFreight.Location = new System.Drawing.Point(103, 189);
            this.tbxFreight.Name = "tbxFreight";
            this.tbxFreight.Size = new System.Drawing.Size(252, 23);
            this.tbxFreight.TabIndex = 6;
            // 
            // tbxShipName
            // 
            this.tbxShipName.Location = new System.Drawing.Point(103, 216);
            this.tbxShipName.Name = "tbxShipName";
            this.tbxShipName.Size = new System.Drawing.Size(252, 23);
            this.tbxShipName.TabIndex = 7;
            // 
            // tbxEmployee
            // 
            this.tbxEmployee.Location = new System.Drawing.Point(103, 55);
            this.tbxEmployee.Name = "tbxEmployee";
            this.tbxEmployee.ReadOnly = true;
            this.tbxEmployee.Size = new System.Drawing.Size(180, 23);
            this.tbxEmployee.TabIndex = 14;
            this.tbxEmployee.TabStop = false;
            // 
            // tbxCustomer
            // 
            this.tbxCustomer.Location = new System.Drawing.Point(103, 28);
            this.tbxCustomer.Name = "tbxCustomer";
            this.tbxCustomer.ReadOnly = true;
            this.tbxCustomer.Size = new System.Drawing.Size(180, 23);
            this.tbxCustomer.TabIndex = 13;
            this.tbxCustomer.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ship Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Freight:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Shipper:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Require Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Order Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer:";
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 15;
            this.lbProducts.Location = new System.Drawing.Point(371, 35);
            this.lbProducts.MultiColumn = true;
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(197, 199);
            this.lbProducts.Sorted = true;
            this.lbProducts.TabIndex = 5;
            this.lbProducts.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(418, 10);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(99, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxPostalCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxRegion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxStreet);
            this.groupBox2.Controls.Add(this.tbxCity);
            this.groupBox2.Controls.Add(this.tbxCountry);
            this.groupBox2.Location = new System.Drawing.Point(608, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 255);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Postal Code:";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(91, 168);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(230, 23);
            this.tbxPostalCode.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Region:";
            // 
            // tbxRegion
            // 
            this.tbxRegion.Location = new System.Drawing.Point(91, 139);
            this.tbxRegion.Name = "tbxRegion";
            this.tbxRegion.Size = new System.Drawing.Size(230, 23);
            this.tbxRegion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Street:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "City:";
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(91, 110);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(230, 23);
            this.tbxStreet.TabIndex = 11;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(91, 52);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(230, 23);
            this.tbxCity.TabIndex = 9;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(91, 81);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(230, 23);
            this.tbxCountry.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(426, 273);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(524, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(103, 135);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(252, 23);
            this.dtpShippedDate.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Shipped Date:";
            // 
            // OrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 530);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "OrdersPage";
            this.Text = "OrdersPage";
            this.Load += new System.EventHandler(this.OrdersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.DateTimePicker dtpRequireDate;
        private System.Windows.Forms.DateTimePicker dtpOerderDate;
        private System.Windows.Forms.Button btnEmployeeSearch;
        private System.Windows.Forms.Button btnCustomerSerach;
        private System.Windows.Forms.TextBox tbxFreight;
        private System.Windows.Forms.TextBox tbxShipName;
        private System.Windows.Forms.TextBox tbxEmployee;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxStreet;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.ComboBox cbxShipper;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
    }
}

namespace NorthWind.NorthWindDB.DesktopUI
{
    partial class MainPage
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
            this.orders = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Button();
            this.suppliers = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.shippers = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(12, 22);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(350, 41);
            this.orders.TabIndex = 0;
            this.orders.Text = "Orders";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // categories
            // 
            this.categories.Location = new System.Drawing.Point(12, 69);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(350, 41);
            this.categories.TabIndex = 1;
            this.categories.Text = "Categories";
            this.categories.UseVisualStyleBackColor = true;
            this.categories.Click += new System.EventHandler(this.categories_Click);
            // 
            // products
            // 
            this.products.Location = new System.Drawing.Point(12, 116);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(350, 41);
            this.products.TabIndex = 2;
            this.products.Text = "Products";
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // customers
            // 
            this.customers.Location = new System.Drawing.Point(12, 163);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(350, 41);
            this.customers.TabIndex = 3;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // suppliers
            // 
            this.suppliers.Location = new System.Drawing.Point(12, 210);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(350, 41);
            this.suppliers.TabIndex = 4;
            this.suppliers.Text = "Suppliers";
            this.suppliers.UseVisualStyleBackColor = true;
            this.suppliers.Click += new System.EventHandler(this.suppliers_Click);
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(12, 257);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(350, 41);
            this.employees.TabIndex = 5;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // shippers
            // 
            this.shippers.Location = new System.Drawing.Point(12, 304);
            this.shippers.Name = "shippers";
            this.shippers.Size = new System.Drawing.Size(350, 41);
            this.shippers.TabIndex = 6;
            this.shippers.Text = "Shippers";
            this.shippers.UseVisualStyleBackColor = true;
            this.shippers.Click += new System.EventHandler(this.shippers_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(12, 351);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(350, 41);
            this.logs.TabIndex = 7;
            this.logs.Text = "Request Logs";
            this.logs.UseVisualStyleBackColor = true;
            this.logs.Click += new System.EventHandler(this.logs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Response Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.shippers);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.suppliers);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.products);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.orders);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button categories;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button suppliers;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button shippers;
        private System.Windows.Forms.Button logs;
        private System.Windows.Forms.Button button1;
    }
}

namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class ProductsPage
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDiscontinued = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxReorderLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProduct.Location = new System.Drawing.Point(0, 243);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(766, 207);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxDiscontinued);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxReorderLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxUnitsOnOrder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxUnitsInStock);
            this.groupBox1.Controls.Add(this.cbxSupplier);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxUnitPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxQuantityPerUnit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(110, 37);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(229, 23);
            this.tbxName.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Discontinued:";
            // 
            // tbxDiscontinued
            // 
            this.tbxDiscontinued.Location = new System.Drawing.Point(460, 124);
            this.tbxDiscontinued.Name = "tbxDiscontinued";
            this.tbxDiscontinued.Size = new System.Drawing.Size(229, 23);
            this.tbxDiscontinued.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Reorder Level:";
            // 
            // tbxReorderLevel
            // 
            this.tbxReorderLevel.Location = new System.Drawing.Point(460, 95);
            this.tbxReorderLevel.Name = "tbxReorderLevel";
            this.tbxReorderLevel.Size = new System.Drawing.Size(229, 23);
            this.tbxReorderLevel.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Units On Order:";
            // 
            // tbxUnitsOnOrder
            // 
            this.tbxUnitsOnOrder.Location = new System.Drawing.Point(460, 66);
            this.tbxUnitsOnOrder.Name = "tbxUnitsOnOrder";
            this.tbxUnitsOnOrder.Size = new System.Drawing.Size(229, 23);
            this.tbxUnitsOnOrder.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Units In Stock:";
            // 
            // tbxUnitsInStock
            // 
            this.tbxUnitsInStock.Location = new System.Drawing.Point(460, 37);
            this.tbxUnitsInStock.Name = "tbxUnitsInStock";
            this.tbxUnitsInStock.Size = new System.Drawing.Size(229, 23);
            this.tbxUnitsInStock.TabIndex = 13;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(110, 95);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(229, 23);
            this.cbxSupplier.TabIndex = 12;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(110, 66);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(229, 23);
            this.cbxCategory.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Unit Price:";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(289, 153);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(229, 23);
            this.tbxUnitPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity Per Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Supplier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category:";
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(110, 124);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(229, 23);
            this.tbxQuantityPerUnit.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(398, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(293, 214);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProduct);
            this.Name = "ProductsPage";
            this.Text = "ProductsPage";
            this.Load += new System.EventHandler(this.ProductsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDiscontinued;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxReorderLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUnitsOnOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxUnitsInStock;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSend;
    }
}
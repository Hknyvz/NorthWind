
namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class SearchProducts
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
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tbxSerach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(377, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProducts.Location = new System.Drawing.Point(0, 125);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(800, 325);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // tbxSerach
            // 
            this.tbxSerach.Location = new System.Drawing.Point(70, 11);
            this.tbxSerach.Name = "tbxSerach";
            this.tbxSerach.Size = new System.Drawing.Size(193, 23);
            this.tbxSerach.TabIndex = 2;
            this.tbxSerach.TextChanged += new System.EventHandler(this.tbxSerach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serach:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(63, 61);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(200, 23);
            this.tbxName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount:";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(377, 61);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(202, 23);
            this.tbxDiscount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(63, 96);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(200, 23);
            this.tbxQuantity.TabIndex = 8;
            // 
            // SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSerach);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnOk);
            this.Name = "SearchProducts";
            this.Text = "Ok";
            this.Load += new System.EventHandler(this.SerachProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox tbxSerach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxQuantity;
    }
}
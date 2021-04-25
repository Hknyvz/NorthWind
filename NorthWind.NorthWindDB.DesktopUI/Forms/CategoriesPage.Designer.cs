
namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class CategoriesPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxCategoryName);
            this.groupBox1.Controls.Add(this.tbxDescription);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category Name:";
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.Location = new System.Drawing.Point(6, 46);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(229, 23);
            this.tbxCategoryName.TabIndex = 1;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(254, 46);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(229, 23);
            this.tbxDescription.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(165, 155);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCategories.Location = new System.Drawing.Point(0, 226);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.Size = new System.Drawing.Size(526, 224);
            this.dgvCategories.TabIndex = 17;
            this.dgvCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellDoubleClick);
            // 
            // CategoriesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoriesPage";
            this.Text = "CategoriesPage";
            this.Load += new System.EventHandler(this.CategoriesPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCategoryName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView dgvCategories;
    }
}

namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class EmployeesPage
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxTerriyoryIds = new System.Windows.Forms.TextBox();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.tbxRegion = new System.Windows.Forms.TextBox();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbxTitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxReportsTo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 251);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.Height = 25;
            this.dgvEmployees.Size = new System.Drawing.Size(1115, 199);
            this.dgvEmployees.TabIndex = 99;
            this.dgvEmployees.TabStop = false;
            this.dgvEmployees.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployees_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.tbxTerriyoryIds);
            this.groupBox2.Controls.Add(this.tbxPostalCode);
            this.groupBox2.Controls.Add(this.tbxRegion);
            this.groupBox2.Controls.Add(this.tbxStreet);
            this.groupBox2.Controls.Add(this.tbxCountry);
            this.groupBox2.Controls.Add(this.tbxCity);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 202);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information";
            // 
            // tbxTerriyoryIds
            // 
            this.tbxTerriyoryIds.ForeColor = System.Drawing.Color.Black;
            this.tbxTerriyoryIds.Location = new System.Drawing.Point(88, 167);
            this.tbxTerriyoryIds.Name = "tbxTerriyoryIds";
            this.tbxTerriyoryIds.Size = new System.Drawing.Size(230, 23);
            this.tbxTerriyoryIds.TabIndex = 12;
            this.tbxTerriyoryIds.Enter += new System.EventHandler(this.tbxTerriyoryIds_Enter);
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(88, 136);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(230, 23);
            this.tbxPostalCode.TabIndex = 11;
            // 
            // tbxRegion
            // 
            this.tbxRegion.Location = new System.Drawing.Point(88, 108);
            this.tbxRegion.Name = "tbxRegion";
            this.tbxRegion.Size = new System.Drawing.Size(230, 23);
            this.tbxRegion.TabIndex = 10;
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(88, 79);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(230, 23);
            this.tbxStreet.TabIndex = 9;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(88, 50);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(230, 23);
            this.tbxCountry.TabIndex = 8;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(88, 21);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(230, 23);
            this.tbxCity.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(14, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Territory Ids:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(13, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Postal Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Region:";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dtpHireDate);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.tbxTitleOfCourtesy);
            this.groupBox1.Controls.Add(this.tbxTitle);
            this.groupBox1.Controls.Add(this.tbxLastName);
            this.groupBox1.Controls.Add(this.tbxFirstName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(102, 168);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(230, 23);
            this.dtpHireDate.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(103, 139);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(230, 23);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // tbxTitleOfCourtesy
            // 
            this.tbxTitleOfCourtesy.Location = new System.Drawing.Point(103, 108);
            this.tbxTitleOfCourtesy.Name = "tbxTitleOfCourtesy";
            this.tbxTitleOfCourtesy.Size = new System.Drawing.Size(230, 23);
            this.tbxTitleOfCourtesy.TabIndex = 4;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(103, 79);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(230, 23);
            this.tbxTitle.TabIndex = 3;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(103, 50);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(230, 23);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(103, 21);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(230, 23);
            this.tbxFirstName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(41, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Hire Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(39, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Birth Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title Of Courtesy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "First Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 23);
            this.btnDelete.TabIndex = 101;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(488, 222);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 23);
            this.btnSend.TabIndex = 100;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.tbxReportsTo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.rtbNotes);
            this.groupBox3.Location = new System.Drawing.Point(776, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 202);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notes";
            // 
            // tbxReportsTo
            // 
            this.tbxReportsTo.ForeColor = System.Drawing.Color.Black;
            this.tbxReportsTo.Location = new System.Drawing.Point(83, 168);
            this.tbxReportsTo.Name = "tbxReportsTo";
            this.tbxReportsTo.Size = new System.Drawing.Size(230, 23);
            this.tbxReportsTo.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(16, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Reports To:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(6, 21);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(307, 141);
            this.rtbNotes.TabIndex = 13;
            this.rtbNotes.Text = "";
            // 
            // EmployeesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDelete);
            this.Name = "EmployeesPage";
            this.Text = "EmployeesPage";
            this.Load += new System.EventHandler(this.EmployeesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
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
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTitleOfCourtesy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxTerriyoryIds;
        private System.Windows.Forms.TextBox tbxReportsTo;
        private System.Windows.Forms.Label label13;
    }
}
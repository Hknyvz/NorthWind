
namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class RequestLogsPage
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
            this.dgvRequestLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequestLogs
            // 
            this.dgvRequestLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRequestLogs.Location = new System.Drawing.Point(0, 79);
            this.dgvRequestLogs.Name = "dgvRequestLogs";
            this.dgvRequestLogs.RowTemplate.Height = 25;
            this.dgvRequestLogs.Size = new System.Drawing.Size(613, 371);
            this.dgvRequestLogs.TabIndex = 0;
            // 
            // RequestLogsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.dgvRequestLogs);
            this.Name = "RequestLogsPage";
            this.Text = "LogsPage";
            this.Load += new System.EventHandler(this.RequestLogsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequestLogs;
    }
}

namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    partial class ResponseLogsPage
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
            this.dgvResponseLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponseLogs
            // 
            this.dgvResponseLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponseLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResponseLogs.Location = new System.Drawing.Point(0, 99);
            this.dgvResponseLogs.Name = "dgvResponseLogs";
            this.dgvResponseLogs.RowTemplate.Height = 25;
            this.dgvResponseLogs.Size = new System.Drawing.Size(800, 351);
            this.dgvResponseLogs.TabIndex = 0;
            // 
            // ResponseLogsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResponseLogs);
            this.Name = "ResponseLogsPage";
            this.Text = "ResponseLogsPage";
            this.Load += new System.EventHandler(this.ResponseLogsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponseLogs;
    }
}
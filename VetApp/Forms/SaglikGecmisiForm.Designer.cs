using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class SaglikGecmisiForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dataGridViewSaglikGecmisi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewSaglikGecmisi = new Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaglikGecmisi).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSaglikGecmisi
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewSaglikGecmisi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewSaglikGecmisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSaglikGecmisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewSaglikGecmisi.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSaglikGecmisi.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewSaglikGecmisi.Location = new Point(12, 12);
            dataGridViewSaglikGecmisi.Name = "dataGridViewSaglikGecmisi";
            dataGridViewSaglikGecmisi.RowHeadersVisible = false;
            dataGridViewSaglikGecmisi.RowTemplate.Height = 25;
            dataGridViewSaglikGecmisi.Size = new Size(760, 250);
            dataGridViewSaglikGecmisi.TabIndex = 0;
            dataGridViewSaglikGecmisi.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewSaglikGecmisi.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewSaglikGecmisi.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewSaglikGecmisi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewSaglikGecmisi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewSaglikGecmisi.ThemeStyle.BackColor = Color.White;
            dataGridViewSaglikGecmisi.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewSaglikGecmisi.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewSaglikGecmisi.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSaglikGecmisi.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewSaglikGecmisi.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewSaglikGecmisi.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaglikGecmisi.ThemeStyle.HeaderStyle.Height = 4;
            dataGridViewSaglikGecmisi.ThemeStyle.ReadOnly = false;
            dataGridViewSaglikGecmisi.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewSaglikGecmisi.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSaglikGecmisi.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewSaglikGecmisi.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewSaglikGecmisi.ThemeStyle.RowsStyle.Height = 25;
            dataGridViewSaglikGecmisi.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewSaglikGecmisi.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // SaglikGecmisiForm
            // 
            ClientSize = new Size(784, 269);
            Controls.Add(dataGridViewSaglikGecmisi);
            Name = "SaglikGecmisiForm";
            Text = "Sağlık Geçmişi";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaglikGecmisi).EndInit();
            ResumeLayout(false);
        }
    }
}

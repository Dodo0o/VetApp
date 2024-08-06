using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class AsiBilgileriForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dataGridViewAsiBilgileri;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsiBilgileriForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridViewAsiBilgileri = new Guna2DataGridView();
            guna2PictureBox1 = new Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsiBilgileri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAsiBilgileri
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewAsiBilgileri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAsiBilgileri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAsiBilgileri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewAsiBilgileri.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAsiBilgileri.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewAsiBilgileri.Location = new Point(12, 130);
            dataGridViewAsiBilgileri.Name = "dataGridViewAsiBilgileri";
            dataGridViewAsiBilgileri.RowHeadersVisible = false;
            dataGridViewAsiBilgileri.RowTemplate.Height = 25;
            dataGridViewAsiBilgileri.Size = new Size(760, 380);
            dataGridViewAsiBilgileri.TabIndex = 0;
            dataGridViewAsiBilgileri.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewAsiBilgileri.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewAsiBilgileri.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewAsiBilgileri.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewAsiBilgileri.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewAsiBilgileri.ThemeStyle.BackColor = Color.White;
            dataGridViewAsiBilgileri.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewAsiBilgileri.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewAsiBilgileri.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAsiBilgileri.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewAsiBilgileri.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewAsiBilgileri.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAsiBilgileri.ThemeStyle.HeaderStyle.Height = 4;
            dataGridViewAsiBilgileri.ThemeStyle.ReadOnly = false;
            dataGridViewAsiBilgileri.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewAsiBilgileri.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAsiBilgileri.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewAsiBilgileri.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewAsiBilgileri.ThemeStyle.RowsStyle.Height = 25;
            dataGridViewAsiBilgileri.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewAsiBilgileri.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(332, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(117, 112);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            // 
            // AsiBilgileriForm
            // 
            ClientSize = new Size(784, 522);
            Controls.Add(guna2PictureBox1);
            Controls.Add(dataGridViewAsiBilgileri);
            Name = "AsiBilgileriForm";
            Text = "Aşı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsiBilgileri).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Guna2PictureBox guna2PictureBox1;
    }
}

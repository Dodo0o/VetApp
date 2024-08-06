using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class MusteriForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dataGridViewHayvanlar;
        private Guna2Button btnHayvanEkle;
        private Guna2Button btnHayvanDuzenle;
        private Guna2Button btnHayvanSil;
        private Guna2Button btnMusteriBilgileriniDuzenle;
        private Guna2Button btnSaglikGecmisi;
        private Guna2Button btnAsiBilgileri;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridViewHayvanlar = new Guna2DataGridView();
            btnHayvanEkle = new Guna2Button();
            btnHayvanDuzenle = new Guna2Button();
            btnHayvanSil = new Guna2Button();
            btnMusteriBilgileriniDuzenle = new Guna2Button();
            btnSaglikGecmisi = new Guna2Button();
            btnAsiBilgileri = new Guna2Button();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHayvanlar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHayvanlar
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewHayvanlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewHayvanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHayvanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewHayvanlar.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHayvanlar.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewHayvanlar.Location = new Point(12, 67);
            dataGridViewHayvanlar.Name = "dataGridViewHayvanlar";
            dataGridViewHayvanlar.RowHeadersVisible = false;
            dataGridViewHayvanlar.RowTemplate.Height = 25;
            dataGridViewHayvanlar.Size = new Size(760, 250);
            dataGridViewHayvanlar.TabIndex = 0;
            dataGridViewHayvanlar.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewHayvanlar.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewHayvanlar.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewHayvanlar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewHayvanlar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewHayvanlar.ThemeStyle.BackColor = Color.White;
            dataGridViewHayvanlar.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.Height = 4;
            dataGridViewHayvanlar.ThemeStyle.ReadOnly = false;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.Height = 25;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnHayvanEkle
            // 
            btnHayvanEkle.BorderRadius = 10;
            btnHayvanEkle.CustomizableEdges = customizableEdges1;
            btnHayvanEkle.DisabledState.BorderColor = Color.DarkGray;
            btnHayvanEkle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHayvanEkle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHayvanEkle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHayvanEkle.FillColor = Color.Green;
            btnHayvanEkle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHayvanEkle.ForeColor = Color.White;
            btnHayvanEkle.Location = new Point(14, 355);
            btnHayvanEkle.Name = "btnHayvanEkle";
            btnHayvanEkle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnHayvanEkle.Size = new Size(120, 45);
            btnHayvanEkle.TabIndex = 1;
            btnHayvanEkle.Text = "Hayvan Ekle";
            btnHayvanEkle.Click += btnHayvanEkle_Click;
            // 
            // btnHayvanDuzenle
            // 
            btnHayvanDuzenle.BorderRadius = 10;
            btnHayvanDuzenle.CustomizableEdges = customizableEdges3;
            btnHayvanDuzenle.DisabledState.BorderColor = Color.DarkGray;
            btnHayvanDuzenle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHayvanDuzenle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHayvanDuzenle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHayvanDuzenle.FillColor = Color.Orange;
            btnHayvanDuzenle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHayvanDuzenle.ForeColor = Color.White;
            btnHayvanDuzenle.Location = new Point(138, 355);
            btnHayvanDuzenle.Name = "btnHayvanDuzenle";
            btnHayvanDuzenle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHayvanDuzenle.Size = new Size(120, 45);
            btnHayvanDuzenle.TabIndex = 2;
            btnHayvanDuzenle.Text = "Hayvan Düzenle";
            btnHayvanDuzenle.Click += btnHayvanDuzenle_Click;
            // 
            // btnHayvanSil
            // 
            btnHayvanSil.BorderRadius = 10;
            btnHayvanSil.CustomizableEdges = customizableEdges3;
            btnHayvanSil.DisabledState.BorderColor = Color.DarkGray;
            btnHayvanSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHayvanSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHayvanSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHayvanSil.FillColor = Color.Red;
            btnHayvanSil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHayvanSil.ForeColor = Color.White;
            btnHayvanSil.Location = new Point(264, 355);
            btnHayvanSil.Name = "btnHayvanSil";
            btnHayvanSil.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHayvanSil.Size = new Size(120, 45);
            btnHayvanSil.TabIndex = 3;
            btnHayvanSil.Text = "Hayvan Sil";
            btnHayvanSil.Click += btnHayvanSil_Click;
            // 
            // btnMusteriBilgileriniDuzenle
            // 
            btnMusteriBilgileriniDuzenle.BorderRadius = 10;
            btnMusteriBilgileriniDuzenle.CustomizableEdges = customizableEdges1;
            btnMusteriBilgileriniDuzenle.DisabledState.BorderColor = Color.DarkGray;
            btnMusteriBilgileriniDuzenle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMusteriBilgileriniDuzenle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMusteriBilgileriniDuzenle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMusteriBilgileriniDuzenle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriBilgileriniDuzenle.ForeColor = Color.White;
            btnMusteriBilgileriniDuzenle.Location = new Point(390, 355);
            btnMusteriBilgileriniDuzenle.Name = "btnMusteriBilgileriniDuzenle";
            btnMusteriBilgileriniDuzenle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMusteriBilgileriniDuzenle.Size = new Size(120, 45);
            btnMusteriBilgileriniDuzenle.TabIndex = 4;
            btnMusteriBilgileriniDuzenle.Text = "Bilgilerimi Düzenle";
            btnMusteriBilgileriniDuzenle.Click += btnMusteriBilgileriniDuzenle_Click;
            // 
            // btnSaglikGecmisi
            // 
            btnSaglikGecmisi.BorderRadius = 10;
            btnSaglikGecmisi.CustomizableEdges = customizableEdges1;
            btnSaglikGecmisi.DisabledState.BorderColor = Color.DarkGray;
            btnSaglikGecmisi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaglikGecmisi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaglikGecmisi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaglikGecmisi.FillColor = Color.Pink;
            btnSaglikGecmisi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaglikGecmisi.ForeColor = Color.White;
            btnSaglikGecmisi.Location = new Point(516, 355);
            btnSaglikGecmisi.Name = "btnSaglikGecmisi";
            btnSaglikGecmisi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSaglikGecmisi.Size = new Size(120, 45);
            btnSaglikGecmisi.TabIndex = 5;
            btnSaglikGecmisi.Text = "Sağlık Geçmişi";
            btnSaglikGecmisi.Click += btnSaglikGecmisi_Click;
            // 
            // btnAsiBilgileri
            // 
            btnAsiBilgileri.BorderRadius = 10;
            btnAsiBilgileri.CustomizableEdges = customizableEdges1;
            btnAsiBilgileri.DisabledState.BorderColor = Color.DarkGray;
            btnAsiBilgileri.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAsiBilgileri.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAsiBilgileri.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAsiBilgileri.FillColor = Color.SlateBlue;
            btnAsiBilgileri.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsiBilgileri.ForeColor = Color.White;
            btnAsiBilgileri.Location = new Point(642, 355);
            btnAsiBilgileri.Name = "btnAsiBilgileri";
            btnAsiBilgileri.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAsiBilgileri.Size = new Size(120, 45);
            btnAsiBilgileri.TabIndex = 6;
            btnAsiBilgileri.Text = "Aşı Bilgileri";
            btnAsiBilgileri.Click += btnAsiBilgileri_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(14, 27);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(118, 34);
            guna2HtmlLabel1.TabIndex = 7;
            guna2HtmlLabel1.Text = "Hayvanlar";
            // 
            // MusteriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 418);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnAsiBilgileri);
            Controls.Add(btnSaglikGecmisi);
            Controls.Add(btnMusteriBilgileriniDuzenle);
            Controls.Add(btnHayvanSil);
            Controls.Add(btnHayvanDuzenle);
            Controls.Add(btnHayvanEkle);
            Controls.Add(dataGridViewHayvanlar);
            Name = "MusteriForm";
            Text = "Müşteri Formu";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHayvanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna2HtmlLabel guna2HtmlLabel1;
    }
}

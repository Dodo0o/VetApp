using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class MusteriHayvanDuzenleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2TextBox txtHayvanAdi;
        private Guna2TextBox txtTur;
        private Guna2TextBox txtCins;
        private Guna2DateTimePicker dtpDogumTarihi;
        private Guna2Button btnKaydet;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriHayvanDuzenleForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtHayvanAdi = new Guna2TextBox();
            txtTur = new Guna2TextBox();
            txtCins = new Guna2TextBox();
            dtpDogumTarihi = new Guna2DateTimePicker();
            btnKaydet = new Guna2Button();
            guna2PictureBox1 = new Guna2PictureBox();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtHayvanAdi
            // 
            txtHayvanAdi.BorderRadius = 10;
            txtHayvanAdi.CustomizableEdges = customizableEdges1;
            txtHayvanAdi.DefaultText = "";
            txtHayvanAdi.DisabledState.BorderColor = Color.DarkGray;
            txtHayvanAdi.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHayvanAdi.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHayvanAdi.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHayvanAdi.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHayvanAdi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHayvanAdi.ForeColor = Color.Black;
            txtHayvanAdi.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHayvanAdi.Location = new Point(39, 220);
            txtHayvanAdi.Margin = new Padding(4, 3, 4, 3);
            txtHayvanAdi.Name = "txtHayvanAdi";
            txtHayvanAdi.PasswordChar = '\0';
            txtHayvanAdi.PlaceholderText = "Hayvan Adı";
            txtHayvanAdi.SelectedText = "";
            txtHayvanAdi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtHayvanAdi.Size = new Size(233, 42);
            txtHayvanAdi.TabIndex = 0;
            // 
            // txtTur
            // 
            txtTur.BorderRadius = 10;
            txtTur.CustomizableEdges = customizableEdges1;
            txtTur.DefaultText = "";
            txtTur.DisabledState.BorderColor = Color.DarkGray;
            txtTur.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTur.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTur.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTur.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTur.ForeColor = Color.Black;
            txtTur.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTur.Location = new Point(39, 268);
            txtTur.Margin = new Padding(4, 3, 4, 3);
            txtTur.Name = "txtTur";
            txtTur.PasswordChar = '\0';
            txtTur.PlaceholderText = "Tür";
            txtTur.SelectedText = "";
            txtTur.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTur.Size = new Size(233, 42);
            txtTur.TabIndex = 1;
            // 
            // txtCins
            // 
            txtCins.BorderRadius = 10;
            txtCins.CustomizableEdges = customizableEdges1;
            txtCins.DefaultText = "";
            txtCins.DisabledState.BorderColor = Color.DarkGray;
            txtCins.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCins.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCins.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCins.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCins.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCins.ForeColor = Color.Black;
            txtCins.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCins.Location = new Point(39, 316);
            txtCins.Margin = new Padding(4, 3, 4, 3);
            txtCins.Name = "txtCins";
            txtCins.PasswordChar = '\0';
            txtCins.PlaceholderText = "Cins";
            txtCins.SelectedText = "";
            txtCins.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCins.Size = new Size(233, 42);
            txtCins.TabIndex = 2;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Checked = true;
            dtpDogumTarihi.CustomizableEdges = customizableEdges3;
            dtpDogumTarihi.FillColor = Color.White;
            dtpDogumTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;
            dtpDogumTarihi.Location = new Point(39, 387);
            dtpDogumTarihi.Margin = new Padding(4, 3, 4, 3);
            dtpDogumTarihi.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDogumTarihi.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpDogumTarihi.Size = new Size(233, 42);
            dtpDogumTarihi.TabIndex = 3;
            dtpDogumTarihi.Value = new DateTime(2023, 6, 14, 10, 15, 0, 0);
            // 
            // btnKaydet
            // 
            btnKaydet.BorderRadius = 10;
            btnKaydet.CustomizableEdges = customizableEdges3;
            btnKaydet.FillColor = Color.Green;
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Image = (Image)resources.GetObject("btnKaydet.Image");
            btnKaydet.Location = new Point(39, 456);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnKaydet.Size = new Size(233, 52);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(65, 27);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2PictureBox1.Size = new Size(181, 164);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 5;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(112, 364);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(75, 17);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Doğum Tarihi";
            // 
            // MusteriHayvanDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 530);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(btnKaydet);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtCins);
            Controls.Add(txtTur);
            Controls.Add(txtHayvanAdi);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MusteriHayvanDuzenleForm";
            Text = "Musteri Hayvan Düzenle";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna2PictureBox guna2PictureBox1;
        private Guna2HtmlLabel guna2HtmlLabel1;
    }
}

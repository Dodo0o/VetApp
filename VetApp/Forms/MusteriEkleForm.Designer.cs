using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class MusteriEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2TextBox txtAd;
        private Guna2TextBox txtSoyad;
        private Guna2TextBox txtTelefon;
        private Guna2TextBox txtEposta;
        private Guna2TextBox txtTCKimlik;
        private Guna2TextBox txtSifre;
        private Guna2Button btnKaydet;
        private Guna2HtmlLabel lblAd;
        private Guna2HtmlLabel lblSoyad;
        private Guna2HtmlLabel lblTelefon;
        private Guna2HtmlLabel lblEposta;
        private Guna2HtmlLabel lblTCKimlik;
        private Guna2HtmlLabel lblSifre;
        private Guna2Panel topPanel;
        private Guna2ControlBox guna2ControlBoxClose;
        private Guna2ControlBox guna2ControlBoxMinimize;
        private Guna2ControlBox guna2ControlBoxMaximize;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkleForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtAd = new Guna2TextBox();
            txtSoyad = new Guna2TextBox();
            txtTelefon = new Guna2TextBox();
            txtEposta = new Guna2TextBox();
            txtTCKimlik = new Guna2TextBox();
            txtSifre = new Guna2TextBox();
            btnKaydet = new Guna2Button();
            lblAd = new Guna2HtmlLabel();
            lblSoyad = new Guna2HtmlLabel();
            lblTelefon = new Guna2HtmlLabel();
            lblEposta = new Guna2HtmlLabel();
            lblTCKimlik = new Guna2HtmlLabel();
            lblSifre = new Guna2HtmlLabel();
            topPanel = new Guna2Panel();
            guna2ControlBoxClose = new Guna2ControlBox();
            guna2ControlBoxMinimize = new Guna2ControlBox();
            guna2ControlBoxMaximize = new Guna2ControlBox();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            guna2PictureBox1 = new Guna2PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.BorderRadius = 10;
            txtAd.Cursor = Cursors.IBeam;
            txtAd.CustomizableEdges = customizableEdges1;
            txtAd.DefaultText = "";
            txtAd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAd.Location = new Point(40, 198);
            txtAd.Name = "txtAd";
            txtAd.PasswordChar = '\0';
            txtAd.PlaceholderText = "Ad";
            txtAd.SelectedText = "";
            txtAd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtAd.Size = new Size(256, 36);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderRadius = 10;
            txtSoyad.Cursor = Cursors.IBeam;
            txtSoyad.CustomizableEdges = customizableEdges3;
            txtSoyad.DefaultText = "";
            txtSoyad.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSoyad.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSoyad.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSoyad.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSoyad.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoyad.Location = new Point(40, 269);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.PasswordChar = '\0';
            txtSoyad.PlaceholderText = "Soyad";
            txtSoyad.SelectedText = "";
            txtSoyad.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSoyad.Size = new Size(256, 36);
            txtSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.BorderRadius = 10;
            txtTelefon.Cursor = Cursors.IBeam;
            txtTelefon.CustomizableEdges = customizableEdges5;
            txtTelefon.DefaultText = "";
            txtTelefon.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelefon.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelefon.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelefon.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelefon.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefon.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefon.Location = new Point(40, 340);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.PasswordChar = '\0';
            txtTelefon.PlaceholderText = "Telefon";
            txtTelefon.SelectedText = "";
            txtTelefon.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTelefon.Size = new Size(256, 36);
            txtTelefon.TabIndex = 2;
            // 
            // txtEposta
            // 
            txtEposta.BorderRadius = 10;
            txtEposta.Cursor = Cursors.IBeam;
            txtEposta.CustomizableEdges = customizableEdges7;
            txtEposta.DefaultText = "";
            txtEposta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEposta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEposta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEposta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEposta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEposta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEposta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEposta.Location = new Point(40, 411);
            txtEposta.Name = "txtEposta";
            txtEposta.PasswordChar = '\0';
            txtEposta.PlaceholderText = "E-posta";
            txtEposta.SelectedText = "";
            txtEposta.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEposta.Size = new Size(256, 36);
            txtEposta.TabIndex = 3;
            // 
            // txtTCKimlik
            // 
            txtTCKimlik.BorderRadius = 10;
            txtTCKimlik.Cursor = Cursors.IBeam;
            txtTCKimlik.CustomizableEdges = customizableEdges9;
            txtTCKimlik.DefaultText = "";
            txtTCKimlik.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTCKimlik.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTCKimlik.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTCKimlik.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTCKimlik.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTCKimlik.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTCKimlik.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTCKimlik.Location = new Point(40, 482);
            txtTCKimlik.Name = "txtTCKimlik";
            txtTCKimlik.PasswordChar = '\0';
            txtTCKimlik.PlaceholderText = "TC Kimlik No";
            txtTCKimlik.SelectedText = "";
            txtTCKimlik.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTCKimlik.Size = new Size(256, 36);
            txtTCKimlik.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.BorderRadius = 10;
            txtSifre.Cursor = Cursors.IBeam;
            txtSifre.CustomizableEdges = customizableEdges11;
            txtSifre.DefaultText = "";
            txtSifre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSifre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSifre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSifre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSifre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSifre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSifre.Location = new Point(40, 553);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.SelectedText = "";
            txtSifre.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtSifre.Size = new Size(256, 36);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnKaydet
            // 
            btnKaydet.BorderRadius = 10;
            btnKaydet.CustomizableEdges = customizableEdges13;
            btnKaydet.FillColor = Color.ForestGreen;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Image = (Image)resources.GetObject("btnKaydet.Image");
            btnKaydet.Location = new Point(40, 595);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnKaydet.Size = new Size(256, 45);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblAd
            // 
            lblAd.BackColor = Color.Transparent;
            lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAd.Location = new Point(41, 169);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 23);
            lblAd.TabIndex = 7;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.BackColor = Color.Transparent;
            lblSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoyad.Location = new Point(40, 240);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(54, 23);
            lblSoyad.TabIndex = 8;
            lblSoyad.Text = "Soyad:";
            // 
            // lblTelefon
            // 
            lblTelefon.BackColor = Color.Transparent;
            lblTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefon.Location = new Point(41, 311);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(65, 23);
            lblTelefon.TabIndex = 9;
            lblTelefon.Text = "Telefon:";
            // 
            // lblEposta
            // 
            lblEposta.BackColor = Color.Transparent;
            lblEposta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEposta.Location = new Point(41, 382);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(64, 23);
            lblEposta.TabIndex = 10;
            lblEposta.Text = "E-posta:";
            // 
            // lblTCKimlik
            // 
            lblTCKimlik.BackColor = Color.Transparent;
            lblTCKimlik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTCKimlik.Location = new Point(40, 453);
            lblTCKimlik.Name = "lblTCKimlik";
            lblTCKimlik.Size = new Size(106, 23);
            lblTCKimlik.TabIndex = 11;
            lblTCKimlik.Text = "TC Kimlik No:";
            // 
            // lblSifre
            // 
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.Location = new Point(40, 524);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 23);
            lblSifre.TabIndex = 12;
            lblSifre.Text = "Şifre:";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Gray;
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.Controls.Add(guna2ControlBoxClose);
            topPanel.Controls.Add(guna2ControlBoxMinimize);
            topPanel.Controls.Add(guna2ControlBoxMaximize);
            topPanel.CustomizableEdges = customizableEdges21;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges22;
            topPanel.Size = new Size(330, 50);
            topPanel.TabIndex = 13;
            topPanel.MouseDown += Form_MouseDown;
            topPanel.MouseMove += Form_MouseMove;
            topPanel.MouseUp += Form_MouseUp;
            // 
            // guna2ControlBoxClose
            // 
            guna2ControlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBoxClose.CustomizableEdges = customizableEdges15;
            guna2ControlBoxClose.FillColor = Color.Red;
            guna2ControlBoxClose.IconColor = Color.White;
            guna2ControlBoxClose.Location = new Point(285, 12);
            guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            guna2ControlBoxClose.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2ControlBoxClose.Size = new Size(35, 29);
            guna2ControlBoxClose.TabIndex = 2;
            // 
            // guna2ControlBoxMinimize
            // 
            guna2ControlBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBoxMinimize.CustomizableEdges = customizableEdges17;
            guna2ControlBoxMinimize.FillColor = Color.Gray;
            guna2ControlBoxMinimize.IconColor = Color.White;
            guna2ControlBoxMinimize.Location = new Point(204, 12);
            guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            guna2ControlBoxMinimize.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2ControlBoxMinimize.Size = new Size(35, 29);
            guna2ControlBoxMinimize.TabIndex = 0;
            // 
            // guna2ControlBoxMaximize
            // 
            guna2ControlBoxMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBoxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBoxMaximize.CustomizableEdges = customizableEdges19;
            guna2ControlBoxMaximize.FillColor = Color.Gray;
            guna2ControlBoxMaximize.IconColor = Color.White;
            guna2ControlBoxMaximize.Location = new Point(245, 12);
            guna2ControlBoxMaximize.Name = "guna2ControlBoxMaximize";
            guna2ControlBoxMaximize.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2ControlBoxMaximize.Size = new Size(35, 29);
            guna2ControlBoxMaximize.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(12, 14);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(112, 27);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Müşteri Ekle";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges23;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(97, 36);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2PictureBox1.Size = new Size(135, 143);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 14;
            guna2PictureBox1.TabStop = false;
            // 
            // MusteriEkleForm
            // 
            ClientSize = new Size(330, 667);
            Controls.Add(topPanel);
            Controls.Add(lblSifre);
            Controls.Add(lblTCKimlik);
            Controls.Add(lblEposta);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(btnKaydet);
            Controls.Add(txtSifre);
            Controls.Add(txtTCKimlik);
            Controls.Add(txtEposta);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusteriEkleForm";
            Text = "Müşteri Ekle";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna2HtmlLabel guna2HtmlLabel1;
        private Guna2PictureBox guna2PictureBox1;
    }
}

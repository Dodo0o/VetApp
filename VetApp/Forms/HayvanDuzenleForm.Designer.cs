namespace VetApp.Forms
{
    partial class HayvanDuzenleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHayvanlar;
        private Guna.UI2.WinForms.Guna2TextBox txtHayvanAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtTur;
        private Guna.UI2.WinForms.Guna2TextBox txtCins;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDogumTarihi;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSahipAdiSoyadi;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2Button btnResimSec;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxHayvan;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HayvanDuzenleForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbHayvanlar = new Guna.UI2.WinForms.Guna2ComboBox();
            txtHayvanAdi = new Guna.UI2.WinForms.Guna2TextBox();
            txtTur = new Guna.UI2.WinForms.Guna2TextBox();
            txtCins = new Guna.UI2.WinForms.Guna2TextBox();
            dtpDogumTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            lblSahipAdiSoyadi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            topPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            openFileDialog = new OpenFileDialog();
            btnResimSec = new Guna.UI2.WinForms.Guna2Button();
            pictureBoxHayvan = new Guna.UI2.WinForms.Guna2PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHayvan).BeginInit();
            SuspendLayout();
            // 
            // cmbHayvanlar
            // 
            cmbHayvanlar.BackColor = Color.Transparent;
            cmbHayvanlar.CustomizableEdges = customizableEdges1;
            cmbHayvanlar.DrawMode = DrawMode.OwnerDrawFixed;
            cmbHayvanlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHayvanlar.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbHayvanlar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbHayvanlar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbHayvanlar.ForeColor = Color.FromArgb(68, 88, 112);
            cmbHayvanlar.ItemHeight = 30;
            cmbHayvanlar.Location = new Point(31, 169);
            cmbHayvanlar.Name = "cmbHayvanlar";
            cmbHayvanlar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbHayvanlar.Size = new Size(200, 36);
            cmbHayvanlar.TabIndex = 0;
            cmbHayvanlar.SelectedIndexChanged += cmbHayvanlar_SelectedIndexChanged;
            // 
            // txtHayvanAdi
            // 
            txtHayvanAdi.BorderRadius = 10;
            txtHayvanAdi.Cursor = Cursors.IBeam;
            txtHayvanAdi.CustomizableEdges = customizableEdges3;
            txtHayvanAdi.DefaultText = "";
            txtHayvanAdi.DisabledState.BorderColor = Color.DarkGray;
            txtHayvanAdi.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHayvanAdi.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHayvanAdi.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHayvanAdi.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHayvanAdi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHayvanAdi.ForeColor = Color.Black;
            txtHayvanAdi.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHayvanAdi.Location = new Point(31, 228);
            txtHayvanAdi.Name = "txtHayvanAdi";
            txtHayvanAdi.PasswordChar = '\0';
            txtHayvanAdi.PlaceholderText = "Hayvan Adı";
            txtHayvanAdi.SelectedText = "";
            txtHayvanAdi.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtHayvanAdi.Size = new Size(200, 36);
            txtHayvanAdi.TabIndex = 1;
            // 
            // txtTur
            // 
            txtTur.BorderRadius = 10;
            txtTur.Cursor = Cursors.IBeam;
            txtTur.CustomizableEdges = customizableEdges5;
            txtTur.DefaultText = "";
            txtTur.DisabledState.BorderColor = Color.DarkGray;
            txtTur.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTur.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTur.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTur.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTur.ForeColor = Color.Black;
            txtTur.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTur.Location = new Point(31, 284);
            txtTur.Name = "txtTur";
            txtTur.PasswordChar = '\0';
            txtTur.PlaceholderText = "Tür";
            txtTur.SelectedText = "";
            txtTur.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTur.Size = new Size(200, 36);
            txtTur.TabIndex = 2;
            // 
            // txtCins
            // 
            txtCins.BorderRadius = 10;
            txtCins.Cursor = Cursors.IBeam;
            txtCins.CustomizableEdges = customizableEdges7;
            txtCins.DefaultText = "";
            txtCins.DisabledState.BorderColor = Color.DarkGray;
            txtCins.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCins.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCins.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCins.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCins.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCins.ForeColor = Color.Black;
            txtCins.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCins.Location = new Point(31, 350);
            txtCins.Name = "txtCins";
            txtCins.PasswordChar = '\0';
            txtCins.PlaceholderText = "Cins";
            txtCins.SelectedText = "";
            txtCins.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCins.Size = new Size(200, 36);
            txtCins.TabIndex = 3;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Checked = true;
            dtpDogumTarihi.CustomizableEdges = customizableEdges9;
            dtpDogumTarihi.FillColor = Color.White;
            dtpDogumTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;
            dtpDogumTarihi.Location = new Point(31, 416);
            dtpDogumTarihi.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDogumTarihi.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtpDogumTarihi.Size = new Size(200, 36);
            dtpDogumTarihi.TabIndex = 4;
            dtpDogumTarihi.Value = new DateTime(2023, 6, 14, 10, 15, 0, 0);
            // 
            // btnKaydet
            // 
            btnKaydet.BorderRadius = 10;
            btnKaydet.CustomizableEdges = customizableEdges11;
            btnKaydet.FillColor = Color.Green;
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Image = (Image)resources.GetObject("btnKaydet.Image");
            btnKaydet.Location = new Point(31, 474);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnKaydet.Size = new Size(200, 45);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblSahipAdiSoyadi
            // 
            lblSahipAdiSoyadi.BackColor = Color.Transparent;
            lblSahipAdiSoyadi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSahipAdiSoyadi.Location = new Point(80, 538);
            lblSahipAdiSoyadi.Name = "lblSahipAdiSoyadi";
            lblSahipAdiSoyadi.Size = new Size(93, 17);
            lblSahipAdiSoyadi.TabIndex = 6;
            lblSahipAdiSoyadi.Text = "Sahip Adı Soyadı";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Gray;
            topPanel.Controls.Add(guna2ControlBoxClose);
            topPanel.Controls.Add(guna2ControlBoxMinimize);
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.CustomizableEdges = customizableEdges17;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges18;
            topPanel.Size = new Size(473, 50);
            topPanel.TabIndex = 7;
            topPanel.MouseDown += Form_MouseDown;
            topPanel.MouseMove += Form_MouseMove;
            topPanel.MouseUp += Form_MouseUp;
            // 
            // guna2ControlBoxClose
            // 
            guna2ControlBoxClose.Anchor = AnchorStyles.Right;
            guna2ControlBoxClose.CustomizableEdges = customizableEdges13;
            guna2ControlBoxClose.FillColor = Color.Red;
            guna2ControlBoxClose.IconColor = Color.White;
            guna2ControlBoxClose.Location = new Point(428, 12);
            guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            guna2ControlBoxClose.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ControlBoxClose.Size = new Size(35, 29);
            guna2ControlBoxClose.TabIndex = 2;
            // 
            // guna2ControlBoxMinimize
            // 
            guna2ControlBoxMinimize.Anchor = AnchorStyles.Right;
            guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBoxMinimize.CustomizableEdges = customizableEdges15;
            guna2ControlBoxMinimize.FillColor = Color.Gray;
            guna2ControlBoxMinimize.IconColor = Color.White;
            guna2ControlBoxMinimize.Location = new Point(387, 12);
            guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            guna2ControlBoxMinimize.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2ControlBoxMinimize.Size = new Size(35, 29);
            guna2ControlBoxMinimize.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(12, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(128, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Hayvan Düzenle";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(80, 68);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges19;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(89, 95);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 8;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // btnResimSec
            // 
            btnResimSec.BorderRadius = 10;
            btnResimSec.CustomizableEdges = customizableEdges17;
            btnResimSec.DisabledState.BorderColor = Color.DarkGray;
            btnResimSec.DisabledState.CustomBorderColor = Color.DarkGray;
            btnResimSec.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnResimSec.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnResimSec.FillColor = Color.Gray;
            btnResimSec.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnResimSec.ForeColor = Color.White;
            btnResimSec.Location = new Point(31, 538);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnResimSec.Size = new Size(200, 36);
            btnResimSec.TabIndex = 9;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.Click += btnResimSec_Click;
            // 
            // pictureBoxHayvan
            // 
            pictureBoxHayvan.CustomizableEdges = customizableEdges19;
            pictureBoxHayvan.ImageRotate = 0F;
            pictureBoxHayvan.Location = new Point(240, 169);
            pictureBoxHayvan.Name = "pictureBoxHayvan";
            pictureBoxHayvan.ShadowDecoration.CustomizableEdges = customizableEdges20;
            pictureBoxHayvan.Size = new Size(200, 200);
            pictureBoxHayvan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHayvan.TabIndex = 10;
            pictureBoxHayvan.TabStop = false;
            // 
            // HayvanDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 621);
            Controls.Add(pictureBoxHayvan);
            Controls.Add(btnResimSec);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(topPanel);
            Controls.Add(lblSahipAdiSoyadi);
            Controls.Add(btnKaydet);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtCins);
            Controls.Add(txtTur);
            Controls.Add(txtHayvanAdi);
            Controls.Add(cmbHayvanlar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HayvanDuzenleForm";
            Text = "Hayvan Düzenle";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHayvan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

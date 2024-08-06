using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class VeterinerForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dataGridViewHayvanlar;
        private Guna2DataGridView dataGridViewRandevular;
        private Guna2Button btnRandevuEkle;
        private Guna2Button btnHayvanEkle;
        private Guna2Button btnMusteriEkle;
        private Guna2Button btnCikisYap;
        private Guna2CirclePictureBox pictureBox1;
        private Guna2Panel leftPanel;
        private Guna2Panel topPanel;
        private Guna2ControlBox guna2ControlBoxClose;
        private Guna2ControlBox guna2ControlBoxMinimize;
        private Guna2ControlBox guna2ControlBoxMaximize;
        private Guna2HtmlLabel lblHosgeldin;
        private Guna2Button btnHayvanDuzenle;
        private Guna2Button btnHayvanSil;
        private Guna2Button btnMusteriDuzenle;
        private Guna2Button btnMusteriSil;
        private Guna2Button btnRandevuDuzenle;
        private Guna2Button btnRandevuSil;
        private Guna2Button btnTibbiKayitlar;
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeterinerForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridViewHayvanlar = new Guna2DataGridView();
            dataGridViewRandevular = new Guna2DataGridView();
            btnRandevuEkle = new Guna2Button();
            btnHayvanEkle = new Guna2Button();
            btnMusteriEkle = new Guna2Button();
            btnCikisYap = new Guna2Button();
            pictureBox1 = new Guna2CirclePictureBox();
            leftPanel = new Guna2Panel();
            label1 = new Label();
            guna2CirclePictureBox3 = new Guna2CirclePictureBox();
            lblHosgeldin = new Guna2HtmlLabel();
            btnMusteriSil = new Guna2Button();
            btnHayvanSil = new Guna2Button();
            btnHayvanDuzenle = new Guna2Button();
            topPanel = new Guna2Panel();
            guna2ControlBoxClose = new Guna2ControlBox();
            guna2ControlBoxMinimize = new Guna2ControlBox();
            guna2ControlBoxMaximize = new Guna2ControlBox();
            btnRandevuDuzenle = new Guna2Button();
            btnMusteriDuzenle = new Guna2Button();
            btnRandevuSil = new Guna2Button();
            btnTibbiKayitlar = new Guna2Button();
            btnAsiBilgileri = new Guna2Button();
            guna2CirclePictureBox1 = new Guna2CirclePictureBox();
            guna2CirclePictureBox2 = new Guna2CirclePictureBox();
            guna2PictureBox1 = new Guna2PictureBox();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHayvanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox3).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
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
            dataGridViewHayvanlar.ColumnHeadersHeight = 4;
            dataGridViewHayvanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewHayvanlar.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHayvanlar.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewHayvanlar.Location = new Point(216, 116);
            dataGridViewHayvanlar.Name = "dataGridViewHayvanlar";
            dataGridViewHayvanlar.RowHeadersVisible = false;
            dataGridViewHayvanlar.Size = new Size(660, 280);
            dataGridViewHayvanlar.TabIndex = 6;
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
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewHayvanlar.ThemeStyle.HeaderStyle.Height = 4;
            dataGridViewHayvanlar.ThemeStyle.ReadOnly = false;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.Height = 22;
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewHayvanlar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dataGridViewRandevular
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewRandevular.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewRandevular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRandevular.ColumnHeadersHeight = 4;
            dataGridViewRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewRandevular.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewRandevular.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewRandevular.Location = new Point(216, 458);
            dataGridViewRandevular.Name = "dataGridViewRandevular";
            dataGridViewRandevular.RowHeadersVisible = false;
            dataGridViewRandevular.Size = new Size(660, 335);
            dataGridViewRandevular.TabIndex = 7;
            dataGridViewRandevular.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewRandevular.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewRandevular.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewRandevular.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewRandevular.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewRandevular.ThemeStyle.BackColor = Color.White;
            dataGridViewRandevular.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewRandevular.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewRandevular.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRandevular.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewRandevular.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewRandevular.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewRandevular.ThemeStyle.HeaderStyle.Height = 4;
            dataGridViewRandevular.ThemeStyle.ReadOnly = false;
            dataGridViewRandevular.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewRandevular.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewRandevular.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewRandevular.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewRandevular.ThemeStyle.RowsStyle.Height = 22;
            dataGridViewRandevular.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewRandevular.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnRandevuEkle
            // 
            btnRandevuEkle.BorderRadius = 10;
            btnRandevuEkle.CustomizableEdges = customizableEdges1;
            btnRandevuEkle.DisabledState.BorderColor = Color.DarkGray;
            btnRandevuEkle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRandevuEkle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRandevuEkle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRandevuEkle.FillColor = Color.ForestGreen;
            btnRandevuEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRandevuEkle.ForeColor = Color.White;
            btnRandevuEkle.ImageAlign = HorizontalAlignment.Left;
            btnRandevuEkle.ImageSize = new Size(25, 25);
            btnRandevuEkle.Location = new Point(1025, 495);
            btnRandevuEkle.Name = "btnRandevuEkle";
            btnRandevuEkle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRandevuEkle.Size = new Size(126, 40);
            btnRandevuEkle.TabIndex = 3;
            btnRandevuEkle.Text = "Randevu Ekle";
            btnRandevuEkle.Click += btnRandevuEkle_Click;
            // 
            // btnHayvanEkle
            // 
            btnHayvanEkle.BorderRadius = 10;
            btnHayvanEkle.CustomizableEdges = customizableEdges3;
            btnHayvanEkle.DisabledState.BorderColor = Color.DarkGray;
            btnHayvanEkle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHayvanEkle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHayvanEkle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHayvanEkle.FillColor = Color.Green;
            btnHayvanEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHayvanEkle.ForeColor = Color.White;
            btnHayvanEkle.ImageAlign = HorizontalAlignment.Left;
            btnHayvanEkle.ImageSize = new Size(25, 25);
            btnHayvanEkle.Location = new Point(1025, 151);
            btnHayvanEkle.Name = "btnHayvanEkle";
            btnHayvanEkle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHayvanEkle.Size = new Size(138, 45);
            btnHayvanEkle.TabIndex = 1;
            btnHayvanEkle.Text = "Hayvan Ekle";
            btnHayvanEkle.Click += btnHayvanEkle_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.BorderRadius = 10;
            btnMusteriEkle.CustomizableEdges = customizableEdges5;
            btnMusteriEkle.DisabledState.BorderColor = Color.DarkGray;
            btnMusteriEkle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMusteriEkle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMusteriEkle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMusteriEkle.FillColor = Color.Green;
            btnMusteriEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriEkle.ForeColor = Color.White;
            btnMusteriEkle.ImageAlign = HorizontalAlignment.Left;
            btnMusteriEkle.ImageSize = new Size(25, 25);
            btnMusteriEkle.Location = new Point(1013, 706);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMusteriEkle.Size = new Size(138, 45);
            btnMusteriEkle.TabIndex = 2;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BorderRadius = 10;
            btnCikisYap.CustomizableEdges = customizableEdges7;
            btnCikisYap.DisabledState.BorderColor = Color.DarkGray;
            btnCikisYap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCikisYap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCikisYap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCikisYap.FillColor = Color.OrangeRed;
            btnCikisYap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikisYap.ForeColor = Color.White;
            btnCikisYap.ImageAlign = HorizontalAlignment.Left;
            btnCikisYap.ImageSize = new Size(25, 25);
            btnCikisYap.Location = new Point(12, 621);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCikisYap.Size = new Size(175, 45);
            btnCikisYap.TabIndex = 4;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageRotate = 0F;
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pictureBox1.Size = new Size(175, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(label1);
            leftPanel.Controls.Add(guna2CirclePictureBox3);
            leftPanel.Controls.Add(lblHosgeldin);
            leftPanel.Controls.Add(btnCikisYap);
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.CustomizableEdges = customizableEdges11;
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 50);
            leftPanel.Name = "leftPanel";
            leftPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            leftPanel.Size = new Size(200, 793);
            leftPanel.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(11, 485);
            label1.Name = "label1";
            label1.Size = new Size(186, 57);
            label1.TabIndex = 8;
            label1.Text = "DodoVet Veteriner Hekimi \r\nMüşteri ve Hayvan \r\nTakip Sistemi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox3
            // 
            guna2CirclePictureBox3.Image = Properties.Resources.logo;
            guna2CirclePictureBox3.ImageRotate = 0F;
            guna2CirclePictureBox3.Location = new Point(24, 319);
            guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox3.Size = new Size(149, 151);
            guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox3.TabIndex = 7;
            guna2CirclePictureBox3.TabStop = false;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.BackColor = Color.Transparent;
            lblHosgeldin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHosgeldin.Location = new Point(60, 176);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(85, 23);
            lblHosgeldin.TabIndex = 6;
            lblHosgeldin.Text = "Hoşgeldin, ";
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.BorderRadius = 10;
            btnMusteriSil.CustomizableEdges = customizableEdges13;
            btnMusteriSil.DisabledState.BorderColor = Color.DarkGray;
            btnMusteriSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMusteriSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMusteriSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMusteriSil.FillColor = Color.Crimson;
            btnMusteriSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriSil.ForeColor = Color.White;
            btnMusteriSil.Location = new Point(1325, 706);
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMusteriSil.Size = new Size(150, 45);
            btnMusteriSil.TabIndex = 5;
            btnMusteriSil.Text = "Müşteri Sil";
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // btnHayvanSil
            // 
            btnHayvanSil.BorderRadius = 10;
            btnHayvanSil.CustomizableEdges = customizableEdges15;
            btnHayvanSil.DisabledState.BorderColor = Color.DarkGray;
            btnHayvanSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHayvanSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHayvanSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHayvanSil.FillColor = Color.Crimson;
            btnHayvanSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHayvanSil.ForeColor = Color.White;
            btnHayvanSil.Location = new Point(1325, 151);
            btnHayvanSil.Name = "btnHayvanSil";
            btnHayvanSil.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnHayvanSil.Size = new Size(150, 45);
            btnHayvanSil.TabIndex = 5;
            btnHayvanSil.Text = "Hayvan Sil";
            btnHayvanSil.Click += btnHayvanSil_Click;
            // 
            // btnHayvanDuzenle
            // 
            btnHayvanDuzenle.BorderRadius = 10;
            btnHayvanDuzenle.CustomizableEdges = customizableEdges17;
            btnHayvanDuzenle.DisabledState.BorderColor = Color.DarkGray;
            btnHayvanDuzenle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHayvanDuzenle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHayvanDuzenle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHayvanDuzenle.FillColor = Color.Goldenrod;
            btnHayvanDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHayvanDuzenle.ForeColor = Color.White;
            btnHayvanDuzenle.ImageAlign = HorizontalAlignment.Left;
            btnHayvanDuzenle.ImageSize = new Size(25, 25);
            btnHayvanDuzenle.Location = new Point(1169, 151);
            btnHayvanDuzenle.Name = "btnHayvanDuzenle";
            btnHayvanDuzenle.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnHayvanDuzenle.Size = new Size(150, 45);
            btnHayvanDuzenle.TabIndex = 5;
            btnHayvanDuzenle.Text = "Hayvan Düzenle";
            btnHayvanDuzenle.Click += btnHayvanDuzenle_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Gray;
            topPanel.Controls.Add(guna2ControlBoxClose);
            topPanel.Controls.Add(guna2ControlBoxMinimize);
            topPanel.Controls.Add(guna2ControlBoxMaximize);
            topPanel.CustomizableEdges = customizableEdges25;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges26;
            topPanel.Size = new Size(1494, 50);
            topPanel.TabIndex = 9;
            topPanel.MouseDown += Form_MouseDown;
            topPanel.MouseMove += Form_MouseMove;
            topPanel.MouseUp += Form_MouseUp;
            // 
            // guna2ControlBoxClose
            // 
            guna2ControlBoxClose.Anchor = AnchorStyles.Right;
            guna2ControlBoxClose.CustomizableEdges = customizableEdges19;
            guna2ControlBoxClose.FillColor = Color.Red;
            guna2ControlBoxClose.IconColor = Color.White;
            guna2ControlBoxClose.Location = new Point(1449, 10);
            guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            guna2ControlBoxClose.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2ControlBoxClose.Size = new Size(35, 29);
            guna2ControlBoxClose.TabIndex = 2;
            // 
            // guna2ControlBoxMinimize
            // 
            guna2ControlBoxMinimize.Anchor = AnchorStyles.Right;
            guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBoxMinimize.CustomizableEdges = customizableEdges21;
            guna2ControlBoxMinimize.FillColor = Color.Gray;
            guna2ControlBoxMinimize.IconColor = Color.White;
            guna2ControlBoxMinimize.Location = new Point(1368, 10);
            guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            guna2ControlBoxMinimize.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2ControlBoxMinimize.Size = new Size(35, 29);
            guna2ControlBoxMinimize.TabIndex = 0;
            // 
            // guna2ControlBoxMaximize
            // 
            guna2ControlBoxMaximize.Anchor = AnchorStyles.Right;
            guna2ControlBoxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBoxMaximize.CustomizableEdges = customizableEdges23;
            guna2ControlBoxMaximize.FillColor = Color.Gray;
            guna2ControlBoxMaximize.IconColor = Color.White;
            guna2ControlBoxMaximize.Location = new Point(1409, 10);
            guna2ControlBoxMaximize.Name = "guna2ControlBoxMaximize";
            guna2ControlBoxMaximize.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2ControlBoxMaximize.Size = new Size(35, 29);
            guna2ControlBoxMaximize.TabIndex = 1;
            // 
            // btnRandevuDuzenle
            // 
            btnRandevuDuzenle.BorderRadius = 10;
            btnRandevuDuzenle.CustomizableEdges = customizableEdges1;
            btnRandevuDuzenle.DisabledState.BorderColor = Color.DarkGray;
            btnRandevuDuzenle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRandevuDuzenle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRandevuDuzenle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRandevuDuzenle.FillColor = Color.Orange;
            btnRandevuDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRandevuDuzenle.ForeColor = Color.White;
            btnRandevuDuzenle.Location = new Point(1157, 495);
            btnRandevuDuzenle.Name = "btnRandevuDuzenle";
            btnRandevuDuzenle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRandevuDuzenle.Size = new Size(159, 40);
            btnRandevuDuzenle.TabIndex = 5;
            btnRandevuDuzenle.Text = "Randevu Düzenle";
            btnRandevuDuzenle.Click += btnRandevuDuzenle_Click;
            // 
            // btnMusteriDuzenle
            // 
            btnMusteriDuzenle.BorderRadius = 10;
            btnMusteriDuzenle.CustomizableEdges = customizableEdges17;
            btnMusteriDuzenle.DisabledState.BorderColor = Color.DarkGray;
            btnMusteriDuzenle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMusteriDuzenle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMusteriDuzenle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMusteriDuzenle.FillColor = Color.Orange;
            btnMusteriDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriDuzenle.ForeColor = Color.White;
            btnMusteriDuzenle.Location = new Point(1166, 706);
            btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            btnMusteriDuzenle.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnMusteriDuzenle.Size = new Size(150, 45);
            btnMusteriDuzenle.TabIndex = 5;
            btnMusteriDuzenle.Text = "Müşteri Düzenle";
            btnMusteriDuzenle.Click += btnMusteriDuzenle_Click;
            // 
            // btnRandevuSil
            // 
            btnRandevuSil.BorderRadius = 10;
            btnRandevuSil.CustomizableEdges = customizableEdges27;
            btnRandevuSil.DisabledState.BorderColor = Color.DarkGray;
            btnRandevuSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRandevuSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRandevuSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRandevuSil.FillColor = Color.Crimson;
            btnRandevuSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRandevuSil.ForeColor = Color.White;
            btnRandevuSil.Location = new Point(1322, 495);
            btnRandevuSil.Name = "btnRandevuSil";
            btnRandevuSil.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnRandevuSil.Size = new Size(146, 40);
            btnRandevuSil.TabIndex = 10;
            btnRandevuSil.Text = "Randevu Sil";
            btnRandevuSil.Click += btnRandevuSil_Click;
            // 
            // btnTibbiKayitlar
            // 
            btnTibbiKayitlar.BorderRadius = 10;
            btnTibbiKayitlar.CustomizableEdges = customizableEdges1;
            btnTibbiKayitlar.DisabledState.BorderColor = Color.DarkGray;
            btnTibbiKayitlar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTibbiKayitlar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTibbiKayitlar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTibbiKayitlar.FillColor = Color.DarkOrange;
            btnTibbiKayitlar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTibbiKayitlar.ForeColor = Color.White;
            btnTibbiKayitlar.Location = new Point(1259, 226);
            btnTibbiKayitlar.Name = "btnTibbiKayitlar";
            btnTibbiKayitlar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnTibbiKayitlar.Size = new Size(175, 45);
            btnTibbiKayitlar.TabIndex = 11;
            btnTibbiKayitlar.Text = "Tıbbi Kayıtlar";
            btnTibbiKayitlar.Click += btnTibbiKayitlar_Click;
            // 
            // btnAsiBilgileri
            // 
            btnAsiBilgileri.BorderRadius = 10;
            btnAsiBilgileri.CustomizableEdges = customizableEdges3;
            btnAsiBilgileri.DisabledState.BorderColor = Color.DarkGray;
            btnAsiBilgileri.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAsiBilgileri.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAsiBilgileri.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAsiBilgileri.FillColor = Color.MediumPurple;
            btnAsiBilgileri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsiBilgileri.ForeColor = Color.White;
            btnAsiBilgileri.Location = new Point(1048, 226);
            btnAsiBilgileri.Name = "btnAsiBilgileri";
            btnAsiBilgileri.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAsiBilgileri.Size = new Size(175, 45);
            btnAsiBilgileri.TabIndex = 12;
            btnAsiBilgileri.Text = "Aşı Bilgileri";
            btnAsiBilgileri.Click += btnAsiBilgileri_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(903, 151);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges29;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(105, 98);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 13;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            guna2CirclePictureBox2.Image = (Image)resources.GetObject("guna2CirclePictureBox2.Image");
            guna2CirclePictureBox2.ImageRotate = 0F;
            guna2CirclePictureBox2.Location = new Point(902, 685);
            guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges30;
            guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox2.Size = new Size(84, 85);
            guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox2.TabIndex = 14;
            guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges31;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(903, 481);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges32;
            guna2PictureBox1.Size = new Size(103, 77);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 15;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(1025, 70);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(218, 39);
            guna2HtmlLabel1.TabIndex = 16;
            guna2HtmlLabel1.Text = "Hayvan İşlemleri";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(1025, 430);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(233, 39);
            guna2HtmlLabel2.TabIndex = 17;
            guna2HtmlLabel2.Text = "Randevu İşlemleri";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(1025, 643);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(220, 39);
            guna2HtmlLabel3.TabIndex = 18;
            guna2HtmlLabel3.Text = "Müşteri İşlemleri";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel4.Location = new Point(216, 70);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(134, 39);
            guna2HtmlLabel4.TabIndex = 19;
            guna2HtmlLabel4.Text = "Hayvanlar";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(216, 413);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(149, 39);
            guna2HtmlLabel5.TabIndex = 20;
            guna2HtmlLabel5.Text = "Randevular";
            // 
            // VeterinerForm
            // 
            ClientSize = new Size(1494, 843);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(guna2CirclePictureBox2);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(btnTibbiKayitlar);
            Controls.Add(btnAsiBilgileri);
            Controls.Add(btnRandevuDuzenle);
            Controls.Add(btnMusteriDuzenle);
            Controls.Add(btnMusteriSil);
            Controls.Add(dataGridViewRandevular);
            Controls.Add(btnRandevuEkle);
            Controls.Add(btnHayvanSil);
            Controls.Add(btnMusteriEkle);
            Controls.Add(dataGridViewHayvanlar);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            Controls.Add(btnHayvanEkle);
            Controls.Add(btnHayvanDuzenle);
            Controls.Add(btnRandevuSil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VeterinerForm";
            Text = "Veteriner Paneli";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHayvanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox3).EndInit();
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna2PictureBox guna2PictureBox1;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private Guna2HtmlLabel guna2HtmlLabel2;
        private Guna2HtmlLabel guna2HtmlLabel3;
        private Guna2HtmlLabel guna2HtmlLabel4;
        private Guna2HtmlLabel guna2HtmlLabel5;
        private Guna2CirclePictureBox guna2CirclePictureBox3;
        private Label label1;
    }
}

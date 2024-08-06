namespace VetApp.Forms
{
    partial class HayvanSilForm
    {
        private Guna.UI2.WinForms.Guna2ComboBox cmbHayvanlar;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSahipAdSoyad;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HayvanSilForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbHayvanlar = new Guna.UI2.WinForms.Guna2ComboBox();
            btnSil = new Guna.UI2.WinForms.Guna2Button();
            topPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSahipAdSoyad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
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
            cmbHayvanlar.Location = new Point(32, 221);
            cmbHayvanlar.Name = "cmbHayvanlar";
            cmbHayvanlar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbHayvanlar.Size = new Size(200, 36);
            cmbHayvanlar.TabIndex = 0;
            cmbHayvanlar.SelectedIndexChanged += cmbHayvanlar_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.BorderRadius = 10;
            btnSil.CustomizableEdges = customizableEdges3;
            btnSil.FillColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(32, 330);
            btnSil.Name = "btnSil";
            btnSil.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSil.Size = new Size(200, 45);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Gray;
            topPanel.Controls.Add(guna2ControlBoxClose);
            topPanel.Controls.Add(guna2ControlBoxMinimize);
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.CustomizableEdges = customizableEdges9;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            topPanel.Size = new Size(262, 50);
            topPanel.TabIndex = 2;
            topPanel.MouseDown += Form_MouseDown;
            topPanel.MouseMove += Form_MouseMove;
            topPanel.MouseUp += Form_MouseUp;
            // 
            // guna2ControlBoxClose
            // 
            guna2ControlBoxClose.Anchor = AnchorStyles.Right;
            guna2ControlBoxClose.CustomizableEdges = customizableEdges5;
            guna2ControlBoxClose.FillColor = Color.Red;
            guna2ControlBoxClose.IconColor = Color.White;
            guna2ControlBoxClose.Location = new Point(217, 12);
            guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            guna2ControlBoxClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBoxClose.Size = new Size(35, 29);
            guna2ControlBoxClose.TabIndex = 2;
            // 
            // guna2ControlBoxMinimize
            // 
            guna2ControlBoxMinimize.Anchor = AnchorStyles.Right;
            guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBoxMinimize.CustomizableEdges = customizableEdges7;
            guna2ControlBoxMinimize.FillColor = Color.Gray;
            guna2ControlBoxMinimize.IconColor = Color.White;
            guna2ControlBoxMinimize.Location = new Point(176, 12);
            guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            guna2ControlBoxMinimize.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            guna2HtmlLabel1.Size = new Size(84, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Hayvan Sil";
            // 
            // lblSahipAdSoyad
            // 
            lblSahipAdSoyad.BackColor = Color.Transparent;
            lblSahipAdSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSahipAdSoyad.Location = new Point(78, 274);
            lblSahipAdSoyad.Name = "lblSahipAdSoyad";
            lblSahipAdSoyad.Size = new Size(93, 17);
            lblSahipAdSoyad.TabIndex = 3;
            lblSahipAdSoyad.Text = "Sahip Adı Soyadı";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges11;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(65, 85);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2PictureBox1.Size = new Size(126, 105);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 4;
            guna2PictureBox1.TabStop = false;
            // 
            // HayvanSilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 447);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lblSahipAdSoyad);
            Controls.Add(topPanel);
            Controls.Add(btnSil);
            Controls.Add(cmbHayvanlar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HayvanSilForm";
            Text = "Hayvan Sil";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

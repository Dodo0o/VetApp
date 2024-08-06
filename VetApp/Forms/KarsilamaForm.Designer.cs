using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class KarsilamaForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Button btnMusteri;
        private Guna2Button btnVeteriner;
        private Guna2CirclePictureBox pictureBox1;
        private Guna2ControlBox guna2ControlBoxClose;
        private Guna2ControlBox guna2ControlBoxMinimize;
        private Guna2ControlBox guna2ControlBoxMaximize;
        private Guna2Panel topPanel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarsilamaForm));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnMusteri = new Guna2Button();
            btnVeteriner = new Guna2Button();
            pictureBox1 = new Guna2CirclePictureBox();
            guna2ControlBoxClose = new Guna2ControlBox();
            guna2ControlBoxMinimize = new Guna2ControlBox();
            guna2ControlBoxMaximize = new Guna2ControlBox();
            topPanel = new Guna2Panel();
            guna2TextBox1 = new Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMusteri
            // 
            btnMusteri.BorderRadius = 10;
            btnMusteri.CustomizableEdges = customizableEdges1;
            btnMusteri.DisabledState.BorderColor = Color.DarkGray;
            btnMusteri.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMusteri.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMusteri.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMusteri.FillColor = Color.SteelBlue;
            btnMusteri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusteri.ForeColor = Color.White;
            btnMusteri.Image = (Image)resources.GetObject("btnMusteri.Image");
            btnMusteri.ImageAlign = HorizontalAlignment.Left;
            btnMusteri.ImageSize = new Size(40, 40);
            btnMusteri.Location = new Point(73, 485);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMusteri.Size = new Size(229, 58);
            btnMusteri.TabIndex = 0;
            btnMusteri.Text = "Müşteri Girişi";
            btnMusteri.Click += btnMusteri_Click;
            // 
            // btnVeteriner
            // 
            btnVeteriner.BorderRadius = 10;
            btnVeteriner.CustomizableEdges = customizableEdges3;
            btnVeteriner.DisabledState.BorderColor = Color.DarkGray;
            btnVeteriner.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVeteriner.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVeteriner.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVeteriner.FillColor = Color.ForestGreen;
            btnVeteriner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVeteriner.ForeColor = Color.White;
            btnVeteriner.Image = (Image)resources.GetObject("btnVeteriner.Image");
            btnVeteriner.ImageAlign = HorizontalAlignment.Left;
            btnVeteriner.ImageSize = new Size(40, 40);
            btnVeteriner.Location = new Point(390, 485);
            btnVeteriner.Name = "btnVeteriner";
            btnVeteriner.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnVeteriner.Size = new Size(241, 58);
            btnVeteriner.TabIndex = 1;
            btnVeteriner.Text = "Veteriner Hekimi Girişi";
            btnVeteriner.TextAlign = HorizontalAlignment.Right;
            btnVeteriner.Click += btnVeteriner_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.ImageRotate = 0F;
            pictureBox1.Location = new Point(185, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pictureBox1.Size = new Size(330, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // guna2ControlBoxClose
            // 
            guna2ControlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBoxClose.CustomizableEdges = customizableEdges6;
            guna2ControlBoxClose.FillColor = Color.Red;
            guna2ControlBoxClose.IconColor = Color.White;
            guna2ControlBoxClose.Location = new Point(636, 12);
            guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            guna2ControlBoxClose.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ControlBoxClose.Size = new Size(35, 29);
            guna2ControlBoxClose.TabIndex = 4;
            // 
            // guna2ControlBoxMinimize
            // 
            guna2ControlBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBoxMinimize.BackColor = Color.Gray;
            guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBoxMinimize.CustomizableEdges = customizableEdges8;
            guna2ControlBoxMinimize.FillColor = Color.Gray;
            guna2ControlBoxMinimize.IconColor = Color.White;
            guna2ControlBoxMinimize.Location = new Point(555, 12);
            guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            guna2ControlBoxMinimize.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ControlBoxMinimize.Size = new Size(35, 29);
            guna2ControlBoxMinimize.TabIndex = 5;
            // 
            // guna2ControlBoxMaximize
            // 
            guna2ControlBoxMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBoxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBoxMaximize.CustomizableEdges = customizableEdges10;
            guna2ControlBoxMaximize.FillColor = Color.Gray;
            guna2ControlBoxMaximize.IconColor = Color.White;
            guna2ControlBoxMaximize.Location = new Point(596, 12);
            guna2ControlBoxMaximize.Name = "guna2ControlBoxMaximize";
            guna2ControlBoxMaximize.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2ControlBoxMaximize.Size = new Size(35, 29);
            guna2ControlBoxMaximize.TabIndex = 6;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Gray;
            topPanel.BorderColor = Color.Transparent;
            topPanel.CustomBorderColor = Color.Transparent;
            topPanel.CustomizableEdges = customizableEdges12;
            topPanel.Dock = DockStyle.Top;
            topPanel.FillColor = Color.Transparent;
            topPanel.ForeColor = Color.Transparent;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges13;
            topPanel.Size = new Size(683, 50);
            topPanel.TabIndex = 7;
            topPanel.MouseDown += Form_MouseDown;
            topPanel.MouseMove += Form_MouseMove;
            topPanel.MouseUp += Form_MouseUp;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderColor = SystemColors.Control;
            guna2TextBox1.BorderThickness = 0;
            guna2TextBox1.CustomizableEdges = customizableEdges14;
            guna2TextBox1.DefaultText = "DodoVet Veteriner Hekimi Müşteri ve Hayvan Takip Sistemi";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = SystemColors.Control;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(58, 402);
            guna2TextBox1.Margin = new Padding(7, 9, 7, 9);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = SystemColors.Control;
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges15;
            guna2TextBox1.Size = new Size(604, 71);
            guna2TextBox1.TabIndex = 8;
            // 
            // KarsilamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 583);
            Controls.Add(pictureBox1);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2ControlBoxMaximize);
            Controls.Add(guna2ControlBoxMinimize);
            Controls.Add(guna2ControlBoxClose);
            Controls.Add(topPanel);
            Controls.Add(btnVeteriner);
            Controls.Add(btnMusteri);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KarsilamaForm";
            Text = "Karşılama Formu";
            MouseDown += Form_MouseDown;
            MouseMove += Form_MouseMove;
            MouseUp += Form_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Guna2TextBox guna2TextBox1;
    }
}

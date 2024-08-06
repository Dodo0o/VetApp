namespace VetApp.Forms
{
    partial class MusteriSilForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMusteriler;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMaximize;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMusteriler;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSilForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbMusteriler = new Guna.UI2.WinForms.Guna2ComboBox();
            btnSil = new Guna.UI2.WinForms.Guna2Button();
            topPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBoxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            lblMusteriler = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteriler
            // 
            cmbMusteriler.BackColor = Color.Transparent;
            cmbMusteriler.CustomizableEdges = customizableEdges15;
            cmbMusteriler.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMusteriler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteriler.FocusedColor = Color.Empty;
            cmbMusteriler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMusteriler.ForeColor = Color.FromArgb(68, 88, 112);
            cmbMusteriler.FormattingEnabled = true;
            cmbMusteriler.ItemHeight = 30;
            cmbMusteriler.Location = new Point(50, 266);
            cmbMusteriler.Name = "cmbMusteriler";
            cmbMusteriler.ShadowDecoration.CustomizableEdges = customizableEdges16;
            cmbMusteriler.Size = new Size(250, 36);
            cmbMusteriler.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.BorderRadius = 10;
            btnSil.CustomizableEdges = customizableEdges17;
            btnSil.DisabledState.BorderColor = Color.DarkGray;
            btnSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSil.FillColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(50, 324);
            btnSil.Name = "btnSil";
            btnSil.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnSil.Size = new Size(250, 45);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.Controls.Add(guna2ControlBoxClose);
            topPanel.Controls.Add(guna2ControlBoxMinimize);
            topPanel.Controls.Add(guna2ControlBoxMaximize);
            topPanel.CustomizableEdges = customizableEdges25;
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges26;
            topPanel.Size = new Size(350, 50);
            topPanel.TabIndex = 2;
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
            guna2ControlBoxClose.Location = new Point(300, 10);
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
            guna2ControlBoxMinimize.Location = new Point(220, 10);
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
            guna2ControlBoxMaximize.Location = new Point(260, 10);
            guna2ControlBoxMaximize.Name = "guna2ControlBoxMaximize";
            guna2ControlBoxMaximize.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2ControlBoxMaximize.Size = new Size(35, 29);
            guna2ControlBoxMaximize.TabIndex = 1;
            // 
            // lblMusteriler
            // 
            lblMusteriler.BackColor = Color.Transparent;
            lblMusteriler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMusteriler.Location = new Point(50, 215);
            lblMusteriler.Name = "lblMusteriler";
            lblMusteriler.Size = new Size(74, 23);
            lblMusteriler.TabIndex = 3;
            lblMusteriler.Text = "Müşteriler";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(12, 7);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(108, 32);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Müşteri Sil";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges27;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(107, 69);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2PictureBox1.Size = new Size(148, 140);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 4;
            guna2PictureBox1.TabStop = false;
            // 
            // MusteriSilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 426);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lblMusteriler);
            Controls.Add(topPanel);
            Controls.Add(btnSil);
            Controls.Add(cmbMusteriler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusteriSilForm";
            Text = "Müşteri Sil";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

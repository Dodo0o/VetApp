using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class HayvanEkleForm
    {
        private Guna2TextBox txtAd;
        private Guna2TextBox txtTur;
        private Guna2TextBox txtCins;
        private Guna2DateTimePicker dtpDogumTarihi;
        private Guna2Button btnKaydet;
        private Guna2ComboBox cmbMusteri;
        private Guna2PictureBox pictureBoxHayvan;
        private Guna2Button btnResimSec;
        private OpenFileDialog openFileDialog;

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
            this.txtAd = new Guna2TextBox();
            this.txtTur = new Guna2TextBox();
            this.txtCins = new Guna2TextBox();
            this.dtpDogumTarihi = new Guna2DateTimePicker();
            this.btnKaydet = new Guna2Button();
            this.cmbMusteri = new Guna2ComboBox();
            this.pictureBoxHayvan = new Guna2PictureBox();
            this.btnResimSec = new Guna2Button();
            this.openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHayvan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.BorderRadius = 10;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.DefaultText = "";
            this.txtAd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Location = new System.Drawing.Point(12, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.PlaceholderText = "Hayvan Adı";
            this.txtAd.SelectedText = "";
            this.txtAd.Size = new System.Drawing.Size(200, 36);
            this.txtAd.TabIndex = 0;
            // 
            // txtTur
            // 
            this.txtTur.BorderRadius = 10;
            this.txtTur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTur.DefaultText = "";
            this.txtTur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTur.ForeColor = System.Drawing.Color.Black;
            this.txtTur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTur.Location = new System.Drawing.Point(12, 54);
            this.txtTur.Name = "txtTur";
            this.txtTur.PasswordChar = '\0';
            this.txtTur.PlaceholderText = "Tür";
            this.txtTur.SelectedText = "";
            this.txtTur.Size = new System.Drawing.Size(200, 36);
            this.txtTur.TabIndex = 1;
            // 
            // txtCins
            // 
            this.txtCins.BorderRadius = 10;
            this.txtCins.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCins.DefaultText = "";
            this.txtCins.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCins.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCins.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCins.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCins.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCins.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCins.ForeColor = System.Drawing.Color.Black;
            this.txtCins.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCins.Location = new System.Drawing.Point(12, 96);
            this.txtCins.Name = "txtCins";
            this.txtCins.PasswordChar = '\0';
            this.txtCins.PlaceholderText = "Cins";
            this.txtCins.SelectedText = "";
            this.txtCins.Size = new System.Drawing.Size(200, 36);
            this.txtCins.TabIndex = 2;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.BorderRadius = 10;
            this.dtpDogumTarihi.Checked = true;
            this.dtpDogumTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(12, 138);
            this.dtpDogumTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDogumTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 36);
            this.dtpDogumTarihi.TabIndex = 3;
            this.dtpDogumTarihi.Value = new System.DateTime(2024, 6, 29, 0, 0, 0, 0);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BorderRadius = 10;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.Green;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(12, 246);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 45);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.BackColor = System.Drawing.Color.Transparent;
            this.cmbMusteri.BorderRadius = 10;
            this.cmbMusteri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMusteri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMusteri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMusteri.ForeColor = System.Drawing.Color.Black;
            this.cmbMusteri.ItemHeight = 30;
            this.cmbMusteri.Location = new System.Drawing.Point(12, 180);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(200, 36);
            this.cmbMusteri.TabIndex = 4;
            // 
            // pictureBoxHayvan
            // 
            this.pictureBoxHayvan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHayvan.Location = new System.Drawing.Point(230, 12);
            this.pictureBoxHayvan.Name = "pictureBoxHayvan";
            this.pictureBoxHayvan.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxHayvan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHayvan.TabIndex = 6;
            this.pictureBoxHayvan.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.BorderRadius = 10;
            this.btnResimSec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResimSec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResimSec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResimSec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResimSec.FillColor = System.Drawing.Color.SteelBlue;
            this.btnResimSec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnResimSec.ForeColor = System.Drawing.Color.White;
            this.btnResimSec.Location = new System.Drawing.Point(230, 218);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(200, 45);
            this.btnResimSec.TabIndex = 7;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png|Tüm Dosyalar|*.*";
            // 
            // HayvanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 307);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBoxHayvan);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtCins);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtAd);
            this.Name = "HayvanEkleForm";
            this.Text = "Hayvan Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHayvan)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

using Guna.UI2.WinForms;

namespace VetApp.Forms
{
    partial class RandevuDetayForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblTarih;
        private Guna2HtmlLabel lblSaat;
        private Guna2HtmlLabel lblDetay;
        private Guna2HtmlLabel lblMusteri;
        private Guna2HtmlLabel lblHayvan;

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
            this.lblTarih = new Guna2HtmlLabel();
            this.lblSaat = new Guna2HtmlLabel();
            this.lblDetay = new Guna2HtmlLabel();
            this.lblMusteri = new Guna2HtmlLabel();
            this.lblHayvan = new Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.Location = new System.Drawing.Point(30, 30);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(70, 15);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Randevu Tarihi";
            // 
            // lblSaat
            // 
            this.lblSaat.Location = new System.Drawing.Point(30, 60);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(24, 15);
            this.lblSaat.TabIndex = 1;
            this.lblSaat.Text = "Saat";
            // 
            // lblDetay
            // 
            this.lblDetay.Location = new System.Drawing.Point(30, 90);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(33, 15);
            this.lblDetay.TabIndex = 2;
            this.lblDetay.Text = "Detay";
            // 
            // lblMusteri
            // 
            this.lblMusteri.Location = new System.Drawing.Point(30, 120);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(39, 15);
            this.lblMusteri.TabIndex = 3;
            this.lblMusteri.Text = "Müşteri";
            // 
            // lblHayvan
            // 
            this.lblHayvan.Location = new System.Drawing.Point(30, 150);
            this.lblHayvan.Name = "lblHayvan";
            this.lblHayvan.Size = new System.Drawing.Size(39, 15);
            this.lblHayvan.TabIndex = 4;
            this.lblHayvan.Text = "Hayvan";
            // 
            // RandevuDetayForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblHayvan);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Name = "RandevuDetayForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

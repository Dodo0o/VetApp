using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;
using VetApp.Model;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class MusteriEkleForm : Form
    {
        private readonly MusteriService _musteriService;

        // Form sürükleme için gerekli değişkenler
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MusteriEkleForm(MusteriService musteriService)
        {
            InitializeComponent();
            _musteriService = musteriService;

            // Form özelliklerini ayarla
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = string.Empty;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var yeniMusteri = new Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Eposta = txtEposta.Text,
                TCKimlik = txtTCKimlik.Text,
                Sifre = txtSifre.Text
            };

            _musteriService.AddMusteri(yeniMusteri);

            MessageBox.Show("Müşteri başarıyla eklendi!");
            this.Close();
        }

        // Form sürükleme için gerekli olaylar
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
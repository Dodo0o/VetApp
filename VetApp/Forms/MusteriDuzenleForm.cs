using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Model;

namespace VetApp.Forms
{
    public partial class MusteriDuzenleForm : Form
    {
        private readonly MusteriService _musteriService;

        public MusteriDuzenleForm(MusteriService musteriService)
        {
            InitializeComponent();
            _musteriService = musteriService;
            LoadMusteriler();
        }

        private void LoadMusteriler()
        {
            var musteriler = _musteriService.GetAllMusteriler();
            cmbMusteriler.DataSource = musteriler;
            cmbMusteriler.DisplayMember = "AdSoyad"; // Model'de AdSoyad propertysi olmalı.
            cmbMusteriler.ValueMember = "MusteriID";
        }

        private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteriler.SelectedItem != null)
            {
                var selectedMusteri = (Musteri)cmbMusteriler.SelectedItem;
                txtAd.Text = selectedMusteri.Ad;
                txtSoyad.Text = selectedMusteri.Soyad;
                txtTelefon.Text = selectedMusteri.Telefon;
                txtEposta.Text = selectedMusteri.Eposta;
                txtTCKimlik.Text = selectedMusteri.TCKimlik;
                txtSifre.Text = selectedMusteri.Sifre;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMusteriler.SelectedItem != null)
            {
                var selectedMusteri = (Musteri)cmbMusteriler.SelectedItem;
                selectedMusteri.Ad = txtAd.Text;
                selectedMusteri.Soyad = txtSoyad.Text;
                selectedMusteri.Telefon = txtTelefon.Text;
                selectedMusteri.Eposta = txtEposta.Text;
                selectedMusteri.TCKimlik = txtTCKimlik.Text;
                selectedMusteri.Sifre = txtSifre.Text;

                _musteriService.UpdateMusteri(selectedMusteri);

                MessageBox.Show("Müşteri başarıyla güncellendi!");
                this.Close();
            }
        }

        // Form sürükleme için gerekli olaylar
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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

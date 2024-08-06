using System;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Model;

namespace VetApp.Forms
{
    public partial class MusteriKendiDuzenleForm : Form
    {
        private readonly MusteriService _musteriService;
        private readonly int _musteriId;

        public MusteriKendiDuzenleForm(MusteriService musteriService, int musteriId)
        {
            InitializeComponent();
            _musteriService = musteriService;
            _musteriId = musteriId;
            LoadMusteriBilgileri();
        }

        private void LoadMusteriBilgileri()
        {
            var musteri = _musteriService.GetMusteriById(_musteriId);
            if (musteri != null)
            {
                txtAd.Text = musteri.Ad;
                txtSoyad.Text = musteri.Soyad;
                txtTCKimlik.Text = musteri.TCKimlik;
                txtTelefon.Text = musteri.Telefon;
                txtEposta.Text = musteri.Eposta;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var musteri = new Musteri
            {
                MusteriID = _musteriId,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TCKimlik = txtTCKimlik.Text,
                Telefon = txtTelefon.Text,
                Eposta = txtEposta.Text
            };

            _musteriService.UpdateMusteri(musteri);
            MessageBox.Show("Müşteri bilgileri güncellendi.");
            this.Close();
        }
    }
}

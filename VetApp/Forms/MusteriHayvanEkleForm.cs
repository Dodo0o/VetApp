using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Models;

namespace VetApp.Forms
{
    public partial class MusteriHayvanEkleForm : Form
    {
        private readonly HayvanService _hayvanService;
        private int _musteriId;

        public MusteriHayvanEkleForm(HayvanService hayvanService, int musteriId)
        {
            InitializeComponent();
            _hayvanService = hayvanService;
            _musteriId = musteriId;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var yeniHayvan = new Hayvan
            {
                HayvanAdi = txtHayvanAdi.Text,
                Tur = txtTur.Text,
                Cins = txtCins.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                MusteriID = _musteriId
            };

            //_hayvanService.AddHayvan(yeniHayvan);
            MessageBox.Show("Hayvan başarıyla eklendi.");
            this.Close();
        }
    }
}

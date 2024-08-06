using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using VetApp.Models;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class HayvanEkleForm : Form
    {
        private readonly HayvanService _hayvanService;
        private readonly MusteriService _musteriService;
        private string _resimDosyaYolu;

        public HayvanEkleForm(HayvanService hayvanService, MusteriService musteriService)
        {
            InitializeComponent();
            _hayvanService = hayvanService;
            _musteriService = musteriService;
            LoadMusteriler();
        }

        private void LoadMusteriler()
        {
            var musteriler = _musteriService.GetAllMusteriler();
            cmbMusteri.DataSource = musteriler;
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "MusteriID";
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _resimDosyaYolu = openFileDialog.FileName;
                pictureBoxHayvan.Image = Image.FromFile(_resimDosyaYolu);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var yeniHayvan = new Hayvan
            {
                HayvanAdi = txtAd.Text,
                Tur = txtTur.Text,
                Cins = txtCins.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                MusteriID = (int)cmbMusteri.SelectedValue
            };

            _hayvanService.AddHayvan(yeniHayvan, _resimDosyaYolu);

            MessageBox.Show("Hayvan başarıyla eklendi!");
            this.Close();
        }
    }
}

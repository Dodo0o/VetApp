using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Models;

namespace VetApp.Forms
{
    public partial class MusteriHayvanDuzenleForm : Form
    {
        private readonly HayvanService _hayvanService;
        private int _hayvanId;

        public MusteriHayvanDuzenleForm(HayvanService hayvanService, int hayvanId)
        {
            InitializeComponent();
            _hayvanService = hayvanService;
            _hayvanId = hayvanId;
            LoadHayvan();
        }

        private void LoadHayvan()
        {
            var hayvan = _hayvanService.GetHayvanById(_hayvanId);
            if (hayvan != null)
            {
                txtHayvanAdi.Text = hayvan.HayvanAdi;
                txtTur.Text = hayvan.Tur;
                txtCins.Text = hayvan.Cins;
                dtpDogumTarihi.Value = hayvan.DogumTarihi;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var hayvan = _hayvanService.GetHayvanById(_hayvanId);
            if (hayvan != null)
            {
                hayvan.HayvanAdi = txtHayvanAdi.Text;
                hayvan.Tur = txtTur.Text;
                hayvan.Cins = txtCins.Text;
                hayvan.DogumTarihi = dtpDogumTarihi.Value;

                //_hayvanService.UpdateHayvan(hayvan);

                MessageBox.Show("Hayvan başarıyla güncellendi!");
                this.Close();
            }
        }
    }
}

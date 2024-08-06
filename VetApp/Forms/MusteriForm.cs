using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Models;
using System.Windows.Forms.Design;

namespace VetApp.Forms
{
    public partial class MusteriForm : Form
    {
        private readonly HayvanService _hayvanService;
        private readonly TibbiKayitService _tibbiKayitService;
        private readonly AsiService _asiService;
        private readonly MusteriService _musteriService;
        private int _musteriId;

        public MusteriForm(HayvanService hayvanService, TibbiKayitService tibbiKayitService, AsiService asiService, MusteriService musteriService, int musteriId)
        {
            InitializeComponent();
            _hayvanService = hayvanService;
            _tibbiKayitService = tibbiKayitService;
            _asiService = asiService;
            _musteriService = musteriService;
            _musteriId = musteriId;
            LoadHayvanlar();
        }

        private void LoadHayvanlar()
        {
            var hayvanlar = _hayvanService.GetHayvanlarByMusteriID(_musteriId);
            dataGridViewHayvanlar.DataSource = hayvanlar;
        }

        private void btnHayvanDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewHayvanlar.SelectedRows.Count > 0)
            {
                int hayvanId = Convert.ToInt32(dataGridViewHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);
                var hayvanDuzenleForm = new MusteriHayvanDuzenleForm(_hayvanService, hayvanId);
                hayvanDuzenleForm.ShowDialog();
                LoadHayvanlar(); // Güncelleme sonrası listeyi yenile
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz hayvanı seçin.");
            }
        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewHayvanlar.SelectedRows.Count > 0)
            {
                int hayvanId = Convert.ToInt32(dataGridViewHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);
                var confirmResult = MessageBox.Show("Bu hayvanı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _hayvanService.DeleteHayvan(hayvanId);
                    LoadHayvanlar(); // Silme sonrası listeyi yenile
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz hayvanı seçin.");
            }
        }

        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {
            var hayvanEkleForm = new MusteriHayvanEkleForm(_hayvanService, _musteriId);
            hayvanEkleForm.ShowDialog();
            LoadHayvanlar(); // Ekleme sonrası listeyi yenile
        }

        private void btnMusteriBilgileriniDuzenle_Click(object sender, EventArgs e)
        {
            var musteriDuzenleForm = new MusteriKendiDuzenleForm(_musteriService, _musteriId);
            musteriDuzenleForm.ShowDialog();
        }

        private void btnSaglikGecmisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewHayvanlar.SelectedRows.Count > 0)
            {
                int hayvanId = Convert.ToInt32(dataGridViewHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);
                var saglikGecmisiForm = new SaglikGecmisiForm(_tibbiKayitService, hayvanId);
                saglikGecmisiForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen sağlık geçmişini görmek istediğiniz hayvanı seçin.");
            }
        }

        private void btnAsiBilgileri_Click(object sender, EventArgs e)
        {
            if (dataGridViewHayvanlar.SelectedRows.Count > 0)
            {
                int hayvanId = Convert.ToInt32(dataGridViewHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);
                var asiBilgileriForm = new AsiBilgileriForm(_asiService, hayvanId);
                asiBilgileriForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen aşı bilgilerini görmek istediğiniz hayvanı seçin.");
            }
        }
    }
}

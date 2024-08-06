using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VetApp.Services;
using Microsoft.Extensions.DependencyInjection;
using VetApp.Models;

namespace VetApp.Forms
{
    public partial class VeterinerForm : Form
    {
        private readonly HayvanService _hayvanService;
        private readonly RandevuService _randevuService;
        private readonly TibbiKayitService _tibbiKayitService;
        private readonly AsiService _asiService;
        private readonly IServiceProvider _serviceProvider;

        public VeterinerForm(IServiceProvider serviceProvider, HayvanService hayvanService, RandevuService randevuService, TibbiKayitService tibbiKayitService, AsiService asiService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _hayvanService = hayvanService;
            _randevuService = randevuService;
            _tibbiKayitService = tibbiKayitService;
            _asiService = asiService;
            LoadData();
        }

        private void LoadData()
        {
            var hayvanlar = _hayvanService.GetAllHayvanlar()
                .Select(h => new
                {
                    h.HayvanID,
                    h.HayvanAdi,
                    h.Tur,
                    h.Cins,
                    h.DogumTarihi,
                    MusteriAdiSoyadi = h.MusteriAdiSoyadi
                })
                .ToList();

            var randevular = _randevuService.GetAllRandevular();

            dataGridViewHayvanlar.DataSource = hayvanlar;
            dataGridViewRandevular.DataSource = randevular;
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            var randevuEkleForm = _serviceProvider.GetRequiredService<RandevuEkleForm>();
            randevuEkleForm.Show();
        }

        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {
            var hayvanEkleForm = _serviceProvider.GetRequiredService<HayvanEkleForm>();
            hayvanEkleForm.Show();
        }

        private void btnHayvanDuzenle_Click(object sender, EventArgs e)
        {
            var hayvanDuzenleForm = _serviceProvider.GetRequiredService<HayvanDuzenleForm>();
            hayvanDuzenleForm.Show();
        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            var hayvanSilForm = _serviceProvider.GetRequiredService<HayvanSilForm>();
            hayvanSilForm.Show();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            var musteriEkleForm = _serviceProvider.GetRequiredService<MusteriEkleForm>();
            musteriEkleForm.Show();
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            var musteriDuzenleForm = _serviceProvider.GetRequiredService<MusteriDuzenleForm>();
            musteriDuzenleForm.ShowDialog();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            var musteriSilForm = _serviceProvider.GetRequiredService<MusteriSilForm>();
            musteriSilForm.Show();
        }

        private void btnRandevuDuzenle_Click(object sender, EventArgs e)
        {
            var randevuDuzenleForm = _serviceProvider.GetRequiredService<RandevuDuzenleForm>();
            randevuDuzenleForm.Show();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewRandevular.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewRandevular.SelectedRows[0];
                var randevuId = (int)selectedRow.Cells["RandevuID"].Value;

                var confirmResult = MessageBox.Show("Bu randevuyu silmek istediğinizden emin misiniz?", "Randevu Silme", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _randevuService.DeleteRandevu(randevuId);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.", "Uyarı");
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            var karsilamaForm = _serviceProvider.GetRequiredService<KarsilamaForm>();
            karsilamaForm.Show();
            this.Close();
        }

        private void btnTibbiKayitlar_Click(object sender, EventArgs e)
        {
            if (dataGridViewHayvanlar.SelectedRows.Count > 0)
            {
                int hayvanId = Convert.ToInt32(dataGridViewHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);
                var tibbiKayitForm = new TibbiKayitForm(_tibbiKayitService, hayvanId);
                tibbiKayitForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen tıbbi kayıtlarını görmek istediğiniz hayvanı seçin.");
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

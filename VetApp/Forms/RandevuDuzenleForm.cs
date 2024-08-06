using System;
using System.Windows.Forms;
using VetApp.Model;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class RandevuDuzenleForm : Form
    {
        private readonly RandevuService _randevuService;

        public RandevuDuzenleForm(RandevuService randevuService)
        {
            InitializeComponent();
            _randevuService = randevuService;
        }

        private void RandevuDuzenleForm_Load(object sender, EventArgs e)
        {
            LoadRandevular();
        }

        private void LoadRandevular()
        {
            var randevular = _randevuService.GetAllRandevular();
            dataGridViewRandevular.DataSource = randevular;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewRandevular.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewRandevular.SelectedRows[0];
                var randevu = (Randevu)selectedRow.DataBoundItem;

                txtRandevuTarihi.Text = randevu.RandevuTarihi.ToString("yyyy-MM-dd");
                txtRandevuSaati.Text = randevu.RandevuTarihi.ToString("HH:mm");
                txtRandevuDetay.Text = randevu.Notlar;
                txtMusteriID.Text = randevu.MusteriID.ToString();
                txtHayvanID.Text = randevu.HayvanID.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz randevuyu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewRandevular.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewRandevular.SelectedRows[0];
                var randevu = (Randevu)selectedRow.DataBoundItem;

                randevu.RandevuTarihi = DateTime.Parse(txtRandevuTarihi.Text + " " + txtRandevuSaati.Text);
                randevu.Notlar = txtRandevuDetay.Text;
                randevu.MusteriID = int.Parse(txtMusteriID.Text);
                randevu.HayvanID = int.Parse(txtHayvanID.Text);

                _randevuService.UpdateRandevu(randevu);
                LoadRandevular();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

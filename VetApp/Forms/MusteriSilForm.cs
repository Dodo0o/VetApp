using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class MusteriSilForm : Form
    {
        private readonly MusteriService _musteriService;

        public MusteriSilForm(MusteriService musteriService)
        {
            InitializeComponent();
            _musteriService = musteriService;
            LoadMusteriler();
        }

        private void LoadMusteriler()
        {
            var musteriler = _musteriService.GetAllMusteriler();
            cmbMusteriler.DataSource = musteriler;
            cmbMusteriler.DisplayMember = "AdSoyad";
            cmbMusteriler.ValueMember = "MusteriID";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Onay iste
                DialogResult result = MessageBox.Show("Müşteriyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int musteriId = (int)cmbMusteriler.SelectedValue;
                    _musteriService.DeleteMusteri(musteriId);

                    MessageBox.Show("Müşteri başarıyla silindi!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
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

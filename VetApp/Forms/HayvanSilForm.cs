using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Models;

namespace VetApp.Forms
{
    public partial class HayvanSilForm : Form
    {
        private readonly HayvanService _hayvanService;
        private readonly MusteriService _musteriService;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public HayvanSilForm(HayvanService hayvanService, MusteriService musteriService)
        {
            InitializeComponent();
            _hayvanService = hayvanService;
            _musteriService = musteriService;
            LoadHayvanlar();
        }

        private void LoadHayvanlar()
        {
            var hayvanlar = _hayvanService.GetAllHayvanlar();
            cmbHayvanlar.DataSource = hayvanlar;
            cmbHayvanlar.DisplayMember = "HayvanAdi";
            cmbHayvanlar.ValueMember = "HayvanID";
        }

        private void cmbHayvanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedItem != null)
            {
                var selectedHayvan = (Hayvan)cmbHayvanlar.SelectedItem;
                var musteri = _musteriService.GetMusteriById(selectedHayvan.MusteriID);
                lblSahipAdSoyad.Text = $"Sahip: {musteri.Ad} {musteri.Soyad}";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Hayvanı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var selectedHayvan = (Hayvan)cmbHayvanlar.SelectedItem;
                    _hayvanService.DeleteHayvan(selectedHayvan.HayvanID);

                    MessageBox.Show("Hayvan başarıyla silindi!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

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

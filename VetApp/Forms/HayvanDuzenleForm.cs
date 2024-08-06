using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Models;

namespace VetApp.Forms
{
    public partial class HayvanDuzenleForm : Form
    {
        private readonly HayvanService _hayvanService;
        private readonly MusteriService _musteriService;
        private string _resimDosyaYolu;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public HayvanDuzenleForm(HayvanService hayvanService, MusteriService musteriService)
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
            if (cmbHayvanlar.SelectedItem is Hayvan selectedHayvan)
            {
                txtHayvanAdi.Text = selectedHayvan.HayvanAdi;
                txtTur.Text = selectedHayvan.Tur;
                txtCins.Text = selectedHayvan.Cins;
                dtpDogumTarihi.Value = selectedHayvan.DogumTarihi;
                var musteri = _musteriService.GetMusteriById(selectedHayvan.MusteriID);
                lblSahipAdiSoyadi.Text = $"Sahip: {musteri.Ad} {musteri.Soyad}";

                if (!string.IsNullOrEmpty(selectedHayvan.ResimYolu))
                {
                    pictureBoxHayvan.Image = Image.FromFile(selectedHayvan.ResimYolu);
                }
            }
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
            if (cmbHayvanlar.SelectedItem is Hayvan selectedHayvan)
            {
                selectedHayvan.HayvanAdi = txtHayvanAdi.Text;
                selectedHayvan.Tur = txtTur.Text;
                selectedHayvan.Cins = txtCins.Text;
                selectedHayvan.DogumTarihi = dtpDogumTarihi.Value;

                _hayvanService.UpdateHayvan(selectedHayvan, _resimDosyaYolu);

                MessageBox.Show("Hayvan başarıyla güncellendi!");
                this.Close();
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

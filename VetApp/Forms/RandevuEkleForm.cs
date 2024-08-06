using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VetApp.Models;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class RandevuEkleForm : Form
    {
        private readonly RandevuService _randevuService;
        private readonly MusteriService _musteriService;
        private readonly HayvanService _hayvanService;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public RandevuEkleForm(RandevuService randevuService, MusteriService musteriService, HayvanService hayvanService)
        {
            InitializeComponent();
            _randevuService = randevuService;
            _musteriService = musteriService;
            _hayvanService = hayvanService;
            LoadMusteriList();
        }

        private void LoadMusteriList()
        {
            var musteriler = _musteriService.GetAllMusteriler();
            comboBoxMusteri.DataSource = musteriler;
            comboBoxMusteri.DisplayMember = "AdSoyad";
            comboBoxMusteri.ValueMember = "MusteriID";
        }

        private void comboBoxMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMusteri.SelectedValue != null && comboBoxMusteri.SelectedValue is int musteriID)
            {
                var hayvanlar = _hayvanService.GetHayvanlarByMusteriID(musteriID);
                comboBoxHayvan.DataSource = hayvanlar;
                comboBoxHayvan.DisplayMember = "HayvanAdi";
                comboBoxHayvan.ValueMember = "HayvanID";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMusteri.SelectedValue is int musteriID && comboBoxHayvan.SelectedValue is int hayvanID)
                {
                    Randevu randevu = new Randevu
                    {
                        MusteriID = musteriID,
                        HayvanID = hayvanID,
                        RandevuTarihi = dateTimePickerRandevuTarihi.Value,
                        Notlar = txtNotlar.Text
                    };

                    _randevuService.AddRandevu(randevu);
                    MessageBox.Show("Randevu başarıyla kaydedildi!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen müşteri ve hayvan seçiniz.");
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

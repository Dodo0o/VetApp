using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class VeterinerGirisForm : Form
    {
        private readonly GirisService _girisService;
        private readonly IServiceProvider _serviceProvider;

        // Form sürükleme için gerekli değişkenler
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public VeterinerGirisForm(IServiceProvider serviceProvider, GirisService girisService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _girisService = girisService;

            // Form özelliklerini ayarla
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = string.Empty;
        }

        private void btnVeterinerGirisi_Click(object sender, EventArgs e)
        {
            var tckimlik = txtTCKimlik.Text;
            var sifre = txtSifre.Text;
            var veteriner = _girisService.VeterinerGiris(tckimlik, sifre);

            if (veteriner != null)
            {
                var veterinerForm = _serviceProvider.GetRequiredService<VeterinerForm>();
                veterinerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz TC Kimlik veya Şifre veya yanlış giriş türü.");
            }
        }

        // Form sürükleme için gerekli olaylar
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

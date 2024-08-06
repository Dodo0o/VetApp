using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VetApp.Forms
{
    public partial class KarsilamaForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        // Form sürükleme için gerekli değişkenler
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public KarsilamaForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            // Form özelliklerini ayarla
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = string.Empty;
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            var girisForm = _serviceProvider.GetRequiredService<MusteriGirisForm>();
            girisForm.Show();
            this.Hide();
        }

        private void btnVeteriner_Click(object sender, EventArgs e)
        {
            var girisForm = _serviceProvider.GetRequiredService<VeterinerGirisForm>();
            girisForm.Show();
            this.Hide();
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

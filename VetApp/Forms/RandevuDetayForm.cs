namespace VetApp.Forms
{
    public partial class RandevuDetayForm : Form
    {
        public RandevuDetayForm(Randevu randevu)
        {
            InitializeComponent();
            lblTarih.Text = randevu.RandevuTarihi.ToString("yyyy-MM-dd");
            lblSaat.Text = randevu.RandevuTarihi.ToString("HH:mm");
            lblDetay.Text = randevu.Notlar;
            lblMusteri.Text = $"{randevu.Musteri.Ad} {randevu.Musteri.Soyad}";
            lblHayvan.Text = $"{randevu.Hayvan.HayvanAdi}";
        }
    }
}

using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class TibbiKayitForm : Form
    {
        private readonly TibbiKayitService _tibbiKayitService;
        private int _hayvanId;

        public TibbiKayitForm(TibbiKayitService tibbiKayitService, int hayvanId)
        {
            InitializeComponent();
            _tibbiKayitService = tibbiKayitService;
            _hayvanId = hayvanId;
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadTibbiKayitlar();
        }

        private void LoadTibbiKayitlar()
        {
            var tibbiKayitlar = _tibbiKayitService.GetTibbiKayitlarByHayvanID(_hayvanId);
            dataGridViewTibbiKayitlar.DataSource = tibbiKayitlar;
        }
    }
}

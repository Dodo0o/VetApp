using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class SaglikGecmisiForm : Form
    {
        private readonly TibbiKayitService _tibbiKayitService;
        private readonly int _hayvanId;

        public SaglikGecmisiForm(TibbiKayitService tibbiKayitService, int hayvanId)
        {
            InitializeComponent();
            _tibbiKayitService = tibbiKayitService;
            _hayvanId = hayvanId;
            LoadSaglikGecmisi();
        }

        private void LoadSaglikGecmisi()
        {
            var saglikGecmisi = _tibbiKayitService.GetTibbiKayitlarByHayvanID(_hayvanId);
            dataGridViewSaglikGecmisi.DataSource = saglikGecmisi;
        }
    }
}

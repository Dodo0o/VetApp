using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class AsiBilgileriForm : Form
    {
        private readonly AsiService _asiService;
        private readonly int _hayvanId;

        public AsiBilgileriForm(AsiService asiService, int hayvanId)
        {
            InitializeComponent();
            _asiService = asiService;
            _hayvanId = hayvanId;
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadAsiBilgileri();
        }

        private void LoadAsiBilgileri()
        {
            var asiBilgileri = _asiService.GetAsilarByHayvanID(_hayvanId);
            dataGridViewAsiBilgileri.DataSource = asiBilgileri;
        }
    }
}

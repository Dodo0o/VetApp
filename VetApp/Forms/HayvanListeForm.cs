using System;
using System.Windows.Forms;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class HayvanListeForm : Form
    {
        private readonly HayvanService _hayvanService;

        public HayvanListeForm(HayvanService hayvanService)
        {
            InitializeComponent();
            _hayvanService = hayvanService;
            LoadHayvanlar();
        }

        private void LoadHayvanlar()
        {
            var hayvanlar = _hayvanService.GetAllHayvanlar();
            dataGridViewHayvanlar.DataSource = hayvanlar;
        }
    }
}

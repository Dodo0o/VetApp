using System;
using System.Windows.Forms;
using VetApp.Services;

namespace VetApp.Forms
{
    public partial class RandevuListeForm : Form
    {
        private readonly RandevuService _randevuService;

        public RandevuListeForm(RandevuService randevuService)
        {
            InitializeComponent();
            _randevuService = randevuService;
            LoadRandevular();
        }

        private void LoadRandevular()
        {
            var randevular = _randevuService.GetAllRandevular();
            dataGridViewRandevular.DataSource = randevular;
        }
    }
}

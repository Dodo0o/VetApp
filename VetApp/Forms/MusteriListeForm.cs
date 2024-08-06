using System;
using System.Windows.Forms;

namespace VetApp.Forms
{
    public partial class MusteriListeForm : Form
    {
        private readonly MusteriService _musteriService;

        public MusteriListeForm(MusteriService musteriService)
        {
            InitializeComponent();
            _musteriService = musteriService;
            LoadMusteriler();
        }

        private void LoadMusteriler()
        {
            var musteriler = _musteriService.GetAllMusteriler();
            dataGridViewMusteriler.DataSource = musteriler;
        }
    }
}

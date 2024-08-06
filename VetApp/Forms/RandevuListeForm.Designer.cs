namespace VetApp.Forms
{
    partial class RandevuListeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewRandevular;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewRandevular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRandevular
            // 
            this.dataGridViewRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevular.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRandevular.Name = "dataGridViewRandevular";
            this.dataGridViewRandevular.Size = new System.Drawing.Size(760, 537);
            this.dataGridViewRandevular.TabIndex = 0;
            // 
            // RandevuListeForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewRandevular);
            this.Name = "RandevuListeForm";
            this.Text = "Randevu Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevular)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

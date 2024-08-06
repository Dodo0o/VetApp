namespace VetApp.Forms
{
    partial class HayvanListeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewHayvanlar;

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
            this.dataGridViewHayvanlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHayvanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHayvanlar
            // 
            this.dataGridViewHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHayvanlar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHayvanlar.Name = "dataGridViewHayvanlar";
            this.dataGridViewHayvanlar.Size = new System.Drawing.Size(760, 537);
            this.dataGridViewHayvanlar.TabIndex = 0;
            // 
            // HayvanListeForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewHayvanlar);
            this.Name = "HayvanListeForm";
            this.Text = "Hayvan Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHayvanlar)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

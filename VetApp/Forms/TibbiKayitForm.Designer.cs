using Guna.UI2.WinForms;
using System.Drawing;

namespace VetApp.Forms
{
    partial class TibbiKayitForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dataGridViewTibbiKayitlar;

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
            this.dataGridViewTibbiKayitlar = new Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTibbiKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTibbiKayitlar
            // 
            this.dataGridViewTibbiKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTibbiKayitlar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTibbiKayitlar.Name = "dataGridViewTibbiKayitlar";
            this.dataGridViewTibbiKayitlar.RowTemplate.Height = 25;
            this.dataGridViewTibbiKayitlar.Size = new System.Drawing.Size(760, 337);
            this.dataGridViewTibbiKayitlar.TabIndex = 0;
            // 
            // TibbiKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridViewTibbiKayitlar);
            this.Name = "TibbiKayitForm";
            this.Text = "Tıbbi Kayıtlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTibbiKayitlar)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

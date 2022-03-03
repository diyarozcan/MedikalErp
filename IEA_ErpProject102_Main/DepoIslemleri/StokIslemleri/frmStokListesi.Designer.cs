
namespace IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri
{
    partial class frmStokListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GenelNo,
            this.CariTip,
            this.FaturaNo,
            this.FaturaTarih,
            this.GirisTipi});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1312, 150);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // GenelNo
            // 
            this.GenelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GenelNo.HeaderText = "Genel No";
            this.GenelNo.MinimumWidth = 6;
            this.GenelNo.Name = "GenelNo";
            this.GenelNo.Width = 97;
            // 
            // CariTip
            // 
            this.CariTip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariTip.HeaderText = "Cari Adi";
            this.CariTip.MinimumWidth = 6;
            this.CariTip.Name = "CariTip";
            // 
            // FaturaNo
            // 
            this.FaturaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FaturaNo.HeaderText = "Fatura No";
            this.FaturaNo.MinimumWidth = 6;
            this.FaturaNo.Name = "FaturaNo";
            // 
            // FaturaTarih
            // 
            this.FaturaTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FaturaTarih.HeaderText = "Fatura Tarihi";
            this.FaturaTarih.MinimumWidth = 6;
            this.FaturaTarih.Name = "FaturaTarih";
            this.FaturaTarih.Width = 118;
            // 
            // GirisTipi
            // 
            this.GirisTipi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisTipi.HeaderText = "Giris Tipi";
            this.GirisTipi.MinimumWidth = 6;
            this.GirisTipi.Name = "GirisTipi";
            this.GirisTipi.Width = 93;
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 679);
            this.Controls.Add(this.Liste);
            this.Name = "frmStokListesi";
            this.Text = "frmStokListesi";
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTipi;
    }
}
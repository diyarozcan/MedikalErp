using IEA_ErpProject102_Main.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        public bool Secim = false;
        private int secimId = -1;
        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }


        private void Listele()
        {
            int i = 0;
            var lst = (from s in erp.tblStokGirisUst
                       where s.isActive == true
                       select new
                       {
                           id = s.Id,
                           genelkodu = s.GenelNo,
                           geneladi = s.tblCariler.CariAdi,
                           geneltip = s.GirisTipi,
                           genelfatura = s.FaturaNo,
                           genelfaturatarih = s.FaturaTarih,
                       }).ToList();
            var lst1 = (from s in erp.vwStokGiris where s.isActive == true select s).ToList().Distinct();
            foreach (var k in lst1.Distinct())
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.UstId;
                Liste.Rows[i].Cells[1].Value = k.GenelNo;
                Liste.Rows[i].Cells[2].Value = k.CariAdi;
                Liste.Rows[i].Cells[3].Value = k.FaturaNo;
                Liste.Rows[i].Cells[4].Value = k.FaturaTarih;
                Liste.Rows[i].Cells[5].Value = k.GirisTipi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim)
            {
                Home.Aktarma = secimId;
                Close();
            }
        }
    }
}

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

namespace IEA_ErpProject102_Main.BilgiGirisİslemleri.Hastaneler
{
    public partial class frmHastanelerListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
        private int secimId;
        public bool Secim = false;
        public frmHastanelerListesi()
        {
            InitializeComponent();
        }

        private void frmHastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
            ComboDoldur();
        }
        private void Listele()
        {
           // Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId == 1
                       select new
                       {
                           id = s.Id,
                           hkodu = s.CariKodu,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.hkodu;
                Liste.Rows[i].Cells[3].Value = k.hadi;
                Liste.Rows[i].Cells[4].Value = k.htel;
                Liste.Rows[i].Cells[5].Value = k.hmail;
                Liste.Rows[i].Cells[6].Value = k.hyet;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ComboDoldur()
        {

            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var dep2 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var dep3 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var seh = erp.tblSehirler.ToList();

            frm.txtSehir.DataSource = seh;
            frm.txtSehir.ValueMember = "id";
            frm.txtSehir.DisplayMember = "sehir";
            frm.txtSehir.SelectedIndex = -1;

            frm.txtYetDep1.DataSource = dep1;
            frm.txtYetDep1.ValueMember = "Id";
            frm.txtYetDep1.DisplayMember = "DeptAdi";
            frm.txtYetDep1.SelectedIndex = -1;

            frm.txtYetDep2.DataSource = dep2;
            frm.txtYetDep2.ValueMember = "Id";
            frm.txtYetDep2.DisplayMember = "DeptAdi";
            frm.txtYetDep2.SelectedIndex = -1;

            frm.txtYetDep3.DataSource = dep3;
            frm.txtYetDep3.ValueMember = "Id";
            frm.txtYetDep3.DisplayMember = "DeptAdi";
            frm.txtYetDep3.SelectedIndex = -1;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId >0 && Secim && Application.OpenForms["frmHastaneGirisEkrani"] == null)
            {
                //frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close(); 
            }
            else if (Application.OpenForms["frmHastaneGirisEkrani"] != null)
            {
                frmHastaneGirisEkrani frm = Application.OpenForms["frmHastaneGirisEkrani"] as frmHastaneGirisEkrani;
                frm.Ac(secimId);
                Close();
            }
        }
    }
}

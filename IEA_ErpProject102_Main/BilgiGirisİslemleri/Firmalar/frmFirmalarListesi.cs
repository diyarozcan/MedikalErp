using IEA_ErpProject102_Main.BilgiGirisİslemleri.Hastaneler;
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

namespace IEA_ErpProject102_Main.BilgiGirisİslemleri.Firmalar
{
    
    public partial class frmFirmalarListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        frmFirmaGiris frm = new frmFirmaGiris();
        private int secimId;
        public bool Secim = false;
        public frmFirmalarListesi()
        {
            InitializeComponent();
        }

        private void frmFirmalarListesi_Load(object sender, EventArgs e)
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
                       where s.CariGrupId == 3
                       select new
                       {
                           id = s.Id,
                           fkodu = s.CariKodu,
                           fadi = s.CariAdi,
                           ftel = s.CariTel,
                           fmail = s.CariMail,
                           fyet = s.YetkiliAdi1,
                           fyetcep = s.YetkiliCep1
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.fkodu;
                Liste.Rows[i].Cells[3].Value = k.fadi;
                Liste.Rows[i].Cells[4].Value = k.ftel;
                Liste.Rows[i].Cells[5].Value = k.fmail;
                Liste.Rows[i].Cells[6].Value = k.fyet;
                Liste.Rows[i].Cells[7].Value = k.fyetcep;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ComboDoldur()
        {

            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var dep2 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var dep3 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var seh = erp.tblSehirler.ToList();

            frm.txtSehir.DataSource = seh;
            frm.txtSehir.ValueMember = "id";
            frm.txtSehir.DisplayMember = "sehir";
            frm.txtSehir.SelectedIndex = -1;

            frm.txtFirDep1.DataSource = dep1;
            frm.txtFirDep1.ValueMember = "Id";
            frm.txtFirDep1.DisplayMember = "DeptAdi";
            frm.txtFirDep1.SelectedIndex = -1;

            frm.txtFirDep2.DataSource = dep2;
            frm.txtFirDep2.ValueMember = "Id";
            frm.txtFirDep2.DisplayMember = "DeptAdi";
            frm.txtFirDep2.SelectedIndex = -1;

            frm.txtFirDep3.DataSource = dep3;
            frm.txtFirDep3.ValueMember = "Id";
            frm.txtFirDep3.DisplayMember = "DeptAdi";
            frm.txtFirDep3.SelectedIndex = -1;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Application.OpenForms["frmFirmaGiris"] == null)
            {
                //frmFirmaGiris frm = new frmFirmaGiris();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmFirmaGiris"] != null)
            {
                frmFirmaGiris frm = Application.OpenForms["frmFirmaGiris"] as frmFirmaGiris;
                frm.Ac(secimId);
                Close();
            }
        }
    }
}

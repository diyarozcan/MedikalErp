using IEA_ErpProject102_Main.Entity;
using IEA_ErpProject102_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102_Main.BilgiGirisİslemleri.Doktorlar
{
    public partial class frmDoktorlarListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
        private int secimId;
        public bool Secim = false;
        public frmDoktorlarListesi()
        {
            InitializeComponent();
        }

        private void frmDoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
            ComboDoldur();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId == 2
                       select new
                       {
                           id = s.Id,
                           dkodu = s.CariKodu,
                           dadi = s.CariAdi,
                           dtel = s.CariTel,
                           dmail = s.CariMail,
                           dyetcep = s.YetkiliCep1
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.dkodu;
                Liste.Rows[i].Cells[3].Value = k.dadi;
                Liste.Rows[i].Cells[4].Value = k.dtel;
                Liste.Rows[i].Cells[5].Value = k.dyetcep;
                Liste.Rows[i].Cells[6].Value = k.dmail;

                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ComboDoldur()
        {
            frm.txtDokUnvan.DataSource = Enum.GetValues(typeof(enumDoktorUnvanlar));

            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
            var seh = erp.tblSehirler.ToList();

            frm.txtSehir.DataSource = seh;
            frm.txtSehir.ValueMember = "id";
            frm.txtSehir.DisplayMember = "sehir";
            frm.txtSehir.SelectedIndex = -1;


            frm.txtDokDep1.DataSource = dep1;
            frm.txtDokDep1.ValueMember = "Id";
            frm.txtDokDep1.DisplayMember = "DeptAdi";
            frm.txtDokDep1.SelectedIndex = -1;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim && Application.OpenForms["frmDoktorGirisEkrani"] == null)
            {
                //frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmDoktorGirisEkrani"] != null)
            {
                frmDoktorGirisEkrani frm = Application.OpenForms["frmDoktorGirisEkrani"] as frmDoktorGirisEkrani;
                frm.Ac(secimId);
                Close();
            }
        }
    }
}

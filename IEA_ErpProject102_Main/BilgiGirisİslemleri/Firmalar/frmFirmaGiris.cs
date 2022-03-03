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

namespace IEA_ErpProject102_Main.BilgiGirisİslemleri.Firmalar
{
    public partial class frmFirmaGiris : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void YeniKayit()
        {
            string fkodu = n.CariKoduFirma();
            try
            {
                if (txtFirmaAdi.Text == "")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtFirmaAdi.Text;
                    hst.CariMail = txtFirMail.Text;
                    hst.CariTel = txtFirTel.Text;
                    hst.YetkiliAdi1 = txtYetAdi1.Text;
                    hst.YetkiliAdi2 = txtYetAdi2.Text;
                    hst.YetkiliAdi3 = txtYetAdi3.Text;
                    hst.YetkiliDep1 = txtFirDep1.Text;
                    hst.YetkiliDep2 = txtFirDep2.Text;
                    hst.YetkiliDep3 = txtFirDep3.Text;
                    hst.YetkiliTel1 = txtYetTel1.Text;
                    hst.YetkiliTel2 = txtYetTel2.Text;
                    hst.YetkiliTel3 = txtYetTel3.Text;
                    hst.YetkiliCep1 = txtYetCep1.Text;
                    hst.YetkiliCep2 = txtYetCep2.Text;
                    hst.YetkiliCep3 = txtYetCep3.Text;
                    hst.YetkiliMail1 = txtYetEmail1.Text;
                    hst.YetkiliMail2 = txtYetEmail2.Text;
                    hst.YetkiliMail3 = txtYetEmail3.Text;
                    hst.Adres1 = txtAdres1.Text;
                    hst.Adres2 = txtAdres2.Text;
                    hst.CariGrupId = 3;
                    hst.CariTipId = (int)txtFirmaTip.SelectedValue;
                    hst.VDairesi = txtVergiD.Text;
                    hst.VnoTcno = txtVnTc.Text;
                    if (txtSehir.Text != "")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
                    //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1;
                    //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;

                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = fkodu;

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();
                    MessageBox.Show("Kayit Basarili");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu kayit daha once sahiplendirilmis. Kendine baska bir kayit bul..");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Guncelle()
        {
            if (secimId < 0)
            {
                return;
            }
            try
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.CariAdi = txtFirmaAdi.Text;
                hst.CariMail = txtFirMail.Text;
                hst.CariTel = txtFirTel.Text;
                hst.YetkiliAdi1 = txtYetAdi1.Text;
                hst.YetkiliAdi2 = txtYetAdi2.Text;
                hst.YetkiliAdi3 = txtYetAdi3.Text;
                hst.YetkiliDep1 = txtFirDep1.Text;
                hst.YetkiliDep2 = txtFirDep2.Text;
                hst.YetkiliDep3 = txtFirDep3.Text;
                hst.YetkiliTel1 = txtYetTel1.Text;
                hst.YetkiliTel2 = txtYetTel2.Text;
                hst.YetkiliTel3 = txtYetTel3.Text;
                hst.YetkiliCep1 = txtYetCep1.Text;
                hst.YetkiliCep2 = txtYetCep2.Text;
                hst.YetkiliCep3 = txtYetCep3.Text;
                hst.YetkiliMail1 = txtYetEmail1.Text;
                hst.YetkiliMail2 = txtYetEmail2.Text;
                hst.YetkiliMail3 = txtYetEmail3.Text;
                hst.Adres1 = txtAdres1.Text;
                hst.Adres2 = txtAdres2.Text;
                if (txtFirmaTip.Text != "")
                {
                    hst.CariTipId = (int)txtFirmaTip.SelectedValue;
                }
               
                hst.VDairesi = txtVergiD.Text;
                hst.VnoTcno = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1;
                //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;

                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1;
                hst.CariKodu = lblFirmaKodu.Text;

                erp.SaveChanges();
                MessageBox.Show("Guncelleme Basarili");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
            txtSehir.SelectedIndex = -1;
            txtFirDep1.SelectedIndex = -1;
            txtFirDep2.SelectedIndex = -1;
            txtFirDep3.SelectedIndex = -1;
        }
        private void ComboDoldur()
        {
            txtFirmaTip.DataSource = Enum.GetValues(typeof(enumFirmaTipi));
            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var dep2 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var dep3 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;


            txtFirDep1.DataSource = dep1;
            txtFirDep1.ValueMember = "Id";
            txtFirDep1.DisplayMember = "DeptAdi";
            txtFirDep1.SelectedIndex = -1;

            txtFirDep2.DataSource = dep2;
            txtFirDep2.ValueMember = "Id";
            txtFirDep2.DisplayMember = "DeptAdi";
            txtFirDep2.SelectedIndex = -1;

            txtFirDep3.DataSource = dep3;
            txtFirDep3.ValueMember = "Id";
            txtFirDep3.DisplayMember = "DeptAdi";
            txtFirDep3.SelectedIndex = -1;
        }
        private void Listele()
        {
            Liste.Rows.Clear();
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

            lblFirmaKodu.Text = n.CariKoduFirma();
        }
        public void Ac(int i)
        {
            secimId = i;
            try
            {
                tblCariler hst = erp.tblCariler.Find(i);
                txtFirmaAdi.Text = hst.CariAdi;
                txtFirMail.Text = hst.CariMail;
                txtFirTel.Text = hst.CariTel;
                txtYetAdi1.Text = hst.YetkiliAdi1;
                txtYetAdi2.Text = hst.YetkiliAdi2;
                txtYetAdi3.Text = hst.YetkiliAdi3;
                txtFirDep1.Text = hst.YetkiliDep1;
                txtFirDep2.Text = hst.YetkiliDep2;
                txtFirDep3.Text = hst.YetkiliDep3;
                txtYetTel1.Text = hst.YetkiliTel1;
                txtYetTel2.Text = hst.YetkiliTel2;
                txtYetTel3.Text = hst.YetkiliTel3;
                txtYetCep1.Text = hst.YetkiliCep1;
                txtYetCep2.Text = hst.YetkiliCep2;
                txtYetCep3.Text = hst.YetkiliCep3;
                txtYetEmail1.Text = hst.YetkiliMail1;
                txtYetEmail2.Text = hst.YetkiliMail2;
                txtYetEmail3.Text = hst.YetkiliMail3;
                txtAdres1.Text = hst.Adres1;
                txtAdres2.Text = hst.Adres2;
                txtVergiD.Text = hst.VDairesi;
                txtVnTc.Text = hst.VnoTcno;
                if (hst.tblSehirler != null)
                {
                    txtSehir.Text = hst.tblSehirler.sehir;
                }
                else
                {
                    txtSehir.Text = "";
                }
                lblFirmaKodu.Text = hst.CariKodu;
                txtFirmaTip.Text = Enum.GetName(typeof(enumFirmaTipi), hst.CariTipId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme basarili");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
    }
}

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

namespace IEA_ErpProject102_Main.BilgiGirisİslemleri.Personeller
{
    
    public partial class frmPersonelGirisEkrani : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private int secimId = -1;
        private Numaralar n = new Numaralar();
        public frmPersonelGirisEkrani()
        {
            InitializeComponent();
        }

        private void frmPersonelGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void ComboDoldur()
        {
            txtPerUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvan));
            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 4).ToList();
            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;


            txtPerDep1.DataSource = dep1;
            txtPerDep1.ValueMember = "Id";
            txtPerDep1.DisplayMember = "DeptAdi";
            txtPerDep1.SelectedIndex = -1;
        }
        private void YeniKayit()
        {
            string pkodu = n.CariKoduPersonel();
            try
            {
                if (txtPerAdi.Text=="")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtPerAdi.Text;
                    hst.CariMail = txtPerMail.Text;
                    hst.CariTel = txtPerTel.Text;
                    hst.YetkiliCep1 = txtPerCep.Text;
                    hst.YetkiliDep1 = txtPerDep1.Text;
                    hst.Adres1 = txtPerAdres.Text;
                    hst.VnoTcno = txtVnTc.Text;
                    hst.CariGrupId = 4;
                    hst.CariTipId = 1;
                    if (txtSehir.SelectedValue != null)
                    {
                        hst.SehirId = (int)txtSehir.SelectedValue;
                    }
                    //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1;
                    //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = pkodu;
                    hst.GirisTarihi = txtGirisTarihi.Value;
                    hst.CikisTarihi = txtBitisTarihi.Value;

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

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId == 4
                       select new
                       {
                           id = s.Id,
                           pkodu = s.CariKodu,
                           padi = s.CariAdi,
                           ptel = s.CariTel,
                           pcep = s.YetkiliCep1,
                           pmail = s.CariMail,
                           pgiris = s.GirisTarihi,
                           pcikis= s.CikisTarihi
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.pkodu;
                Liste.Rows[i].Cells[3].Value = k.padi;
                Liste.Rows[i].Cells[4].Value = k.ptel;
                Liste.Rows[i].Cells[5].Value = k.pcep;
                Liste.Rows[i].Cells[6].Value = k.pmail;
                Liste.Rows[i].Cells[7].Value = k.pgiris;
                Liste.Rows[i].Cells[8].Value = k.pcikis;

                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblPerKodu.Text = n.CariKoduPersonel();
        }
        public void Ac(int i)
        {
            secimId = i;
            try
            {
                tblCariler hst = erp.tblCariler.Find(i);
                txtPerAdi.Text = hst.CariAdi;
                txtPerMail.Text = hst.CariMail;
                txtPerTel.Text = hst.CariTel;
                txtPerDep1.Text = hst.YetkiliDep1;
                txtPerCep.Text = hst.YetkiliCep1;
                txtPerAdres.Text = hst.Adres1;
                txtPerAdres2.Text = hst.Adres2;
                txtPerUnvan.Text = hst.CariUnvan;
                txtVnTc.Text = hst.VnoTcno;
                txtSehir.Text = hst.tblSehirler == null ? "" : hst.tblSehirler.sehir;
                lblPerKodu.Text = hst.CariKodu;
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
                hst.CariAdi = txtPerAdi.Text;
                hst.CariMail = txtPerMail.Text;
                hst.CariTel = txtPerTel.Text;
                hst.YetkiliDep1 = txtPerDep1.Text;
                hst.YetkiliCep1 = txtPerCep.Text;
                hst.Adres1 = txtPerAdres.Text;
                hst.Adres2 = txtPerAdres2.Text;
                hst.CariTipId = 1;
                hst.CariUnvan = txtPerUnvan.Text;
                hst.VnoTcno = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1;
                //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;

                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1;
                hst.CariKodu = lblPerKodu.Text;

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
            txtPerDep1.SelectedIndex = -1;

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}

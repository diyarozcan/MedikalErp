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
    public partial class frmDoktorGirisEkrani : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public frmDoktorGirisEkrani()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmDoktorGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            txtDokUnvan.DataSource = Enum.GetValues(typeof(enumDoktorUnvanlar));

            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;


            txtDokDep1.DataSource = dep1;
            txtDokDep1.ValueMember = "Id";
            txtDokDep1.DisplayMember = "DeptAdi";
            txtDokDep1.SelectedIndex = -1;

            
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            string dkodu = n.CariKoduDoktor();
            try
            {
                if (txtDokAdi.Text=="")
                {
                    return;
                }
                if(secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtDokAdi.Text;
                    hst.CariMail = txtDokMail.Text;
                    hst.CariTel = txtDokTel.Text;
                    hst.YetkiliCep1 = txtDokCep.Text;
                    hst.YetkiliDep1 = txtDokDep1.Text;
                    
                    hst.Adres1 = txtHastAdres.Text;
                    hst.Adres2 = txtMuaAdres.Text;
                    hst.CariGrupId = 2;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtDokUnvan.Text;
                    hst.VDairesi = txtVergiD.Text;
                    hst.VnoTcno = txtVnTc.Text;
                    if (txtSehir.SelectedValue != null)
                    {
                        hst.SehirId = (int)txtSehir.SelectedValue;
                    }
                    
                    //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1;
                    //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;

                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = dkodu;

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

            lblDoktorKodu.Text = n.CariKoduDoktor();
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
            txtDokDep1.SelectedIndex = -1;
           
        }
        private void Guncelle()
        {
            if (secimId<0)
            {
                return;
            }
            try
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.CariAdi = txtDokAdi.Text;
                hst.CariMail = txtDokMail.Text;
                hst.CariTel = txtDokTel.Text;
                hst.YetkiliDep1 = txtDokDep1.Text;
                hst.YetkiliCep1 = txtDokCep.Text;
                hst.Adres1 = txtHastAdres.Text;
                hst.Adres2 = txtMuaAdres.Text;
                hst.CariTipId = 1;
                hst.CariUnvan = txtDokUnvan.Text;
                hst.VDairesi = txtVergiD.Text;
                hst.VnoTcno = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                //txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1;
                //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;

                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1;
                hst.CariKodu = lblDoktorKodu.Text;

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

        public void Ac(int i)
        {
            secimId = i;
            try
            {
                tblCariler hst = erp.tblCariler.Find(i);
                txtDokAdi.Text = hst.CariAdi;
                txtDokMail.Text = hst.CariMail;
                txtDokTel.Text = hst.CariTel;
                txtDokDep1.Text = hst.YetkiliDep1;
                txtDokCep.Text = hst.YetkiliCep1;
                txtHastAdres.Text = hst.Adres1;
                txtMuaAdres.Text = hst.Adres2;
                txtDokUnvan.Text = hst.CariUnvan;
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
                lblDoktorKodu.Text = hst.CariKodu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

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

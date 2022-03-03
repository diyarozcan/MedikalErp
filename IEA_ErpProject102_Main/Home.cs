using IEA_ErpProject102_Main.BilgiGirisİslemleri.Doktorlar;
using IEA_ErpProject102_Main.BilgiGirisİslemleri.Firmalar;
using IEA_ErpProject102_Main.BilgiGirisİslemleri.Hastaneler;
using IEA_ErpProject102_Main.BilgiGirisİslemleri.Personeller;
using IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri;
using IEA_ErpProject102_Main.Fonksiyonlar;
using IEA_ErpProject102_Main.UrunIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102_Main
{
    public partial class Home : Form
    {
        public static int Aktarma = -1;
        formlar f = new formlar();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giris İslemleri
            tvBilgiGirisİslemleri.Nodes.Add("Hastaneler"); //root elemani
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giris Ekrani"); // child
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi"); // child

            tvBilgiGirisİslemleri.Nodes.Add("Doktorlar"); //root elemani
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktor Bilgi Giris Ekrani"); // child
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi"); // child

            tvBilgiGirisİslemleri.Nodes.Add("Firmalar"); //root elemani
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Firma Bilgi Giris Ekrani"); // child
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Firmalar Listesi"); // child

            tvBilgiGirisİslemleri.Nodes.Add("Personeller"); //root elemani
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Personel Giris Ekrani"); //child
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Personeller Listesi"); //child
            #endregion

            #region Urun Islemleri
            tvUrunIslemleri.Nodes.Add("Urunler");//root elemani
            tvUrunIslemleri.Nodes[0].Nodes.Add("Urun Giris Ekrani");//Child
            tvUrunIslemleri.Nodes[0].Nodes.Add("Urunler Listesi");//Child
            #endregion

            #region DepoIslemleri
            tvDepoIslemleri.Nodes.Add("Depo Islemleri");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Giris");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Giris");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Giris Listesi");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat");
            #endregion
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisİslemleri.Visible = true;
        }

        private void TvGorunum()
        {
            tvBilgiGirisİslemleri.Visible = false;
            tvUrunIslemleri.Visible = false;
            tvDepoIslemleri.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;
        }

        private void tvBilgiGirisİslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim =tvBilgiGirisİslemleri.SelectedNode!= null ? tvBilgiGirisİslemleri.SelectedNode.Text : "";
            if (isim== "Hastane Bilgi Giris Ekrani" && Application.OpenForms ["frmHastaneGirisEkrani"] as frmHastaneGirisEkrani is null )
            {
                frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Hastaneler Listesi" && Application.OpenForms ["frmHastanelerListesi"] as frmHastanelerListesi  is null)
            {
                //frmHastanelerListesi frm = new frmHastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                f.HastaneListesi();

            }
            else if (isim == "Doktor Bilgi Giris Ekrani" && Application.OpenForms["frmDoktorGirisEkrani"] == null)
            {
                frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] ==  null)
            {
                //frmDoktorlarListesi frm = new frmDoktorlarListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                f.DoktorlarListesi();
            }
            else if (isim== "Personel Giris Ekrani" && Application.OpenForms["frmPersonelGirisEkrani"] == null)
            {
                frmPersonelGirisEkrani frm = new frmPersonelGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim== "Personeller Listesi" && Application.OpenForms["frmPersonellerListesi"] == null)
            {
                //frmPersonellerListesi frm = new frmPersonellerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                f.PersonellerListesi();
            }
            else if (isim == "Firma Bilgi Giris Ekrani" && Application.OpenForms["frmFirmaGiris"] == null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firmalar Listesi" && Application.OpenForms["frmFirmalarListesi"] == null)
            {
                //frmFirmalarListesi frm = new frmFirmalarListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                f.FirmalarListesi();
            }
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnUrunIslemleri.Text;
            TvGorunum();
            tvUrunIslemleri.Visible = true;
        }

        private void tvUrunIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = tvUrunIslemleri.SelectedNode != null ? tvUrunIslemleri.SelectedNode.Text : "";
            if (isim == "Urun Giris Ekrani" && Application.OpenForms["frmUrunGirisEkrani"] as frmUrunGirisEkrani is null)
            {
                frmUrunGirisEkrani frm = new frmUrunGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Urunler Listesi" && Application.OpenForms["frmUrunlerListesi"] as frmUrunlerListesi is null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        private void tvDepoIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = tvDepoIslemleri.SelectedNode != null ? tvDepoIslemleri.SelectedNode.Text : "";
            if (isim == "Stok Giris Listesi" && Application.OpenForms["frmStokListesi"] as frmStokListesi is null)
            {
                frmStokListesi frm = new frmStokListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Stok Giris" && Application.OpenForms["frmStokGiris"] as frmStokGiris is null)
            {
                frmStokGiris frm = new frmStokGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnDepoIslemleri.Text;
            TvGorunum();
            tvDepoIslemleri.Visible = true;
        }
    }
}



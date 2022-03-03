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

namespace IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokGirisGuncelleme : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        formlar f = new formlar();
        private int secimId = -1;
        public frmStokGirisGuncelleme()
        {
            InitializeComponent();
        }

        private void frmStokGirisGuncelleme_Load(object sender, EventArgs e)
        {
            FormDoldur();
        }
        private void FormDoldur()
        {
            secimId = Home.Aktarma;
            var sonuc = erp.tblStokGirisAlt.Find(secimId);
            txtGenelNo.Text = sonuc.GenelNo.ToString();
            lblGenelNo.Text = sonuc.GenelNo.ToString();
            txtAlisFiyat.Text = sonuc.AlisFiyat.ToString();
            lblAlisFiyat.Text = sonuc.AlisFiyat.ToString();
            txtBarkod.Text = sonuc.Barkod;
            lblBarkod.Text = sonuc.Barkod;
            txtLot.Text = sonuc.LotSeriNo;
            lblLot.Text = sonuc.LotSeriNo;
            txtSkt.Text = sonuc.SKT.ToString();
            lblSkt.Text = sonuc.SKT.ToString();
            txtUrunKodu.Text = sonuc.UrunKodu;
            lblUrunKodu.Text = sonuc.UrunKodu;
            txtUt.Text = sonuc.UT.ToString();
            lblUt.Text = sonuc.UT.ToString();
            txtAdet.Text = sonuc.Adet.ToString();
            lblAdet.Text = sonuc.Adet.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            var srg = erp.tblStokDurum.First(s => s.Barkod == txtBarkod.Text);

            if (srg != null)
            {
                srg.StokAdet -= int.Parse(lblAdet.Text);
                srg.RafAdet -= int.Parse(lblAdet.Text);
                srg.StokAdet += int.Parse(txtAdet.Text);
                srg.RafAdet += int.Parse(txtAdet.Text);
            }

            var lst = erp.tblStokGirisAlt.First(s => s.Id == secimId);

            lst.UrunKodu = txtUrunKodu.Text;
            lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
            lst.Barkod = txtBarkod.Text;
            lst.GenelNo = Convert.ToInt32(txtGenelNo.Text);
            lst.LotSeriNo = txtLot.Text;
            lst.SKT = txtSkt.Value;
            lst.UT = txtUt.Value;
            lst.Adet = Convert.ToInt32(txtAdet.Text);

            erp.SaveChanges();

            MessageBox.Show("Guncelleme Yapildi :)");
            Close();
        }
    }
}

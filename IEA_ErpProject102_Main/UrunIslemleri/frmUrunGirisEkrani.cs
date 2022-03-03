﻿using IEA_ErpProject102_Main.Entity;
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

namespace IEA_ErpProject102_Main.UrunIslemleri
{
    public partial class frmUrunGirisEkrani : Form
    {
        ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public frmUrunGirisEkrani()
        {
            InitializeComponent();
        }

        private void frmUrunGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler where s.isActive == true select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                Liste.Rows[i].Cells[3].Value = k.UrunKodu;
                Liste.Rows[i].Cells[4].Value = k.UrunAdi;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblUrunKodu.Text = n.UrunGenelKodu();
            txtGenelNo.Text = n.UrunGenelKodu();
        }

        private void ComboDoldur()
        {
            txtDistributor.DataSource = (from s in erp.tblCariler where s.CariGrupId == 3 where s.CariTipId == 1 select s).ToList();
            txtDistributor.ValueMember = "Id";
            txtDistributor.DisplayMember = "CariAdi";
            txtDistributor.SelectedIndex = -1;
        }

        private void YeniKayit()
        {
            if (secimId != -1 || txtUrunKodu.Text=="")
            {
                return;
            }
            try
            {
                tblUrunler urn = new tblUrunler();
                urn.UrunAdi = txtUrunAdi.Text;
                urn.UrunGenelNo = n.UrunGenelKodu();
                urn.UrunKodu = txtUrunKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                urn.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                urn.DistributorId = (int)txtDistributor.SelectedValue;
                urn.KutuIcerik = txtKutuIcerik.Text;
                urn.UrunAciklama = txtUrunAcik.Text;
                urn.KullanimSuresiAy = txtKullanimSuresi.Value;
                urn.SaveDate = DateTime.Now;
                urn.SaveUserId = 1;
                urn.isActive = true;


                erp.tblUrunler.Add(urn);
                erp.SaveChanges();
                MessageBox.Show("Kayit Basarili");
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
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId =(int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private  tblUrunler urunler;
        public void Ac(int id)
        {
            secimId = id;
            urunler = erp.tblUrunler.Find(secimId);
            try
            {
                tblUrunler urn = urunler;
                txtDistributor.Text = urn.tblCariler.CariAdi;
                txtGenelNo.Text = urn.UrunGenelNo;
                txtUrunKodu.Text = urn.UrunKodu;
                txtUrunAdi.Text = urn.UrunAdi;
                txtUrunAcik.Text = urn.UrunAciklama;
                txtKutuIcerik.Text = urn.KutuIcerik;
                txtAlisFiyat.Text = urn.AlisFiyat.ToString();
                txtSatisFiyat.Text = urn.SatisFiyat.ToString();
                lblUrunKodu.Text = urn.UrunGenelNo;
               if (urn.KullanimSuresiAy != null) txtKullanimSuresi.Value = urn.KullanimSuresiAy.Value;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Guncelle()
        {
            if (secimId == -1)
            {
                return;
            }
            try
            {
                tblUrunler urn = urunler;
                urn.UrunAdi = txtUrunAdi.Text;
                urn.UrunGenelNo = txtGenelNo.Text;
                urn.UrunKodu = txtUrunKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                urn.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                urn.DistributorId = (int)txtDistributor.SelectedValue;
                urn.KutuIcerik = txtKutuIcerik.Text;
                urn.UrunAciklama = txtUrunAcik.Text;
                urn.KullanimSuresiAy = txtKullanimSuresi.Value;
                urn.UpdateDate = DateTime.Now;
                urn.UpdateUserId = 1;

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblUrunler hst = urunler;
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme basarili");
                Temizle();
                Listele();
            }
        }
    }
}

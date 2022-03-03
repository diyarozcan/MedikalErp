using IEA_ErpProject102_Main.BilgiGirisİslemleri.Doktorlar;
using IEA_ErpProject102_Main.BilgiGirisİslemleri.Firmalar;
using IEA_ErpProject102_Main.BilgiGirisİslemleri.Hastaneler;
using IEA_ErpProject102_Main.BilgiGirisİslemleri.Personeller;
using IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject102_Main.Fonksiyonlar
{
    class formlar
    {
        public int HastaneListesi(bool secim = false)
        {
            frmHastanelerListesi frm = new frmHastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public int DoktorlarListesi(bool secim = false)
        {
            frmDoktorlarListesi frm = new frmDoktorlarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public int FirmalarListesi(bool secim = false)
        {
            frmFirmalarListesi frm = new frmFirmalarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public int PersonellerListesi(bool secim = false)
        {
            frmPersonellerListesi frm = new frmPersonellerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public int StokGirisListesi(bool secim = false)
        {
            frmStokListesi frm = new frmStokListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public void StokGirisGuncelle()
        {
            frmStokGirisGuncelleme frm = new frmStokGirisGuncelleme();
            frm.ShowDialog();
        }
    }
}

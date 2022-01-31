using System.Windows.Forms;
using OtelRezervasyonDevEx.Formlar.Araclar;
using OtelRezervasyonDevEx.Formlar.Misafir;
using OtelRezervasyonDevEx.Formlar.Personel;
using OtelRezervasyonDevEx.Formlar.Rezervasyon;
using OtelRezervasyonDevEx.Formlar.Tanımlamalar;
using OtelRezervasyonDevEx.Formlar.Urun;
using OtelRezervasyonDevEx.Formlar.WebSite;

namespace OtelRezervasyonDevEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Rename
            FrmDurum fr = new FrmDurum();
           fr.Show();
        }

        private void BtnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBirim fr = new FrmBirim();
            fr.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // rename
            FrmDepartman fr = new FrmDepartman();
            fr.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // rename
            FrmGorev fr = new FrmGorev();
            fr.Show();
        }

        private void BtnKasaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa fr = new FrmKasa();
            fr.Show();
        }

        private void BtnKurTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKur fr = new FrmKur();
            fr.Show();
        }

        private void BtnOdaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOda fr = new FrmOda();
            fr.Show();
        }

        private void BtnPersonelTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel fr = new FrmPersonel();
            fr.Show();
        }

        private void BtnTelefonTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTelefon fr = new FrmTelefon();
            fr.Show();
        }

        private void BtnUlkeTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUlke fr = new FrmUlke();
            fr.Show();
        }

        private void BtnUrunGrupTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunGrup fr = new FrmUrunGrup();
            fr.Show();
        }

        private void BtnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonelKarti fr = new FrmPersonelKarti();
            fr.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonelListesi fr = new FrmPersonelListesi();
            fr.MdiParent = this;
            fr.Show();

        }

        private void BtnMisafirKArti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMisafirKarti fr = new FrmMisafirKarti();
            fr.Show();
        }

        private void BtnMisafirListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMisafirListesi fr = new FrmMisafirListesi();
            fr.MdiParent = this;
            fr.Show();

        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunListesi fr = new FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunKarti fr = new FrmUrunKarti();
            fr.Show();

        }

        private void BtnUrunGirisHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunGirisHareketleri fr = new FrmUrunGirisHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunCikisHareketleri fr = new FrmUrunCikisHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniUrunHareketi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunHareketTanimi fr = new FrmUrunHareketTanimi();
            fr.Show();
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Rezervasyon Kartı 

            FrmRezervasyonKarti fr = new FrmRezervasyonKarti();
            fr.Show();
        }

        private void BtnRezervasysonListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTumRezervasyonlar fr = new FrmTumRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAktifRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAktifRezervasyonlar fr = new FrmAktifRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnIptalEdilenRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmIptalEdilenRezervasyonlar fr = new FrmIptalEdilenRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGecmisRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGecmisRezervasyonlar fr = new FrmGecmisRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGelecekRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGelecekRezervasyonlar fr = new FrmGelecekRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();

        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Banka yada Referasn alınan kurum kurları
            FrmKurlar fr = new FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYoutube fr = new FrmYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGoogle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGoogle fr = new FrmGoogle();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem4_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { //btnwebkayit
            // Test
            FrmYeniKayit fr = new FrmYeniKayit();
            fr.MdiParent=this;
            fr.Show();

        }

        private void BtnOnRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOnRezervasyon fr = new FrmOnRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}

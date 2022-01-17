using System.Windows.Forms;
using OtelRezervasyonDevEx.Formlar.Misafir;
using OtelRezervasyonDevEx.Formlar.Personel;
using OtelRezervasyonDevEx.Formlar.Rezervasyon;
using OtelRezervasyonDevEx.Formlar.Tanımlamalar;
using OtelRezervasyonDevEx.Formlar.Urun;

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
    }
}

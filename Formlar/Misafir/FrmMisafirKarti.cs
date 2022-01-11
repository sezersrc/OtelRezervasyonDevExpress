using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;
using OtelRezervasyonDevEx.Repositories;

namespace OtelRezervasyonDevEx.Formlar.Misafir
{
    public partial class FrmMisafirKarti : Form
    {
        public FrmMisafirKarti()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            // Ülke Listesi
            lookUpEditUlke.Properties.DataSource = (from x in db.TblUlke
                                                    select new
                                                    {
                                                        x.UlkeID,
                                                        x.UlkeAd
                                                    }).ToList();


            // ŞEhir Listesi
            lookUpEditil.Properties.DataSource = (from x in db.iller
                                                  select new
                                                  {
                                                      Id = x.id,
                                                      Şehir = x.sehir
                                                  }).ToList();

        }

        private void lookUpEditil_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditil.EditValue.ToString());
            lookUpEditilce.Properties.DataSource = (from x in db.ilceler
                                                    select new
                                                    {
                                                        Id = x.id,
                                                        İlçe = x.ilce,
                                                        Şehir = x.sehir
                                                    }).Where(y => y.Şehir == secilen).ToList();
        }

        private string resim1, resim2;

        private void pictureEditKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            resim1 = pictureEditKimlikOn.GetLoadedImageLocation().ToString();
        }

        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            resim2 = pictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Repository<TblMisafir> repo = new Repository<TblMisafir>();
            TblMisafir t = new TblMisafir();
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTcKimlikNo.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtEmail.Text;
            t.Adres = TxtAdres.Text;
            t.Aciklama = txtAciklama.Text;
            t.Durum = 1;
            t.Sehir = lookUpEditil.Text;
            t.ilce = lookUpEditil.Text;
            t.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            t.KimlikFoto1 = resim1;
            t.KimlikFoto2 = resim2;
            repo.TAdd(t);
            XtraMessageBox.Show("Misafir Sisteme Başarılı Bir Şekilde Kaydedildi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

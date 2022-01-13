using System;
using System.Drawing;
using System.Linq;
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
        Repository<TblMisafir> repo = new Repository<TblMisafir>();
        TblMisafir t = new TblMisafir();
        private string resim1, resim2;
        public int id;
        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = id.ToString();
            // Güncellenecek Kart Bilgileri
            if (id != 0)
            {
                var misafir = repo.Find(x => x.MisafirID == id);
                TxtAdSoyad.Text = misafir.AdSoyad;
                TxtTcKimlikNo.Text = misafir.TC;
                TxtAdres.Text = misafir.Adres;
                TxtTelefon.Text = misafir.Telefon;
                TxtEmail.Text = misafir.Mail;
                txtAciklama.Text = misafir.Aciklama;
                pictureEditKimlikOn.Image = Image.FromFile(misafir.KimlikFoto1);
                pictureEditKimlikArka.Image = Image.FromFile(misafir.KimlikFoto2);
                resim1 = misafir.KimlikFoto1;
                resim2 = misafir.KimlikFoto2;
                lookUpEditil.EditValue = misafir.Sehir;
                lookUpEditUlke.EditValue = misafir.Ulke;
                lookUpEditilce.EditValue = misafir.ilce;

            }

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

        

        private void pictureEditKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            resim1 = pictureEditKimlikOn.GetLoadedImageLocation().ToString();
        }

        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            resim2 = pictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.MisafirID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTcKimlikNo.Text;
            deger.Mail = TxtEmail.Text;
            deger.Adres = TxtAdres.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Aciklama = txtAciklama.Text;
            deger.KimlikFoto1 = resim1;
            deger.KimlikFoto2 = resim2;
            deger.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            deger.Sehir = int.Parse(lookUpEditil.EditValue.ToString());
            deger.ilce = int.Parse(lookUpEditilce.EditValue.ToString());
            deger.Durum = 1;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Misafir Başarılı bir şekilde güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTcKimlikNo.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtEmail.Text;
            t.Adres = TxtAdres.Text;
            t.Aciklama = txtAciklama.Text;
            t.Durum = 1;
            t.Sehir = int.Parse(lookUpEditil.EditValue.ToString());
            t.ilce = int.Parse(lookUpEditilce.EditValue.ToString());
            t.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            t.KimlikFoto1 = resim1;
            t.KimlikFoto2 = resim2;
            repo.TAdd(t);
            XtraMessageBox.Show("Misafir Sisteme Başarılı Bir Şekilde Kaydedildi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

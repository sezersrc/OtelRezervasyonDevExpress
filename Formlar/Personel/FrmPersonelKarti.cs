using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;
using OtelRezervasyonDevEx.Repositories;

namespace OtelRezervasyonDevEx.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {
            // Test
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        Repository<TblPersonel> repo = new Repository<TblPersonel>();
        public int id;
      
        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();
            try
            {
                if (id!=0)
                {
                    var personel = repo.Find(x => x.PersonelID == id);
                    TxtAdSoyad.Text = personel.AdSoyad;
                    TxtTcKimlikNo.Text = personel.TC;
                    TxtAdres.Text = personel.Adres;
                    TxtTelefon.Text = personel.Telefon;
                    TxtEmail.Text = personel.Mail;
                    dateEditGiris.Text = personel.IseGirisTarih.ToString();
                    dateEditCikis.Text = personel.IstenCikisTarihi.ToString();
                    txtAciklama.Text = personel.Aciklama;
                    TxtSifre.Text = personel.Sifre;
                    pictureEditKimlikOn.Image = Image.FromFile(personel.KimlikOn);
                    pictureEditKimlikArka.Image = Image.FromFile(personel.KimlikArka);
                    LblConOn.Text = personel.KimlikOn;
                    LblConArka.Text = personel.KimlikArka;
                    lookUpEditDepartman.EditValue = personel.Departman;
                    lookUpEditGorev.EditValue = personel.Gorev;

                }
            }
            catch (Exception )
            {
                XtraMessageBox.Show("Bir Hata Oluştu Lütfen verileri kontrol edin!", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }


            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartman
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd
                                                         }).ToList();

            lookUpEditGorev.Properties.DataSource = (from x in db.TblGorev
                                                     select new
                                                     {
                                                         x.GorevID,
                                                         x.GorevAd
                                                     }).ToList();
        }

        private void pictureEdit14_EditValueChanged(object sender, EventArgs e)
        {
            // Ön Kimlik
            LblConOn.Text = pictureEditKimlikOn.GetLoadedImageLocation().ToString();
        }
        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            LblConArka.Text = pictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            TblPersonel t = new TblPersonel();
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTcKimlikNo.Text;
            t.Adres = TxtAdres.Text;
            t.Telefon = TxtTelefon.Text;
            t.IseGirisTarih = DateTime.Parse(dateEditGiris.Text);
            t.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            t.Aciklama = txtAciklama.Text;
            t.Mail = TxtEmail.Text;
            t.Sifre = TxtSifre.Text;
            t.Durum = 1;
            t.KimlikOn = pictureEditKimlikOn.GetLoadedImageLocation();
            t.KimlikArka = pictureEditKimlikArka.GetLoadedImageLocation();
            repo.TAdd(t);
            XtraMessageBox.Show("Personel Başarılı bir şekilde sisteme kaydedildi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTcKimlikNo.Text;
            deger.Adres = TxtAdres.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.IseGirisTarih = DateTime.Parse(dateEditGiris.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.Aciklama = txtAciklama.Text;
            deger.Mail = TxtEmail.Text;
            deger.Sifre = TxtSifre.Text;
            deger.KimlikOn = LblConOn.Text;
            deger.KimlikArka = LblConArka.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel Başarılı bir şekilde güncellenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

      
    }
}

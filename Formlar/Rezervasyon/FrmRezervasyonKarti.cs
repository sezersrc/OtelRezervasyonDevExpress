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

namespace OtelRezervasyonDevEx.Formlar.Rezervasyon
{
    public partial class FrmRezervasyonKarti : Form
    {
        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        Repository<TblRezervasyon> repo = new Repository<TblRezervasyon>();
        TblRezervasyon t = new TblRezervasyon();
        public int id;
        public FrmRezervasyonKarti()
        {
            InitializeComponent();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            // Test
        }

        private void FrmRezervasyonKarti_Load(object sender, EventArgs e)
        {
            // Ürün Grup  Listesi
            lookUpEditMisafir.Properties.DataSource = (from x in db.TblMisafir
                                                       select new
                                                       {
                                                           x.MisafirID,
                                                           x.AdSoyad
                                                       }).ToList();

            // Ürün Grup  Listesi
            lookUpEditOdaSec.Properties.DataSource = (from x in db.TblOda
                                                      select new
                                                      {
                                                          x.OdaID,
                                                          x.OdaNo,
                                                          x.TblDurum.DurumAd
                                                      }).Where(y => y.DurumAd == "Aktif").ToList();

            // Durum Listesi
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                                                     select new
                                                     {
                                                         x.DurumID,
                                                         x.DurumAd
                                                     }).ToList();

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            t.GirisTarih = DateTime.Parse(dateEditGiris.Text);
            t.CikisTarih = DateTime.Parse(dateEditCikis.Text);
            t.KisiSayisi = numericUpDown1.Value.ToString();
            t.Oda= int.Parse(lookUpEditOdaSec.EditValue.ToString());
            t.RezervasyonAdSoyad = TxtRezAdSoyad.Text;
            t.Telefon = TxtTelefon.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum= int.Parse(lookUpEditDurum.EditValue.ToString());
            repo.TAdd(t);
            XtraMessageBox.Show("Rezervasyon Başarılı bir şekilde oluşturuldu");

        }
    }
}

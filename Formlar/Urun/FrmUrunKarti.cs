using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;
using OtelRezervasyonDevEx.Repositories;

namespace OtelRezervasyonDevEx.Formlar.Urun
{
    public partial class FrmUrunKarti : Form
    {
        public FrmUrunKarti()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        Repository<TblUrun> repo = new Repository<TblUrun>();
        TblUrun t = new TblUrun();
        public int id;
        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            // Test 
        }

        private void FrmUrunKarti_Load(object sender, EventArgs e)
        {
            TxtUrunAd.Text = id.ToString();
            // Ürün Grup  Listesi
            lookUpEditUrunGrup.Properties.DataSource = (from x in db.TblUrunGrup
                select new
                {
                    x.UrunGrupID,
                    x.UrunGruoAd
                }).ToList();
            // Birim Listesi
            lookUpEditBirim.Properties.DataSource = (from x in db.TblBirim
                select new
                {
                    x.BirimID,
                    x.BirimAd
                }).ToList();

            // Durum Listesi
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                select new
                {
                    x.DurumID,
                    x.DurumAd
                }).ToList();

            //Ürün Getir
            if (id != 0)
            {
                // repo değerei globalde 
                var urun = repo.Find(x => x.UrunID == id);
                TxtUrunAd.Text = urun.UrunAd;
                lookUpEditUrunGrup.EditValue = urun.UrunGrup;
                lookUpEditBirim.EditValue = urun.Birim;
                TxtFiyat.Text = urun.Fiyat.ToString();
                TxtToplam.Text = urun.Toplam.ToString();
                TxtKdv.Text = urun.Kdv.ToString();
                lookUpEditDurum.EditValue = urun.Durum;
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.UrunAd = TxtUrunAd.Text;
            t.UrunGrup = int.Parse(lookUpEditUrunGrup.EditValue.ToString());
            t.Birim = int.Parse(lookUpEditBirim.EditValue.ToString());
            t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            t.Fiyat = decimal.Parse(TxtFiyat.Text);
            t.Toplam = decimal.Parse(TxtToplam.Text);
            t.Kdv = byte.Parse(TxtKdv.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün Başarılı bir şekilde eklendi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urundeger = repo.Find(x => x.UrunID == id);
            urundeger.UrunAd = TxtUrunAd.Text;
            urundeger.UrunGrup = int.Parse(lookUpEditUrunGrup.EditValue.ToString());
            urundeger.Birim = int.Parse(lookUpEditBirim.EditValue.ToString());
            urundeger.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            urundeger.Fiyat = decimal.Parse(TxtFiyat.Text);
            urundeger.Toplam = decimal.Parse(TxtToplam.Text);
           urundeger.Kdv = byte.Parse(TxtKdv.Text);
            repo.TUpdate(urundeger);
            XtraMessageBox.Show("Ürün Başarılı bir şekilde güncellendi");
        }

        private void Rdb1_CheckedChanged(object sender, EventArgs e)
        {
            TxtKdv.Text = "1";
        }

        private void Rdb2_CheckedChanged(object sender, EventArgs e)
        {
            TxtKdv.Text = "8";
        }

        private void Rdb3_CheckedChanged(object sender, EventArgs e)
        {
            TxtKdv.Text = "10";
        }

        private void Rdb4_CheckedChanged(object sender, EventArgs e)
        {
            TxtKdv.Text = "18";
        }
    }
}

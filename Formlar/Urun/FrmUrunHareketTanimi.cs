using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;
using OtelRezervasyonDevEx.Repositories;

namespace OtelRezervasyonDevEx.Formlar.Urun
{
    public partial class FrmUrunHareketTanimi : Form
    {
        public FrmUrunHareketTanimi()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private Repository<TblUrunHareket> repo = new Repository<TblUrunHareket>();
        private TblUrunHareket t = new TblUrunHareket();
        public int id;
        private void FrmUrunHareketTanimi_Load(object sender, EventArgs e)
        {
            TxtID.Text = id.ToString();
            TxtID.Enabled = false;
            // Ürün Grup  Listesi
            lookUpEditUrun.Properties.DataSource = (from x in db.TblUrun
                                                    select new
                                                    {
                                                        x.UrunID,
                                                        x.UrunAd
                                                    }).ToList();

            // Verilerin kart alanlarına doldurulması . 
            if (id != 0)
            {
                var urun = repo.Find(x => x.Hareketid == id);
                lookUpEditUrun.EditValue = urun.Urun;
                TxtMiktar.Text = urun.Miktar.ToString();
                TxtAciklama.Text = urun.Aciklama;
                comboBox1.Text = urun.HareketTuru;
                dateEdit1.Text = urun.Tarih.ToString();
            }


        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.Urun = int.Parse(lookUpEditUrun.EditValue.ToString());
            t.Tarih = DateTime.Parse(dateEdit1.Text);
            t.HareketTuru = comboBox1.Text;
            t.Miktar = decimal.Parse(TxtMiktar.Text);
            t.Aciklama = TxtAciklama.Text;
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün Hareketi Sisteme Kaydedildi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = repo.Find(x => x.Hareketid == id);
            urun.Urun = int.Parse(lookUpEditUrun.EditValue.ToString());
            urun.Tarih = DateTime.Parse(dateEdit1.Text);
            urun.HareketTuru = comboBox1.Text;
            urun.Miktar = decimal.Parse(TxtMiktar.Text);
            urun.Aciklama = TxtAciklama.Text;
            repo.TUpdate(urun);
            XtraMessageBox.Show("Ürün Hareketi Güncellendi Kaydedildi");
        }
    }
}

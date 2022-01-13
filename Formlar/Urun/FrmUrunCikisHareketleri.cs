using System;
using System.Linq;
using System.Windows.Forms;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Urun
{
    public partial class FrmUrunCikisHareketleri : Form
    {
        public FrmUrunCikisHareketleri()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmUrunCikisHareketleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblUrunHareket
                select new
                {
                    x.Hareketid,
                    x.TblUrun.UrunAd,
                    x.Miktar,
                    x.Tarih,
                    x.HareketTuru

                }).Where(y => y.HareketTuru == "Çıkış").ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmUrunHareketTanimi fr = new FrmUrunHareketTanimi();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("Hareketid").ToString());
            fr.Show();
        }
    }
}

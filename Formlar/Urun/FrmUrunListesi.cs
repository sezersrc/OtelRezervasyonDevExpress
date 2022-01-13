using System;
using System.Linq;
using System.Windows.Forms;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Urun
{
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();

        
        private void gridControl1_Click(object sender, EventArgs e)
        {
           // Test
        }

        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblUrun
                select new
                {
                    x.UrunID,
                    x.TblUrunGrup.UrunGruoAd,
                    x.UrunAd,
                    x.Fiyat,
                    x.TblBirim.BirimAd,
                    x.Toplam,
                    x.TblDurum.DurumAd
                }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmUrunKarti fr = new FrmUrunKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("UrunID").ToString());
            fr.Show();
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Misafir
{
    public partial class FrmMisafirListesi : Form
    {
        public FrmMisafirListesi()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();

        private void FrmMisafirListesi_Load(object sender, EventArgs e)
        {
            
            gridControl1.DataSource = (from x in db.TblMisafir
                select new
                {
                    x.MisafirID,
                    x.AdSoyad,
                    x.TC,
                    x.Telefon,
                    x.Mail,
                    x.iller.sehir,
                    x.ilceler.ilce
                }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMisafirKarti fr = new FrmMisafirKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("MisafirID").ToString());
            fr.Show();
        }
    }
}

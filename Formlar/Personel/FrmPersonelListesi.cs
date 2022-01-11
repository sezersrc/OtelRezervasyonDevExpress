using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Personel
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblPersonel
                                       select new
                                       {
                                           x.PersonelID,
                                           x.AdSoyad,
                                           x.TC,
                                           x.Mail,
                                           x.Telefon,
                                           x.TblDepartman.DepartmanAd,
                                           x.TblGorev.GorevAd,
                                           x.TblDurum.DurumAd
                                       }).ToList();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmPersonelKarti fr = new FrmPersonelKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("PersonelID").ToString());
            fr.Show();
        }
    }
}

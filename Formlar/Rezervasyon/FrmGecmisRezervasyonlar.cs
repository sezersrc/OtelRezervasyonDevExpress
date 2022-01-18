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

namespace OtelRezervasyonDevEx.Formlar.Rezervasyon
{
    public partial class FrmGecmisRezervasyonlar : Form
    {
        public FrmGecmisRezervasyonlar()
        {
            InitializeComponent();
        }
        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmGecmisRezervasyonlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblRezervasyon
                select new
                {
                    x.RezervasyonID,
                    x.TblMisafir.AdSoyad,
                    x.GirisTarih,
                    x.CikisTarih,
                    x.KisiSayisi,
                    x.TblOda.OdaNo,
                    x.Telefon,
                    x.TblDurum.DurumAd

                }).Where(y => y.DurumAd == "Çıkış Yapıldı").ToList();
        }
    }
}

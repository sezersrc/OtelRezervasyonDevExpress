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

namespace OtelRezervasyonDevEx.Formlar.WebSite
{
    public partial class FrmYeniKayit : Form
    {
        public FrmYeniKayit()
        {
            InitializeComponent();
        }
        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmYeniKayit_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblWebKayit
                                       select new
                                       {
                                           x.AdSoyad,
                                           x.Mail,
                                           x.Telefon

                                       }).ToList();
        }
    }
}

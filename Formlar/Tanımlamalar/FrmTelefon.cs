using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Tanımlamalar
{
    public partial class FrmTelefon : Form
    {
        public FrmTelefon()
        {
            InitializeComponent();
        }
        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmTelefon_Load(object sender, EventArgs e)
        {
            db.TblTelefon.Load();
            bindingSource1.DataSource = db.TblTelefon.Local;

            repositoryItemLookUpEditDurum.DataSource = (from x in
                    db.TblDurum

                select new
                {
                    x.DurumID,
                    x.DurumAd
                }).ToList();

            

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bilgiler girilirken hata oluştu tekrar kontrol ediniz ");
            }
        }
    }
}

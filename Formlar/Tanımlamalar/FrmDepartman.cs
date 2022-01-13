using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Tanımlamalar
{
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            db.TblDepartman.Load();
            bindingSource1.DataSource = db.TblDepartman.Local;

            repositoryItemLookUpEditDurum.DataSource = (from x in
                    db.TblDurum

                select new
                {
                    x.DurumID,
                    x.DurumAd
                }).ToList();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception )
            {
                XtraMessageBox.Show("Bilgiler girilirken hata oluştu tekrar kontrol ediniz ");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            // Test
        }
    }
}

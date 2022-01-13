using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Tanımlamalar
{
    public partial class FrmKur : Form
    {
        public FrmKur()
        {
            InitializeComponent();
        }
        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmKur_Load(object sender, EventArgs e)
        {
            db.TblKur.Load();
            bindingSource1.DataSource = db.TblKur.Local;

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

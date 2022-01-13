using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Tanımlamalar
{
    public partial class FrmOda : Form
    {
        public FrmOda()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmOda_Load(object sender, EventArgs e)
        {
            db.TblOda.Load();
            bindingSource1.DataSource = db.TblOda.Local;

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

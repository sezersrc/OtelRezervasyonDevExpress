using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Tanımlamalar
{
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmBirim_Load(object sender, EventArgs e)
        {

            db.TblBirim.Load();
            bindingSource1.DataSource = db.TblBirim.Local;
            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurum
                select new
                {
                    x.DurumID,
                    x.DurumAd
                }).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //test
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

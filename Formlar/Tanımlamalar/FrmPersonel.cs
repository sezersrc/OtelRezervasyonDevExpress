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
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Formlar.Tanımlamalar
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private DbOtelDevExEntities db = new DbOtelDevExEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            db.TblPersonel.Load();
            bindingSource1.DataSource = db.TblPersonel.Local;

            repositoryItemLookUpEditDurum.DataSource = (from x in
                    db.TblDurum

                select new
                {
                    x.DurumID,
                    x.DurumAd
                }).ToList();

            repositoryItemLookUpEditDepartman1.DataSource = (from x in
                    db.TblDepartman

                select new
                {
                    x.DepartmanID,
                    x.DepartmanAd
                }).ToList();

            repositoryItemLookUpEditGorev.DataSource = (from x in
                    db.TblGorev

                select new
                {
                    x.GorevID,
                    x.GorevAd
                }).ToList();


        }
    }
}

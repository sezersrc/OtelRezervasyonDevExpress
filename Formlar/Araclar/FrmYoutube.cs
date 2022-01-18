using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonDevEx.Formlar.Araclar
{
    public partial class FrmYoutube : Form
    {
        public FrmYoutube()
        {
            InitializeComponent();
        }

        private void FrmYoutube_Load(object sender, EventArgs e)
        {
            // Youtube Düzeltilecek
             webBrowser1.Navigate("http://www.youtube.com");
        }
    }
}

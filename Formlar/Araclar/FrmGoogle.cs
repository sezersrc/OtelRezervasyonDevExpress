﻿using System;
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
    public partial class FrmGoogle : Form
    {
        public FrmGoogle()
        {
            InitializeComponent();
        }

        private void FrmGoogle_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }
    }
}

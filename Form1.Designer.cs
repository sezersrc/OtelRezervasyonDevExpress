
namespace OtelRezervasyonDevEx
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDurumTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBirimTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDepartmanTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGorevTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasaTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKurTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnOdaTanimlari = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.BtnDurumTanimlari,
            this.BtnBirimTanimlari,
            this.barButtonItem2,
            this.BtnDepartmanTanimlari,
            this.BtnGorevTanimlari,
            this.BtnKasaTanimlari,
            this.BtnKurTanimlari,
            this.BtnOdaTanimlari});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 247;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6});
            this.ribbonControl1.Size = new System.Drawing.Size(774, 150);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Müşteri Listesi";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // BtnDurumTanimlari
            // 
            this.BtnDurumTanimlari.Caption = "Durum Tanımları";
            this.BtnDurumTanimlari.Id = 2;
            this.BtnDurumTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDurumTanimlari.ImageOptions.Image")));
            this.BtnDurumTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDurumTanimlari.ImageOptions.LargeImage")));
            this.BtnDurumTanimlari.Name = "BtnDurumTanimlari";
            this.BtnDurumTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // BtnBirimTanimlari
            // 
            this.BtnBirimTanimlari.Caption = "Birim Tanımları";
            this.BtnBirimTanimlari.Id = 3;
            this.BtnBirimTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBirimTanimlari.ImageOptions.Image")));
            this.BtnBirimTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBirimTanimlari.ImageOptions.LargeImage")));
            this.BtnBirimTanimlari.Name = "BtnBirimTanimlari";
            this.BtnBirimTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBirimTanimlari_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // BtnDepartmanTanimlari
            // 
            this.BtnDepartmanTanimlari.Caption = "Departman Tanımları";
            this.BtnDepartmanTanimlari.Id = 5;
            this.BtnDepartmanTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanTanimlari.ImageOptions.Image")));
            this.BtnDepartmanTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanTanimlari.ImageOptions.LargeImage")));
            this.BtnDepartmanTanimlari.Name = "BtnDepartmanTanimlari";
            this.BtnDepartmanTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // BtnGorevTanimlari
            // 
            this.BtnGorevTanimlari.Caption = "Görev Tanımları";
            this.BtnGorevTanimlari.Id = 6;
            this.BtnGorevTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGorevTanimlari.ImageOptions.Image")));
            this.BtnGorevTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGorevTanimlari.ImageOptions.LargeImage")));
            this.BtnGorevTanimlari.Name = "BtnGorevTanimlari";
            this.BtnGorevTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // BtnKasaTanimlari
            // 
            this.BtnKasaTanimlari.Caption = "Kasa Tanımları";
            this.BtnKasaTanimlari.Id = 7;
            this.BtnKasaTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKasaTanimlari.ImageOptions.Image")));
            this.BtnKasaTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKasaTanimlari.ImageOptions.LargeImage")));
            this.BtnKasaTanimlari.Name = "BtnKasaTanimlari";
            this.BtnKasaTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKasaTanimlari_ItemClick);
            // 
            // BtnKurTanimlari
            // 
            this.BtnKurTanimlari.Caption = "Kur Tanımları";
            this.BtnKurTanimlari.Id = 8;
            this.BtnKurTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKurTanimlari.ImageOptions.Image")));
            this.BtnKurTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKurTanimlari.ImageOptions.LargeImage")));
            this.BtnKurTanimlari.Name = "BtnKurTanimlari";
            this.BtnKurTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKurTanimlari_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Form";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Müşteriler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Personel";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Ürünler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Rezervasyonlar";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Tanımlamalar";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnDurumTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnBirimTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnDepartmanTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnGorevTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnKasaTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnKurTanimlari);
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnOdaTanimlari);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // BtnOdaTanimlari
            // 
            this.BtnOdaTanimlari.Caption = "Oda Tanımları";
            this.BtnOdaTanimlari.Id = 9;
            this.BtnOdaTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.BtnOdaTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.BtnOdaTanimlari.Name = "BtnOdaTanimlari";
            this.BtnOdaTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnOdaTanimlari_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 384);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Rezervasyon Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem BtnDurumTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnBirimTanimlari;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem BtnDepartmanTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnGorevTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnKasaTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnKurTanimlari;
        private DevExpress.XtraBars.BarButtonItem BtnOdaTanimlari;
    }
}



namespace OtelRezervasyonDevEx.Formlar.Tanımlamalar
{
    partial class FrmDurum
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durumuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(492, 414);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumuSilToolStripMenuItem,
            this.vazgeçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // durumuSilToolStripMenuItem
            // 
            this.durumuSilToolStripMenuItem.Name = "durumuSilToolStripMenuItem";
            this.durumuSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.durumuSilToolStripMenuItem.Text = "Durumu Sil";
            this.durumuSilToolStripMenuItem.Click += new System.EventHandler(this.durumuSilToolStripMenuItem_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            this.vazgeçToolStripMenuItem.Click += new System.EventHandler(this.vazgeçToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "DurumAd";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 93;
            // 
            // FrmDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 414);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durum Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem durumuSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
    }
}
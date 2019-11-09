namespace QLDSV
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            //this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
      //      this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
           // this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMaUSER = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTenUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            //((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSet
            // 
        //    this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
       //     this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
        //    this.v_DS_PHANMANHBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
          //  this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.Connection = null;
            //this.tableAdapterManager.DIEMTableAdapter = null;
            //this.tableAdapterManager.GIANGVIENTableAdapter = null;
            //this.tableAdapterManager.HOCPHITableAdapter = null;
            //this.tableAdapterManager.KHOATableAdapter = null;
            //this.tableAdapterManager.LOPTableAdapter = null;
            //this.tableAdapterManager.MONHOCTableAdapter = null;
            //this.tableAdapterManager.SINHVIENTableAdapter = null;
         //   this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnLop,
            this.btnMonHoc});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1016, 176);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "LỚP";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "LỚP";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // btnLop
            // 
            this.btnLop.Caption = "LỚP";
            this.btnLop.Id = 5;
            this.btnLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.Image")));
            this.btnLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.LargeImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "MÔN HỌC";
            this.btnMonHoc.Id = 6;
            this.btnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.Image")));
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMaUSER,
            this.toolStripStatusLabelTenUser,
            this.toolStripStatusLabelRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMaUSER
            // 
            this.toolStripStatusLabelMaUSER.Name = "toolStripStatusLabelMaUSER";
            this.toolStripStatusLabelMaUSER.Size = new System.Drawing.Size(24, 20);
            this.toolStripStatusLabelMaUSER.Text = "ID";
            // 
            // toolStripStatusLabelTenUser
            // 
            this.toolStripStatusLabelTenUser.Name = "toolStripStatusLabelTenUser";
            this.toolStripStatusLabelTenUser.Size = new System.Drawing.Size(44, 20);
            this.toolStripStatusLabelTenUser.Text = "USER";
            // 
            // toolStripStatusLabelRole
            // 
            this.toolStripStatusLabelRole.Name = "toolStripStatusLabelRole";
            this.toolStripStatusLabelRole.Size = new System.Drawing.Size(44, 20);
            this.toolStripStatusLabelRole.Text = "ROLE";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
         //   ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
   //     private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
   //     private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
       // private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMaUSER;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTenUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRole;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}
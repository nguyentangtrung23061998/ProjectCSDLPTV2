namespace QLDSV
{
    partial class formDanhSachHocPhiTheoLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDanhSachHocPhiTheoLop));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnManHinh = new System.Windows.Forms.ToolStripButton();
            this.btnMayIn = new System.Windows.Forms.ToolStripButton();
            this.btnThoatMonHoc = new System.Windows.Forms.ToolStripButton();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVPMMaster = new QLDSV.QLDSVPMMaster();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVPMMasterTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVPMMasterTableAdapters.TableAdapterManager();
            this.qLDSVROOT = new QLDSV.QLDSVROOT();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVROOTTableAdapters.LOPTableAdapter();
            this.tableAdapterManager1 = new QLDSV.QLDSVROOTTableAdapters.TableAdapterManager();
            this.hOCPHITableAdapter = new QLDSV.QLDSVROOTTableAdapters.HOCPHITableAdapter();
            this.sINHVIENTableAdapter = new QLDSV.QLDSVROOTTableAdapters.SINHVIENTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNienKhoa = new System.Windows.Forms.ComboBox();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMaLop = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DanhSachHocPhiLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DanhSachHocPhiLopTableAdapter = new QLDSV.QLDSVROOTTableAdapters.SP_DanhSachHocPhiLopTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tdSoTienDaDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_DanhSachHocPhiLopGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVPMMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DanhSachHocPhiLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DanhSachHocPhiLopGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManHinh,
            this.btnMayIn,
            this.btnThoatMonHoc});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(836, 29);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnManHinh
            // 
            this.btnManHinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnManHinh.Image")));
            this.btnManHinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManHinh.Name = "btnManHinh";
            this.btnManHinh.Size = new System.Drawing.Size(133, 26);
            this.btnManHinh.Text = "MÀN HÌNH";
            this.btnManHinh.Click += new System.EventHandler(this.btnManHinh_Click);
            // 
            // btnMayIn
            // 
            this.btnMayIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayIn.Image = ((System.Drawing.Image)(resources.GetObject("btnMayIn.Image")));
            this.btnMayIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMayIn.Name = "btnMayIn";
            this.btnMayIn.Size = new System.Drawing.Size(103, 26);
            this.btnMayIn.Text = "MÁY IN";
            this.btnMayIn.Click += new System.EventHandler(this.btnMayIn_Click);
            // 
            // btnThoatMonHoc
            // 
            this.btnThoatMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatMonHoc.Image")));
            this.btnThoatMonHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoatMonHoc.Name = "btnThoatMonHoc";
            this.btnThoatMonHoc.Size = new System.Drawing.Size(100, 26);
            this.btnThoatMonHoc.Text = "THOÁT";
            this.btnThoatMonHoc.Click += new System.EventHandler(this.btnThoatMonHoc_Click);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLDSVPMMaster;
            // 
            // qLDSVPMMaster
            // 
            this.qLDSVPMMaster.DataSetName = "QLDSVPMMaster";
            this.qLDSVPMMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVPMMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLDSVROOT
            // 
            this.qLDSVROOT.DataSetName = "QLDSVROOT";
            this.qLDSVROOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVROOT;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DIEMTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager1.UpdateOrder = QLDSV.QLDSVROOTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Niên Khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Học Kỳ";
            // 
            // comboNienKhoa
            // 
            this.comboNienKhoa.DataSource = this.hOCPHIBindingSource;
            this.comboNienKhoa.DisplayMember = "NIENKHOA";
            this.comboNienKhoa.FormattingEnabled = true;
            this.comboNienKhoa.Location = new System.Drawing.Point(122, 107);
            this.comboNienKhoa.Name = "comboNienKhoa";
            this.comboNienKhoa.Size = new System.Drawing.Size(153, 24);
            this.comboNienKhoa.TabIndex = 13;
            this.comboNienKhoa.ValueMember = "NIENKHOA";
            this.comboNienKhoa.SelectedIndexChanged += new System.EventHandler(this.comboNienKhoa_SelectedIndexChanged);
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "HOCPHI";
            this.hOCPHIBindingSource.DataSource = this.qLDSVROOT;
            // 
            // comboHocKy
            // 
            this.comboHocKy.FormattingEnabled = true;
            this.comboHocKy.Location = new System.Drawing.Point(370, 107);
            this.comboHocKy.Name = "comboHocKy";
            this.comboHocKy.Size = new System.Drawing.Size(113, 24);
            this.comboHocKy.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Lớp";
            // 
            // comboMaLop
            // 
            this.comboMaLop.DataSource = this.sINHVIENBindingSource;
            this.comboMaLop.DisplayMember = "MALOP";
            this.comboMaLop.FormattingEnabled = true;
            this.comboMaLop.Location = new System.Drawing.Point(122, 64);
            this.comboMaLop.Name = "comboMaLop";
            this.comboMaLop.Size = new System.Drawing.Size(189, 24);
            this.comboMaLop.TabIndex = 8;
            this.comboMaLop.ValueMember = "MALOP";
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVROOT;
            // 
            // sP_DanhSachHocPhiLopBindingSource
            // 
            this.sP_DanhSachHocPhiLopBindingSource.DataMember = "SP_DanhSachHocPhiLop";
            this.sP_DanhSachHocPhiLopBindingSource.DataSource = this.qLDSVROOT;
            // 
            // sP_DanhSachHocPhiLopTableAdapter
            // 
            this.sP_DanhSachHocPhiLopTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colHOTEN,
            this.colHOCPHI,
            this.tdSoTienDaDong});
            this.gridView1.GridControl = this.sP_DanhSachHocPhiLopGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Discontinued", null, "(Discontinued products count={0})", 2)});
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "#";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 0;
            this.colHOTEN.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học Phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 1;
            this.colHOCPHI.Width = 94;
            // 
            // tdSoTienDaDong
            // 
            this.tdSoTienDaDong.Caption = "Số Tiền Đã Đóng";
            this.tdSoTienDaDong.FieldName = "SOTIENDADONG";
            this.tdSoTienDaDong.MinWidth = 25;
            this.tdSoTienDaDong.Name = "tdSoTienDaDong";
            this.tdSoTienDaDong.Visible = true;
            this.tdSoTienDaDong.VisibleIndex = 2;
            this.tdSoTienDaDong.Width = 94;
            // 
            // sP_DanhSachHocPhiLopGridControl
            // 
            this.sP_DanhSachHocPhiLopGridControl.DataSource = this.sP_DanhSachHocPhiLopBindingSource;
            this.sP_DanhSachHocPhiLopGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_DanhSachHocPhiLopGridControl.Location = new System.Drawing.Point(0, 210);
            this.sP_DanhSachHocPhiLopGridControl.MainView = this.gridView1;
            this.sP_DanhSachHocPhiLopGridControl.Name = "sP_DanhSachHocPhiLopGridControl";
            this.sP_DanhSachHocPhiLopGridControl.Size = new System.Drawing.Size(836, 199);
            this.sP_DanhSachHocPhiLopGridControl.TabIndex = 15;
            this.sP_DanhSachHocPhiLopGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // formDanhSachHocPhiTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 409);
            this.Controls.Add(this.sP_DanhSachHocPhiLopGridControl);
            this.Controls.Add(this.comboHocKy);
            this.Controls.Add(this.comboNienKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "formDanhSachHocPhiTheoLop";
            this.Text = "formDanhSachHocPhiTheoLop";
            this.Load += new System.EventHandler(this.formDanhSachHocPhiTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVPMMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DanhSachHocPhiLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DanhSachHocPhiLopGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnManHinh;
        private System.Windows.Forms.ToolStripButton btnMayIn;
        private System.Windows.Forms.ToolStripButton btnThoatMonHoc;
        private QLDSVPMMaster qLDSVPMMaster;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLDSVPMMasterTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVPMMasterTableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSVROOT qLDSVROOT;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVROOTTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVROOTTableAdapters.TableAdapterManager tableAdapterManager1;
        private QLDSVROOTTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboNienKhoa;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private System.Windows.Forms.ComboBox comboHocKy;
        private QLDSVROOTTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMaLop;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.BindingSource sP_DanhSachHocPhiLopBindingSource;
        private QLDSVROOTTableAdapters.SP_DanhSachHocPhiLopTableAdapter sP_DanhSachHocPhiLopTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn tdSoTienDaDong;
        private DevExpress.XtraGrid.GridControl sP_DanhSachHocPhiLopGridControl;
    }
}
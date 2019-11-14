namespace QLDSV
{
    partial class formLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLop));
            this.frmLop = new DevExpress.XtraGrid.GridControl();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVROOT = new QLDSV.QLDSVROOT();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKHOA = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVPMMaster = new QLDSV.QLDSVPMMaster();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSPLenh = new System.Windows.Forms.TextBox();
            this.btnLopThem = new System.Windows.Forms.ToolStripButton();
            this.btnLopXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLopSua = new System.Windows.Forms.ToolStripButton();
            this.btnLopPhucHoi = new System.Windows.Forms.ToolStripButton();
            this.btnLopRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnLopThoat = new System.Windows.Forms.ToolStripButton();
            this.btnLopClear = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVPMMasterTableAdapters.V_DS_PHANMANHTableAdapter();
            this.lOPTableAdapter = new QLDSV.QLDSVROOTTableAdapters.LOPTableAdapter();
            this.v_DS_PHANMANHTableAdapter1 = new QLDSV.QLDSVROOTTableAdapters.V_DS_PHANMANHTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new QLDSV.QLDSVROOTTableAdapters.TableAdapterManager();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frmLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVPMMaster)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(44, 28);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(83, 22);
            mALOPLabel.TabIndex = 9;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(44, 69);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(90, 22);
            tENLOPLabel.TabIndex = 11;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(44, 105);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(75, 22);
            mAKHLabel.TabIndex = 13;
            mAKHLabel.Text = "MAKH:";
            // 
            // frmLop
            // 
            this.frmLop.DataSource = this.lOPBindingSource;
            this.frmLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLop.Location = new System.Drawing.Point(0, 109);
            this.frmLop.MainView = this.gridView1;
            this.frmLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmLop.Name = "frmLop";
            this.frmLop.Size = new System.Drawing.Size(955, 199);
            this.frmLop.TabIndex = 4;
            this.frmLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVROOT;
            // 
            // qLDSVROOT
            // 
            this.qLDSVROOT.DataSetName = "QLDSVROOT";
            this.qLDSVROOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.frmLop;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 24;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 24;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 24;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // comboKHOA
            // 
            this.comboKHOA.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vDSPHANMANHBindingSource1, "TENCN", true));
            this.comboKHOA.DataSource = this.vDSPHANMANHBindingSource;
            this.comboKHOA.DisplayMember = "TENCN";
            this.comboKHOA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKHOA.FormattingEnabled = true;
            this.comboKHOA.Location = new System.Drawing.Point(147, 28);
            this.comboKHOA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboKHOA.Name = "comboKHOA";
            this.comboKHOA.Size = new System.Drawing.Size(214, 27);
            this.comboKHOA.TabIndex = 1;
            this.comboKHOA.ValueMember = "TENSERVER";
            this.comboKHOA.SelectedIndexChanged += new System.EventHandler(this.comboKHOA_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource1
            // 
            this.vDSPHANMANHBindingSource1.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource1.DataSource = this.qLDSVROOT;
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qLDSVPMMaster;
            // 
            // qLDSVPMMaster
            // 
            this.qLDSVPMMaster.DataSetName = "QLDSVPMMaster";
            this.qLDSVPMMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(289, 30);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(8, 7);
            this.bunifuCards1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Controls.Add(this.comboKHOA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 80);
            this.panel1.TabIndex = 1;
            // 
            // txtSPLenh
            // 
            this.txtSPLenh.Location = new System.Drawing.Point(436, 32);
            this.txtSPLenh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSPLenh.Name = "txtSPLenh";
            this.txtSPLenh.Size = new System.Drawing.Size(433, 23);
            this.txtSPLenh.TabIndex = 3;
            // 
            // btnLopThem
            // 
            this.btnLopThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopThem.Image = ((System.Drawing.Image)(resources.GetObject("btnLopThem.Image")));
            this.btnLopThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopThem.Name = "btnLopThem";
            this.btnLopThem.Size = new System.Drawing.Size(89, 26);
            this.btnLopThem.Text = "THÊM";
            this.btnLopThem.Click += new System.EventHandler(this.btnLopThem_Click);
            // 
            // btnLopXoa
            // 
            this.btnLopXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnLopXoa.Image")));
            this.btnLopXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopXoa.Name = "btnLopXoa";
            this.btnLopXoa.Size = new System.Drawing.Size(76, 26);
            this.btnLopXoa.Text = "XÓA";
            this.btnLopXoa.Click += new System.EventHandler(this.btnLopXoa_Click);
            // 
            // btnLopSua
            // 
            this.btnLopSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopSua.Image = ((System.Drawing.Image)(resources.GetObject("btnLopSua.Image")));
            this.btnLopSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopSua.Name = "btnLopSua";
            this.btnLopSua.Size = new System.Drawing.Size(75, 26);
            this.btnLopSua.Text = "SỬA";
            this.btnLopSua.Click += new System.EventHandler(this.btnLopSua_Click);
            // 
            // btnLopPhucHoi
            // 
            this.btnLopPhucHoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopPhucHoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLopPhucHoi.Image")));
            this.btnLopPhucHoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopPhucHoi.Name = "btnLopPhucHoi";
            this.btnLopPhucHoi.Size = new System.Drawing.Size(124, 26);
            this.btnLopPhucHoi.Text = "PHỤC HỒI";
            this.btnLopPhucHoi.Click += new System.EventHandler(this.btnLopPhucHoi_Click);
            // 
            // btnLopRefresh
            // 
            this.btnLopRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnLopRefresh.Image")));
            this.btnLopRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopRefresh.Name = "btnLopRefresh";
            this.btnLopRefresh.Size = new System.Drawing.Size(120, 26);
            this.btnLopRefresh.Text = "REFRESH";
            this.btnLopRefresh.Click += new System.EventHandler(this.btnLopRefresh_Click);
            // 
            // btnLopThoat
            // 
            this.btnLopThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnLopThoat.Image")));
            this.btnLopThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopThoat.Name = "btnLopThoat";
            this.btnLopThoat.Size = new System.Drawing.Size(100, 26);
            this.btnLopThoat.Text = "THOÁT";
            this.btnLopThoat.Click += new System.EventHandler(this.btnLopThoat_Click);
            // 
            // btnLopClear
            // 
            this.btnLopClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopClear.Image = ((System.Drawing.Image)(resources.GetObject("btnLopClear.Image")));
            this.btnLopClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopClear.Name = "btnLopClear";
            this.btnLopClear.Size = new System.Drawing.Size(97, 26);
            this.btnLopClear.Text = "CLEAR";
            this.btnLopClear.Click += new System.EventHandler(this.btnLopClear_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLopThem,
            this.btnLopXoa,
            this.btnLopSua,
            this.btnLopPhucHoi,
            this.btnLopRefresh,
            this.btnLopThoat,
            this.btnLopClear});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(955, 29);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_PHANMANHTableAdapter1
            // 
            this.v_DS_PHANMANHTableAdapter1.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(mALOPLabel);
            this.panelControl1.Controls.Add(this.txtMaLop);
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.txtTenLop);
            this.panelControl1.Controls.Add(mAKHLabel);
            this.panelControl1.Controls.Add(this.txtMaKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 308);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(955, 197);
            this.panelControl1.TabIndex = 5;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(128, 20);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(117, 28);
            this.txtMaLop.TabIndex = 10;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(128, 60);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(233, 28);
            this.txtTenLop.TabIndex = 12;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(128, 105);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(117, 28);
            this.txtMaKhoa.TabIndex = 14;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVROOTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formLop
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.frmLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formLop";
            this.Text = "formLop";
            this.Load += new System.EventHandler(this.formLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVPMMaster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl frmLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKHOA;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnLopThem;
        private System.Windows.Forms.ToolStripButton btnLopXoa;
        private System.Windows.Forms.ToolStripButton btnLopSua;
        private System.Windows.Forms.ToolStripButton btnLopPhucHoi;
        private System.Windows.Forms.ToolStripButton btnLopRefresh;
        private System.Windows.Forms.ToolStripButton btnLopThoat;
        private System.Windows.Forms.ToolStripButton btnLopClear;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private QLDSVPMMaster qLDSVPMMaster;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVPMMasterTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVROOT qLDSVROOT;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVROOTTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource1;
        private QLDSVROOTTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private QLDSVROOTTableAdapters.TableAdapterManager tableAdapterManager;
        // private QLDSV.QLDSVTableAdapters.LOPTableAdapter lOPTableAdapter;
        //private QLDSV.QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        // private QLDSV.QLDSVTableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}
namespace QLDSV
{
    partial class formHocPhi
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
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label sOTIENDADONGLabel;
            System.Windows.Forms.Label hOCKYLabel1;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHocPhi));
            this.qLDSVROOT = new QLDSV.QLDSVROOT();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.comboKHOA = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVPMMaster = new QLDSV.QLDSVPMMaster();
            this.label1 = new System.Windows.Forms.Label();
            this.hOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.sPDongHocPhiSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnNhapSV = new System.Windows.Forms.Button();
            this.lbMALOP = new System.Windows.Forms.Label();
            this.lbHOTEN = new System.Windows.Forms.Label();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.pnclHocPhi = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtHocPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.sP_DongHocPhiSinhVienTableAdapter = new QLDSV.QLDSVROOTTableAdapters.SP_DongHocPhiSinhVienTableAdapter();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVPMMasterTableAdapters.V_DS_PHANMANHTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            sOTIENDADONGLabel = new System.Windows.Forms.Label();
            hOCKYLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVPMMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDongHocPhiSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnclHocPhi)).BeginInit();
            this.pnclHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(102, 92);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 19);
            mALOPLabel.TabIndex = 14;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(102, 57);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(71, 19);
            hOTENLabel.TabIndex = 13;
            hOTENLabel.Text = "Họ và tên:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(102, 22);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(56, 19);
            mASVLabel.TabIndex = 12;
            mASVLabel.Text = "Mã SV:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(59, 22);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(146, 19);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "Niên khóa:(VD: 2019)\r\n";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(101, 57);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(108, 19);
            hOCKYLabel.TabIndex = 4;
            hOCKYLabel.Text = "Học phí (VND):";
            // 
            // sOTIENDADONGLabel
            // 
            sOTIENDADONGLabel.AutoSize = true;
            sOTIENDADONGLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENDADONGLabel.Location = new System.Drawing.Point(50, 92);
            sOTIENDADONGLabel.Name = "sOTIENDADONGLabel";
            sOTIENDADONGLabel.Size = new System.Drawing.Size(155, 19);
            sOTIENDADONGLabel.TabIndex = 8;
            sOTIENDADONGLabel.Text = "Số tiền đã đóng (VND):";
            // 
            // hOCKYLabel1
            // 
            hOCKYLabel1.AutoSize = true;
            hOCKYLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel1.Location = new System.Drawing.Point(358, 25);
            hOCKYLabel1.Name = "hOCKYLabel1";
            hOCKYLabel1.Size = new System.Drawing.Size(57, 19);
            hOCKYLabel1.TabIndex = 9;
            hOCKYLabel1.Text = "Học kỳ:";
            // 
            // qLDSVROOT
            // 
            this.qLDSVROOT.DataSetName = "QLDSVROOT";
            this.qLDSVROOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Controls.Add(this.comboKHOA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 57);
            this.panel1.TabIndex = 4;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(248, 24);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(7, 6);
            this.bunifuCards1.TabIndex = 2;
            // 
            // comboKHOA
            // 
            this.comboKHOA.DataSource = this.vDSPHANMANHBindingSource;
            this.comboKHOA.DisplayMember = "TENCN";
            this.comboKHOA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKHOA.FormattingEnabled = true;
            this.comboKHOA.Location = new System.Drawing.Point(105, 13);
            this.comboKHOA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboKHOA.Name = "comboKHOA";
            this.comboKHOA.Size = new System.Drawing.Size(216, 27);
            this.comboKHOA.TabIndex = 1;
            this.comboKHOA.ValueMember = "TENSERVER";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // hOCPHIGridControl
            // 
            this.hOCPHIGridControl.DataSource = this.sPDongHocPhiSinhVienBindingSource;
            this.hOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.RelationName = "Level1";
            this.hOCPHIGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.hOCPHIGridControl.Location = new System.Drawing.Point(0, 330);
            this.hOCPHIGridControl.MainView = this.gridView1;
            this.hOCPHIGridControl.Name = "hOCPHIGridControl";
            this.hOCPHIGridControl.Size = new System.Drawing.Size(1057, 197);
            this.hOCPHIGridControl.TabIndex = 4;
            this.hOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sPDongHocPhiSinhVienBindingSource
            // 
            this.sPDongHocPhiSinhVienBindingSource.DataMember = "SP_DongHocPhiSinhVien";
            this.sPDongHocPhiSinhVienBindingSource.DataSource = this.qLDSVROOT;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gridView1.GridControl = this.hOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSOTIENDADONG, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học phí (VND)";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.Caption = "Số tiền đã đóng (VND)";
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnNhapSV);
            this.panelControl1.Controls.Add(this.lbMALOP);
            this.panelControl1.Controls.Add(this.lbHOTEN);
            this.panelControl1.Controls.Add(this.txtMASV);
            this.panelControl1.Controls.Add(mALOPLabel);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(mASVLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 85);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(444, 245);
            this.panelControl1.TabIndex = 5;
            // 
            // btnNhapSV
            // 
            this.btnNhapSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSV.Location = new System.Drawing.Point(122, 138);
            this.btnNhapSV.Name = "btnNhapSV";
            this.btnNhapSV.Size = new System.Drawing.Size(133, 30);
            this.btnNhapSV.TabIndex = 18;
            this.btnNhapSV.Text = "Nhâp lại MASV";
            this.btnNhapSV.UseVisualStyleBackColor = true;
            this.btnNhapSV.Click += new System.EventHandler(this.BtnNhapSV_Click);
            // 
            // lbMALOP
            // 
            this.lbMALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMALOP.Location = new System.Drawing.Point(174, 92);
            this.lbMALOP.Name = "lbMALOP";
            this.lbMALOP.Size = new System.Drawing.Size(100, 23);
            this.lbMALOP.TabIndex = 17;
            // 
            // lbHOTEN
            // 
            this.lbHOTEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHOTEN.Location = new System.Drawing.Point(174, 57);
            this.lbHOTEN.Name = "lbHOTEN";
            this.lbHOTEN.Size = new System.Drawing.Size(100, 23);
            this.lbHOTEN.TabIndex = 16;
            // 
            // txtMASV
            // 
            this.txtMASV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASV.Location = new System.Drawing.Point(174, 19);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(147, 26);
            this.txtMASV.TabIndex = 15;
            // 
            // pnclHocPhi
            // 
            this.pnclHocPhi.Controls.Add(this.btnClear);
            this.pnclHocPhi.Controls.Add(this.txtHocPhi);
            this.pnclHocPhi.Controls.Add(this.txtSoTien);
            this.pnclHocPhi.Controls.Add(hOCKYLabel1);
            this.pnclHocPhi.Controls.Add(this.cmbHocKy);
            this.pnclHocPhi.Controls.Add(nIENKHOALabel);
            this.pnclHocPhi.Controls.Add(this.txtNienKhoa);
            this.pnclHocPhi.Controls.Add(hOCKYLabel);
            this.pnclHocPhi.Controls.Add(sOTIENDADONGLabel);
            this.pnclHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnclHocPhi.Location = new System.Drawing.Point(444, 85);
            this.pnclHocPhi.Name = "pnclHocPhi";
            this.pnclHocPhi.Size = new System.Drawing.Size(613, 245);
            this.pnclHocPhi.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(277, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 30);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sPDongHocPhiSinhVienBindingSource, "HOCPHI", true));
            this.txtHocPhi.Location = new System.Drawing.Point(211, 54);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhi.Properties.Appearance.Options.UseFont = true;
            this.txtHocPhi.Size = new System.Drawing.Size(121, 26);
            this.txtHocPhi.TabIndex = 12;
            // 
            // txtSoTien
            // 
            this.txtSoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sPDongHocPhiSinhVienBindingSource, "SOTIENDADONG", true));
            this.txtSoTien.Location = new System.Drawing.Point(211, 89);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Size = new System.Drawing.Size(121, 26);
            this.txtSoTien.TabIndex = 11;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPDongHocPhiSinhVienBindingSource, "HOCKY", true));
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(421, 22);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 27);
            this.cmbHocKy.TabIndex = 10;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sPDongHocPhiSinhVienBindingSource, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(211, 19);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtNienKhoa.Size = new System.Drawing.Size(121, 26);
            this.txtNienKhoa.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(65, 25);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(61, 25);
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.BtnGhi_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad,
            this.btnGhi,
            this.btnThoat});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1057, 28);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 25);
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // sP_DongHocPhiSinhVienTableAdapter
            // 
            this.sP_DongHocPhiSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // formHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 527);
            this.Controls.Add(this.pnclHocPhi);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.hOCPHIGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "formHocPhi";
            this.Text = "formHocPhi";
            this.Load += new System.EventHandler(this.FormHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVPMMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDongHocPhiSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnclHocPhi)).EndInit();
            this.pnclHocPhi.ResumeLayout(false);
            this.pnclHocPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDSVROOT qLDSVROOT;
       // private QLDSVROOTTableAdapters.info_SINHVIENTableAdapter info_SINHVIENTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.ComboBox comboKHOA;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl hOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pnclHocPhi;
        private System.Windows.Forms.Label lbMALOP;
        private System.Windows.Forms.Label lbHOTEN;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnGhi;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.BindingSource sPDongHocPhiSinhVienBindingSource;
        private QLDSVROOTTableAdapters.SP_DongHocPhiSinhVienTableAdapter sP_DongHocPhiSinhVienTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private DevExpress.XtraEditors.TextEdit txtHocPhi;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private System.Windows.Forms.Button btnNhapSV;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private QLDSVPMMaster qLDSVPMMaster;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVPMMasterTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}
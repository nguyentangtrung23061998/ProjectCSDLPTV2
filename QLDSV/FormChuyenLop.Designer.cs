namespace QLDSV
{
    partial class formChuyenLop
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nOISINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGHIHOCLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel2;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.cbPhai = new DevExpress.XtraEditors.CheckEdit();
            this.comboNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtNoiSinh = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.cbNghiHoc = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.comboMaLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVROOT = new QLDSV.QLDSVROOT();
            this.btnChuyenLop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMaSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lOPTableAdapter = new QLDSV.QLDSVROOTTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVROOTTableAdapters.TableAdapterManager();
            mALOPLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nOISINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGHIHOCLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNghiHoc.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(36, 127);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 40;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(41, 36);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 24;
            mASVLabel.Text = "Mã SV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(58, 58);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(23, 13);
            hOLabel.TabIndex = 26;
            hOLabel.Text = "Họ ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(52, 81);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 28;
            tENLabel.Text = "Tên:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(50, 104);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(31, 13);
            pHAILabel.TabIndex = 30;
            pHAILabel.Text = "Phái:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(229, 36);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(61, 13);
            nGAYSINHLabel.TabIndex = 32;
            nGAYSINHLabel.Text = "Ngày sinh: ";
            // 
            // nOISINHLabel
            // 
            nOISINHLabel.AutoSize = true;
            nOISINHLabel.Location = new System.Drawing.Point(239, 58);
            nOISINHLabel.Name = "nOISINHLabel";
            nOISINHLabel.Size = new System.Drawing.Size(51, 13);
            nOISINHLabel.TabIndex = 34;
            nOISINHLabel.Text = "Nơi sinh: ";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(244, 81);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(46, 13);
            dIACHILabel.TabIndex = 36;
            dIACHILabel.Text = "Địa chỉ: ";
            // 
            // nGHIHOCLabel
            // 
            nGHIHOCLabel.AutoSize = true;
            nGHIHOCLabel.Location = new System.Drawing.Point(235, 104);
            nGHIHOCLabel.Name = "nGHIHOCLabel";
            nGHIHOCLabel.Size = new System.Drawing.Size(55, 13);
            nGHIHOCLabel.TabIndex = 38;
            nGHIHOCLabel.Text = "Nghỉ học: ";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(16, 47);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(45, 13);
            tENLOPLabel.TabIndex = 38;
            tENLOPLabel.Text = "Mã lớp: ";
            // 
            // mALOPLabel2
            // 
            mALOPLabel2.AutoSize = true;
            mALOPLabel2.Location = new System.Drawing.Point(265, 48);
            mALOPLabel2.Name = "mALOPLabel2";
            mALOPLabel2.Size = new System.Drawing.Size(38, 13);
            mALOPLabel2.TabIndex = 37;
            mALOPLabel2.Text = "Mã lớp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 229);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(mALOPLabel);
            this.tabPage1.Controls.Add(this.txtMaLop);
            this.tabPage1.Controls.Add(mASVLabel);
            this.tabPage1.Controls.Add(this.txtMaSV);
            this.tabPage1.Controls.Add(hOLabel);
            this.tabPage1.Controls.Add(this.txtHo);
            this.tabPage1.Controls.Add(tENLabel);
            this.tabPage1.Controls.Add(this.txtTen);
            this.tabPage1.Controls.Add(pHAILabel);
            this.tabPage1.Controls.Add(this.cbPhai);
            this.tabPage1.Controls.Add(nGAYSINHLabel);
            this.tabPage1.Controls.Add(this.comboNgaySinh);
            this.tabPage1.Controls.Add(nOISINHLabel);
            this.tabPage1.Controls.Add(this.txtNoiSinh);
            this.tabPage1.Controls.Add(dIACHILabel);
            this.tabPage1.Controls.Add(this.txtDiaChi);
            this.tabPage1.Controls.Add(nGHIHOCLabel);
            this.tabPage1.Controls.Add(this.cbNghiHoc);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(451, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "THÔNG TIN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(87, 124);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaLop.Size = new System.Drawing.Size(107, 22);
            this.txtMaLop.TabIndex = 41;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(87, 33);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtMaSV.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaSV.Size = new System.Drawing.Size(107, 22);
            this.txtMaSV.TabIndex = 25;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(87, 56);
            this.txtHo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtHo.Properties.Appearance.Options.UseBackColor = true;
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Properties.Appearance.Options.UseForeColor = true;
            this.txtHo.Size = new System.Drawing.Size(107, 22);
            this.txtHo.TabIndex = 27;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(87, 79);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTen.Properties.Appearance.Options.UseBackColor = true;
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Properties.Appearance.Options.UseForeColor = true;
            this.txtTen.Size = new System.Drawing.Size(107, 22);
            this.txtTen.TabIndex = 29;
            // 
            // cbPhai
            // 
            this.cbPhai.Location = new System.Drawing.Point(87, 101);
            this.cbPhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPhai.Name = "cbPhai";
            this.cbPhai.Properties.Caption = "(✔ Nam, ☐ Nữ) ";
            this.cbPhai.Size = new System.Drawing.Size(107, 19);
            this.cbPhai.TabIndex = 31;
            // 
            // comboNgaySinh
            // 
            this.comboNgaySinh.EditValue = null;
            this.comboNgaySinh.Location = new System.Drawing.Point(296, 33);
            this.comboNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboNgaySinh.Name = "comboNgaySinh";
            this.comboNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNgaySinh.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.comboNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.comboNgaySinh.Properties.Appearance.Options.UseForeColor = true;
            this.comboNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboNgaySinh.Size = new System.Drawing.Size(107, 22);
            this.comboNgaySinh.TabIndex = 33;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(296, 56);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiSinh.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNoiSinh.Properties.Appearance.Options.UseFont = true;
            this.txtNoiSinh.Properties.Appearance.Options.UseForeColor = true;
            this.txtNoiSinh.Size = new System.Drawing.Size(107, 22);
            this.txtNoiSinh.TabIndex = 35;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(296, 79);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.Appearance.Options.UseForeColor = true;
            this.txtDiaChi.Size = new System.Drawing.Size(107, 22);
            this.txtDiaChi.TabIndex = 37;
            // 
            // cbNghiHoc
            // 
            this.cbNghiHoc.Location = new System.Drawing.Point(296, 104);
            this.cbNghiHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNghiHoc.Name = "cbNghiHoc";
            this.cbNghiHoc.Properties.Caption = "";
            this.cbNghiHoc.Size = new System.Drawing.Size(107, 19);
            this.cbNghiHoc.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(tENLOPLabel);
            this.tabPage2.Controls.Add(this.txtTL);
            this.tabPage2.Controls.Add(mALOPLabel2);
            this.tabPage2.Controls.Add(this.comboMaLop);
            this.tabPage2.Controls.Add(this.btnChuyenLop);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(451, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CHUYỂN LỚP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(67, 45);
            this.txtTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(86, 21);
            this.txtTL.TabIndex = 39;
            // 
            // comboMaLop
            // 
            this.comboMaLop.DataSource = this.lOPBindingSource;
            this.comboMaLop.DisplayMember = "MALOP";
            this.comboMaLop.FormattingEnabled = true;
            this.comboMaLop.Location = new System.Drawing.Point(316, 44);
            this.comboMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboMaLop.Name = "comboMaLop";
            this.comboMaLop.Size = new System.Drawing.Size(104, 21);
            this.comboMaLop.TabIndex = 38;
            this.comboMaLop.ValueMember = "MALOP";
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
            // btnChuyenLop
            // 
            this.btnChuyenLop.BackColor = System.Drawing.Color.DarkGray;
            this.btnChuyenLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenLop.Location = new System.Drawing.Point(142, 100);
            this.btnChuyenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(145, 28);
            this.btnChuyenLop.TabIndex = 37;
            this.btnChuyenLop.Text = "Chuyển Lớp";
            this.btnChuyenLop.UseVisualStyleBackColor = false;
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "CHUYỂN";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMaSV,
            this.toolStripStatusHoTen});
            this.statusStrip1.Location = new System.Drawing.Point(3, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(445, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusMaSV
            // 
            this.toolStripStatusMaSV.Name = "toolStripStatusMaSV";
            this.toolStripStatusMaSV.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusMaSV.Text = "Mã SV: ";
            // 
            // toolStripStatusHoTen
            // 
            this.toolStripStatusHoTen.Name = "toolStripStatusHoTen";
            this.toolStripStatusHoTen.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusHoTen.Text = "Họ tên: ";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
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
            // formChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 229);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formChuyenLop";
            this.Text = "Chuyển lớp";
            this.Load += new System.EventHandler(this.formChuyenLop_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNghiHoc.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.CheckEdit cbPhai;
        private DevExpress.XtraEditors.DateEdit comboNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtNoiSinh;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.CheckEdit cbNghiHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.ComboBox comboMaLop;
        private System.Windows.Forms.Button btnChuyenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMaSV;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHoTen;
        private QLDSVROOT qLDSVROOT;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVROOTTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVROOTTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
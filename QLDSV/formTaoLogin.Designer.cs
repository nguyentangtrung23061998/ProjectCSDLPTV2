namespace QLDSV
{
    partial class formTaoLogin
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
            this.qLDSVROOT = new QLDSV.QLDSVROOT();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QLDSV.QLDSVROOTTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVROOTTableAdapters.TableAdapterManager();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panelCN = new System.Windows.Forms.Panel();
            this.comboBoxQuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxtenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panelCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVROOT
            // 
            this.qLDSVROOT.DataSetName = "QLDSVROOT";
            this.qLDSVROOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qLDSVROOT;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVROOTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.DataSource = this.gIANGVIENBindingSource;
            this.gIANGVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.gIANGVIENGridControl.MainView = this.gridView1;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(910, 231);
            this.gIANGVIENGridControl.TabIndex = 1;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colMAKH});
            this.gridView1.GridControl = this.gIANGVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 3;
            this.colMAKH.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.buttonReload);
            this.panelControl1.Controls.Add(this.buttonThoat);
            this.panelControl1.Controls.Add(this.buttonOk);
            this.panelControl1.Controls.Add(this.panelCN);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.textBoxtenDangNhap);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtMatKhau);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtMaGV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 231);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(910, 238);
            this.panelControl1.TabIndex = 2;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(594, 163);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(138, 37);
            this.buttonReload.TabIndex = 22;
            this.buttonReload.Text = "RELOAD";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(742, 163);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(138, 37);
            this.buttonThoat.TabIndex = 21;
            this.buttonThoat.Text = "THOÁT";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(424, 163);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(138, 37);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panelCN
            // 
            this.panelCN.Controls.Add(this.comboBoxQuyen);
            this.panelCN.Controls.Add(this.label4);
            this.panelCN.Location = new System.Drawing.Point(478, 32);
            this.panelCN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCN.Name = "panelCN";
            this.panelCN.Size = new System.Drawing.Size(324, 89);
            this.panelCN.TabIndex = 19;
            // 
            // comboBoxQuyen
            // 
            this.comboBoxQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuyen.FormattingEnabled = true;
            this.comboBoxQuyen.Items.AddRange(new object[] {
            "PGV",
            "KHOA",
            "KETOAN"});
            this.comboBoxQuyen.Location = new System.Drawing.Point(98, 28);
            this.comboBoxQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxQuyen.Name = "comboBoxQuyen";
            this.comboBoxQuyen.Size = new System.Drawing.Size(187, 24);
            this.comboBoxQuyen.TabIndex = 9;
            this.comboBoxQuyen.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuyen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // textBoxtenDangNhap
            // 
            this.textBoxtenDangNhap.Location = new System.Drawing.Point(177, 173);
            this.textBoxtenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxtenDangNhap.Name = "textBoxtenDangNhap";
            this.textBoxtenDangNhap.Size = new System.Drawing.Size(202, 23);
            this.textBoxtenDangNhap.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(177, 98);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(202, 23);
            this.txtMatKhau.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Giảng Viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.EditValue = "";
            this.txtMaGV.Location = new System.Drawing.Point(177, 32);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtMaGV.Size = new System.Drawing.Size(203, 22);
            this.txtMaGV.TabIndex = 18;
            // 
            // formTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 469);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gIANGVIENGridControl);
            this.Name = "formTaoLogin";
            this.Text = "formTaoLogin";
            this.Load += new System.EventHandler(this.formTaoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panelCN.ResumeLayout(false);
            this.panelCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVROOT qLDSVROOT;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QLDSVROOTTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private QLDSVROOTTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelCN;
        private System.Windows.Forms.ComboBox comboBoxQuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxtenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
    }
}
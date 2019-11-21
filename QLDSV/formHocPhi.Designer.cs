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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mALOPLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.qLDSVROOT = new QLDSV.QLDSVROOT();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHITableAdapter = new QLDSV.QLDSVROOTTableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVROOTTableAdapters.TableAdapterManager();
            this.hOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.QLDSVROOTTableAdapters.SINHVIENTableAdapter();
            this.mASVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(mALOPLabel);
            this.panelControl1.Controls.Add(this.mALOPTextEdit);
            this.panelControl1.Controls.Add(hOLabel);
            this.panelControl1.Controls.Add(this.hOTextEdit);
            this.panelControl1.Controls.Add(mASVLabel);
            this.panelControl1.Controls.Add(this.mASVTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(697, 73);
            this.panelControl1.TabIndex = 0;
            // 
            // qLDSVROOT
            // 
            this.qLDSVROOT.DataSetName = "QLDSVROOT";
            this.qLDSVROOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "HOCPHI";
            this.hOCPHIBindingSource.DataSource = this.qLDSVROOT;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVROOTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHIGridControl
            // 
            this.hOCPHIGridControl.DataSource = this.hOCPHIBindingSource;
            this.hOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hOCPHIGridControl.Location = new System.Drawing.Point(0, 73);
            this.hOCPHIGridControl.MainView = this.gridView1;
            this.hOCPHIGridControl.Name = "hOCPHIGridControl";
            this.hOCPHIGridControl.Size = new System.Drawing.Size(697, 220);
            this.hOCPHIGridControl.TabIndex = 2;
            this.hOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHOCKY,
            this.colHOCPHI,
            this.colNIENKHOA,
            this.colSOTIENDADONG});
            this.gridView1.GridControl = this.hOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNIENKHOA, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVROOT;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(37, 25);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(38, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // mASVTextEdit
            // 
            this.mASVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "MASV", true));
            this.mASVTextEdit.Location = new System.Drawing.Point(81, 22);
            this.mASVTextEdit.Name = "mASVTextEdit";
            this.mASVTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mASVTextEdit.TabIndex = 1;
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(228, 25);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(260, 22);
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hOTextEdit.TabIndex = 3;
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(412, 26);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "MALOP:";
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "MALOP", true));
            this.mALOPTextEdit.Location = new System.Drawing.Point(463, 23);
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mALOPTextEdit.TabIndex = 5;
            // 
            // formHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 393);
            this.Controls.Add(this.hOCPHIGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "formHocPhi";
            this.Text = "formHocPhi";
            this.Load += new System.EventHandler(this.FormHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVROOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private QLDSVROOT qLDSVROOT;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private QLDSVROOTTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private QLDSVROOTTableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSVROOTTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl hOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit mASVTextEdit;
    }
}
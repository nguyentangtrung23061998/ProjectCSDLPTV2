using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
namespace QLDSV
{
    public partial class formBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public formBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void formBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVPMMaster.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVPMMaster.V_DS_PHANMANH);
            this.qLDSVROOT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSVROOT.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.qLDSVROOT.DIEM);
            // TODO: This line of code loads data into the 'qLDSVROOT.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSVROOT.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            this.sP_XuatBangDiemMonHocGridControl.Visible = false;
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.sP_XuatBangDiemMonHocTableAdapter.Fill(this.qLDSVROOT.SP_XuatBangDiemMonHoc, txtTenLop.Text, txtTenMonHoc.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(txtLanThi.Text, typeof(short))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_XuatBangDiemMonHocGridControl.Visible = true;
                this.sP_XuatBangDiemMonHocTableAdapter.Fill(this.qLDSVROOT.SP_XuatBangDiemMonHoc, txtTenLop.Text, txtTenMonHoc.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(txtLanThi.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnMayIn_Click(object sender, EventArgs e)
        {
            BaoCao.xRpt_InBangDiemMonHoc_spXuatBangDiemMonHoc rpt = new BaoCao.xRpt_InBangDiemMonHoc_spXuatBangDiemMonHoc(txtTenLop.Text,txtTenMonHoc.Text,txtLanThi.Text);
            rpt.lbLop.Text = txtTenLop.Text;
            rpt.lbMH.Text = txtTenMonHoc.Text;
            rpt.lbLanThi.Text = txtTenMonHoc.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoatMonHoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
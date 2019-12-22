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
    public partial class formInDSSV : DevExpress.XtraEditors.XtraForm
    {
        public formInDSSV()
        {
            InitializeComponent();
        }

        private void formInDSSV_Load(object sender, EventArgs e)
        {
            qLDSVROOT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSVROOT.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVROOT.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            // TODO: This line of code loads data into the 'qLDSVPMMaster.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVPMMaster.V_DS_PHANMANH);
            this.sINHVIENGridControl.Visible = false;


            if (Program.mGroup == "KHOA")
            {
                comboKHOA.DataSource = Program.bds_dspm.DataSource;
                comboKHOA.DisplayMember = "TENCN";
                comboKHOA.ValueMember = "TENSERVER";
                // We set mChinhanh when Login 
                comboKHOA.SelectedIndex = Program.mChinhanh;
                comboKHOA.Enabled = false;
            }
            if (Program.mGroup == "PGV")
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH WHERE TENCN <> 'QLDSV_KETOAN'");

                comboKHOA.DataSource = dt;
                comboKHOA.DisplayMember = "TENCN";
                comboKHOA.ValueMember = "TENSERVER";
                comboKHOA.SelectedIndex = Program.mChinhanh;
            }
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            this.sINHVIENGridControl.Visible = true;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVROOT.SINHVIEN);
        }

        private void btnMayIn_Click(object sender, EventArgs e)
        {
            //BaoCao.formTimSVTheoMaLop rpt = new BaoCao.formTimSVTheoMaLop(txtML.Text);
            //BaoCao.formTest rpt2 = new BaoCao.formTest("D1", "D16C3");
            //ReportPrintTool print = new ReportPrintTool(rpt2);
            //print.ShowPreviewDialog();
            BaoCao.xRpt_InDSSV_spTimSVTheoMaLop rpt = new BaoCao.xRpt_InDSSV_spTimSVTheoMaLop(txtML.Text);
            rpt.lbML.Text = comboBox1.SelectedValue.ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void btnThoatMonHoc_Click(object sender, EventArgs e)
        {
            comboKHOA.SelectedIndex = Program.mChinhanh;
            this.Close();
        }

        private void comboKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKHOA.SelectedValue == null) return;

            Program.servername = comboKHOA.SelectedValue.ToString();
            if (comboKHOA.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                qLDSVROOT.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSVROOT.SINHVIEN);

            }
        }
    }
}
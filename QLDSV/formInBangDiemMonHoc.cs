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

namespace QLDSV
{
    public partial class formInBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public formInBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void FormInBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            qLDSVROOT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            // TODO: This line of code loads data into the 'qLDSVROOT.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVROOT.V_DS_PHANMANH);


        }

        private void BtnManHinh_Click(object sender, EventArgs e)
        {
            sP_InBangDiemTongKetTableAdapter1.Connection.ConnectionString = Program.connstr;
            sP_InBangDiemTongKetTableAdapter1.Fill(this.qLDSVROOT.SP_InBangDiemTongKet, txtTenLop.Text);

      
        }   


    }
}
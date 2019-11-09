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
    public partial class formLop : DevExpress.XtraEditors.XtraForm
    {

        int vitri = 0;
        String makh = "";

        Boolean checkAdd = false;

        public formLop()
        {
            InitializeComponent();
        }

        public void loadButton()
        {
            this.btnLopThem.Enabled = false;
            this.btnLopSua.Enabled = false;
            this.btnLopRefresh.Enabled = false;
            this.btnLopXoa.Enabled = false;
            this.btnLopPhucHoi.Enabled = false;
        }

        private void formLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVPMMaster.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVPMMaster.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            this.comboKHOA.SelectedIndex = 0;
            makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
            txtMaKhoa.Text = makh;
            txtMaKhoa.Enabled = false;
            loadButton();
        }

        private void btnLopThem_Click(object sender, EventArgs e)
        {
            //if (Program.conn.State == ConnectionState.Closed)
            //    Program.conn.Open();
            if(txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            int dem1 = 0;
            int dem2 = 0;
            for(int i = 0; i < lOPBindingSource.Count; i++)
            {
                if (txtMaLop.Text.Trim() == ((DataRowView)lOPBindingSource[i])["MALOP"].ToString().Trim())
                {
                    MessageBox.Show("Mã lớp bị trùng!", "", MessageBoxButtons.OK);
                    txtMaLop.Focus();
                    return;
                }
                if(txtTenLop.Text.Trim() == ((DataRowView)lOPBindingSource[i])["TENLOP"].ToString().Trim())
                {
                    MessageBox.Show("Tên lớp bị trùng!", "", MessageBoxButtons.OK);
                    txtMaLop.Focus();
                    return;
                }
            }

            try
            {
                String strLenh = "dbo.SP_InsertLop";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txtTenLop.Text;
                Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.NChar).Value = txtMaKhoa.Text;
                Program.sqlcmd.ExecuteNonQuery();
                this.lOPBindingSource.EndEdit();
               // this.lOPTableAdapter.Update(this.qLDSVROOT.LOP);
                //this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }


            //String strLenh = "dbo.SP_InsertLop";
            //Program.sqlcmd = Program.conn.CreateCommand();
            //Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            //Program.sqlcmd.CommandText = strLenh;
            //Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
            //Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txtTenLop.Text;
            //Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.NChar).Value = txtMaKhoa.Text;
            //Program.sqlcmd.ExecuteNonQuery();
            //this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            //Program.conn.Close();

        }

        public String maL;
        public String tenL;
        public String maK;

        private void comboKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = comboKHOA.SelectedValue.ToString();
            if(comboKHOA.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else{
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
                makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
                txtMaKhoa.Text = makh;
                txtMaKhoa.Enabled = false;
            }
        }

        private void btnLopXoa_Click(object sender, EventArgs e)
        {
         //   this.lOPBindingSource.RemoveCurrent();
            //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.lOPTableAdapter.Update(this.qldsV.LOP);
        }

        private void btnLopClear_Click(object sender, EventArgs e)
        {
            this.btnLopThem.Enabled = true;
            this.lOPBindingSource.AddNew();
        }
    }
}
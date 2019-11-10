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
using System.Data.SqlClient;

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
            this.btnLopPhucHoi.Enabled = false;
        }


        private void formLop_Load(object sender, EventArgs e)
        {
            //QLDSVROOT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSVPMMaster.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVPMMaster.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            this.comboKHOA.SelectedIndex = 0;
            makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
            Program.servername = comboKHOA.SelectedValue.ToString();
            txtMaKhoa.Text = makh;
            txtMaKhoa.Enabled = false;
            loadButton();
        }

        private void btnLopThem_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            if (txtMaLop.Text.Trim() == "")
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
            
            try
            {
                String strLenh = "SP_KiemTraLopTonTai";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                String ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if(ret == "1")
                {
                    MessageBox.Show("Tồn tại mã lớp.\n" , "", MessageBoxButtons.OK);
                    return;
                }
                if(ret == "2")
                {
                    MessageBox.Show("Tồn tại mã lớp ở site khác.\n" , "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tồn tại mã lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            ///thêm lớp
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
                this.lOPTableAdapter.Update(this.qLDSVROOT.LOP);
                this.lOPBindingSource.EndEdit();
                MessageBox.Show("Thêm Lớp Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }


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
          
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                String check= "SP_KiemTraMaLopTonTaiSinhVien";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = check;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                String ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if(ret == "1")
                {
                    MessageBox.Show("Mã lop ton tai trong sinh vien!", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                }
                if(ret == "0")
                {
                    this.lOPBindingSource.RemoveCurrent();
                    //  this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Update(this.qLDSVROOT.LOP);

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi xóa lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnLopClear_Click(object sender, EventArgs e)
        {
            this.btnLopThem.Enabled = true;
            this.btnLopSua.Enabled = true;
            this.lOPBindingSource.AddNew();
            makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
            txtMaKhoa.Text = makh;
            txtMaKhoa.Enabled = false;
        }

        private void btnLopSua_Click(object sender, EventArgs e)
        {
        
            if (txtMaLop.Text.Trim() == "")
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
            try
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_KiemTraLopTonTai";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret == "0")
                {
                    MessageBox.Show(" nhân viên không tồn tại !", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                    return;
                }
                if(Ret == "1")
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String upDateLop = "SP_UpdateMaLop";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = upDateLop;
                    Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                    Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txtTenLop.Text;
                    Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.NChar).Value = txtMaKhoa.Text;
                    Program.sqlcmd.ExecuteNonQuery();
                    this.lOPTableAdapter.Update(this.qLDSVROOT.LOP);
                    this.lOPBindingSource.EndEdit();
                    Program.conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLopRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
                this.txtMaLop.Text = "";
                this.txtTenLop.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
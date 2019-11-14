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
using System.Collections;

namespace QLDSV
{
    public partial class formLop : DevExpress.XtraEditors.XtraForm
    {

        public int choice = 0; // XAC DINH chon THEM / CHUYEN/ SUA   
        String makh = "";

        public Stack st = new Stack();
        public class ObjectUndo
        {
            int type;//thêm = 1, xóa =2 , sửa =3
            String lenh;//lệnh SP

            public ObjectUndo(int t, String l)
            {
                this.type = t;
                this.lenh = l;
            }

            public int getType()
            {
                return type;
            }
            public String getLenh()
            {
                return lenh;
            }
        }
        public formLop()
        {
            InitializeComponent();
        }

        public void loadButton()
        {
            this.btnLopThem.Enabled = false;
        }

        private void setComboboxKHOAbyDefault()
        {
            comboKHOA.DataSource = Program.bds_dspm.DataSource;
            comboKHOA.DisplayMember = "TENCN";
            comboKHOA.ValueMember = "TENSERVER";
            // We set mChinhanh when Login 
            comboKHOA.SelectedIndex = Program.mChinhanh;
        }
        private void formLop_Load(object sender, EventArgs e)
        {
            //QLDSVROOT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSVPMMaster.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVPMMaster.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
            // Program.servername = comboKHOA.SelectedValue.ToString();
            txtMaKhoa.Text = makh;
            txtMaKhoa.Enabled = false;
            loadButton();
            setComboboxKHOAbyDefault();
        }

        public String maL;
        public String tenL;
        public String maK;

        private void handleDuLieuFocus()
        {
            maL = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALOP").ToString().Trim();
            tenL = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOP").ToString().Trim();
            maK = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString().Trim();
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
                Program.conn.Close();
                if (ret == "1")
                {

                    MessageBox.Show("Tồn tại mã lớp.\n", "", MessageBoxButtons.OK);
                    return;
                }

                if (ret == "2")
                {

                    MessageBox.Show("Tồn tại mã lớp ở site khác.\n", "", MessageBoxButtons.OK);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tồn tại mã lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            ///thêm lớp
            try
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_InsertLop";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txtTenLop.Text;
                Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.NChar).Value = txtMaKhoa.Text;
                int type = 1;//Thêm
                String lenh = "exec SP_UndoThemLop '" + txtMaLop.Text + "'";
                ObjectUndo ob = new ObjectUndo(type, lenh);
                st.Push(ob);
                Program.sqlcmd.ExecuteNonQuery();
                this.lOPBindingSource.EndEdit();
                lOPBindingSource.ResetAllowNew();
                Program.conn.Close();
                MessageBox.Show("Thêm Lớp Thành công", "THÔNG BÁO", MessageBoxButtons.OK);

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void comboKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // For close form
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
                String check = "SP_KiemTraMaLopTonTaiSinhVien";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = check;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                String ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (ret == "1")
                {
                    MessageBox.Show("Mã lop ton tai trong sinh vien!", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                }
                if (ret == "2")
                {
                    MessageBox.Show("Tồn tại mã lớp trong sinh viên ở site khác.\n", "", MessageBoxButtons.OK);
                    return;
                }
                if (ret == "0")
                {
                    String lenhstr = "SP_DeleteMaLop";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = lenhstr;
                    Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                    Program.sqlcmd.ExecuteNonQuery();
                    //  this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK);
                    int type = 2;//XÓA
                    String lenh = "exec SP_UndoDeleteLop '" + txtMaLop.Text + "', '" + txtTenLop.Text + "', '" + txtMaKhoa.Text + "'";
                    ObjectUndo ob = new ObjectUndo(type, lenh);
                    st.Push(ob);
                    this.lOPBindingSource.RemoveCurrent();
                    this.lOPBindingSource.EndEdit();
                    Program.conn.Close();
                    st.Push(ob);
                    // Delete object    
                    this.lOPBindingSource.RemoveCurrent();
                    //  this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Update(this.qLDSVROOT.LOP);
                    this.lOPBindingSource.EndEdit();

                    Program.conn.Close();
                    txtMaKhoa.Focus();
                    return;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnLopClear_Click(object sender, EventArgs e)
        {
            // 
            txtMaLop.Focus();
            this.btnLopThem.Enabled = true;
            this.btnLopSua.Enabled = true;
            this.lOPBindingSource.ResetBindings(true);
            this.lOPBindingSource.AddNew();
            makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
            txtMaKhoa.Text = makh;
            txtMaKhoa.Enabled = false;
        }

        private void btnLopPhucHoi_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectUndo ob = (ObjectUndo)st.Pop();
                if (ob.getType() == 1)
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    MessageBox.Show("Khôi phục sau khi thêm " + ob.getLenh());
                    Program.ExecSqlDataReader(ob.getLenh());
                    this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
                    Program.conn.Close();
                }
                if (ob.getType() == 2)
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    MessageBox.Show("Khôi phục sau khi xóa " + ob.getLenh());
                    Program.ExecSqlDataReader(ob.getLenh());
                    this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
                    Program.conn.Close();
                }
                if (ob.getType() == 3)
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    MessageBox.Show("Khôi phục sau khi sữa " + ob.getLenh());
                    Program.ExecSqlDataReader(ob.getLenh());
                    this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
                    Program.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có gì để Undo", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnLopRefresh_Click(object sender, EventArgs e)
        {
            try
            {

                this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLopThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (Ret == "2")
                {
                    MessageBox.Show("Tồn tại mã lớp ở site khác.\n", "", MessageBoxButtons.OK);
                    return;
                }
                if (Ret == "1")
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    handleDuLieuFocus();
                    String lenh = "exec SP_UndoUpdateLop " + maL + ", " + tenL + ", " + maK;
                    String upDateLop = "SP_UpdateMaLop";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = upDateLop;
                    Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                    Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txtTenLop.Text;
                    Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.NChar).Value = txtMaKhoa.Text;
                    Program.sqlcmd.ExecuteNonQuery();
                    this.lOPBindingSource.EndEdit();
                    int type = 3;//chỉnh sửa

                    // String lenh = "exec SP_UndoUpdateLop '" + txtMaLop.Text + "' '" + txtTenLop.Text + "' '" + txtMaKhoa.Text + "'";


                    ObjectUndo ob = new ObjectUndo(type, lenh);
                    st.Push(ob);
                    Program.conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
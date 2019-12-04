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
    public partial class formTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public static String quyen = "";
        public static String username = "";
        public static String pass = "";
        public static String loginName = "";

        public formTaoLogin()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVROOT);

        }
        private void validate()
        {
            //if(Program.mGroup=="")
        }
        private void formTaoLogin_Load(object sender, EventArgs e)
        {
            this.qLDSVROOT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSVROOT.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.qLDSVROOT.GIANGVIEN);
        }

        public Boolean checkInfoGV()
        {
            if (this.txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được thiếu.\n", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return false;
            }
            if (this.txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu giảng viên không được thiếu.\n", "", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return false;
            }
            if (comboBoxQuyen.Text.Trim() == "")
            {
                MessageBox.Show("Quyền giảng viên không được thiếu.\n", "", MessageBoxButtons.OK);
                comboBoxQuyen.Focus();
                return false;
            }


            if (textBoxtenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được thiếu.\n", "", MessageBoxButtons.OK);
                textBoxtenDangNhap.Focus();
                return false;
            }
            return true;
        }

        public void acceptInfo()
        {
            loginName = textBoxtenDangNhap.Text.Trim();
            username = txtMaGV.Text.Trim();
            pass = txtMatKhau.Text.Trim();
            quyen = comboBoxQuyen.Text.Trim();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Boolean checkEmpty = checkInfoGV();
            String s = comboBoxQuyen.Items[2].ToString();
            if (checkEmpty)
            {
                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    acceptInfo();
                    String strLenh = "sp_TaoTaiKhoan";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@LGNAME", SqlDbType.VarChar).Value = loginName;
                    Program.sqlcmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = pass;
                    Program.sqlcmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username;
                    Program.sqlcmd.Parameters.Add("@ROLE ", SqlDbType.VarChar).Value = quyen;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    if (Program.mGroup == "KHOA")
                    {
                        if (Program.mGroup == quyen)
                        {
                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();
                            MessageBox.Show("Thêm thành công", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Chỉ tạo quyền khoa", "Thông Báo");
                            return;
                        }
                    }
                    if (Program.mGroup == "PGV")
                    {
                        if (quyen == comboBoxQuyen.Items[2].ToString())
                        {
                            MessageBox.Show("Chỉ tạo quyền PGV và KHOA", "Thông Báo");
                            return;
                        }
                        else
                        {
                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();
                            MessageBox.Show("Thêm thành công", "Thông Báo");
                        }
                    }
                    if (Program.mGroup == "KETOAN")
                    {
                        if (Program.mGroup == quyen)
                        {
                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();
                            MessageBox.Show("Thêm thành công", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Chỉ tạo quyền kế toán", "Thông Báo");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống thông tin", "", MessageBoxButtons.OK);
                return;
            }

        }

        private void comboBoxQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.maCN = comboBoxQuyen.Items[comboBoxQuyen.SelectedIndex].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn quyền.\n" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.gIANGVIENTableAdapter.Fill(this.qLDSVROOT.GIANGVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

      
    }
}
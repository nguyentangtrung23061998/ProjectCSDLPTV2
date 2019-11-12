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
    public partial class formMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public formMonHoc()
        {
            InitializeComponent();
        }

        public void loadButton()
        {
            // Disable add and undo button
            this.btnThemMonHoc.Enabled = false;
            this.btnPhucHoiMonHoc.Enabled = false;
        }

        private void setComboboxKHOAbyDefault()
        {
            comboKHOA.DataSource = Program.bds_dspm.DataSource;
            comboKHOA.DisplayMember = "TENCN";
            comboKHOA.ValueMember = "TENSERVER";
            // We set mChinhanh when Login 
            comboKHOA.SelectedIndex = Program.mChinhanh;
        }
        private void FormMonHoc_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLDSVROOT.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVROOT.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVROOT.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVROOT.MONHOC);

            // set default value for comboxKHOA
            setComboboxKHOAbyDefault();
            // Disabled button add and undo
            loadButton();
        }

        public String makh;
        private void ComboKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // For close form
            if (comboKHOA.SelectedValue == null) return;
            // For selected combox value
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
            // Connect to other server using HTKN
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.qLDSVROOT.MONHOC);
            }
        }

        private string ExecuteSP_KiemMaMonHoc(String spName)
        {
            // SP return 
            // 1: exist
            // 0: not exist 
            // String strLenh = spName;
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = spName;
            // SP Variables
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMaMH.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

            return ret;
        }

        private void ExcuteSP_Update_Insert_MonHoc(String spName, String dialogDescription)
        {

            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = spName;
            // SP variables
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMaMH.Text;
            Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = txtTenMH.Text;
            // Run query 
            Program.sqlcmd.ExecuteNonQuery();
            this.mONHOCTableAdapter.Update(this.qLDSVROOT.MONHOC);
            this.mONHOCBindingSource.EndEdit();
            // refesh change 
            this.qLDSVROOT.MONHOC.AcceptChanges();
            this.mONHOCTableAdapter.Fill(this.qLDSVROOT.MONHOC);

            // Disabled btnThemMonHoc after added successfully
            MessageBox.Show(dialogDescription, "THÔNG BÁO", MessageBoxButtons.OK);
            this.btnThemMonHoc.Enabled = false;
        }

        private void BtnThemMonHoc_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            // Checking error
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
           
            try
            {
                // SP return 
                // 1: exist
                // 0: not exist 
                String result = ExecuteSP_KiemMaMonHoc("SP_KiemMaMHTonTai");
                if (result == "1")
                {
                    MessageBox.Show("Mã môn học đã tồn tại.\n", "", MessageBoxButtons.OK);
                    return;
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra mã môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                // Excute SP
                ExcuteSP_Update_Insert_MonHoc("SP_InsertMonHoc", "Thêm môn học thành công");
                Program.conn.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
           
        }

        private void BtnClearMonHoc_Click(object sender, EventArgs e)
        {
            // Disabled button
            this.btnThemMonHoc.Enabled = true;
            this.btnPhucHoiMonHoc.Enabled = true;
            // Create new row in grid control
            this.mONHOCBindingSource.AddNew();
        }

        private void BtnRefeshMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Fill table MONHOC, refesh data
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.qLDSVROOT.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnXoaMonHoc_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa nó không?", "Xóa môn học", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                try
                {
                    // SP return 
                    // 1: exist
                    // 0: not exist 
                    // Check if MaMH exists
                    String result = ExecuteSP_KiemMaMonHoc("SP_KiemMaMHTonTai");
                    // If maMH exists
                    if (result == "1")
                    {
                        try
                        {
                            // Check if MonHoc had Diem => cant delete
                            String ret = ExecuteSP_KiemMaMonHoc("SP_KiemMHTonTaiDiem");
                            // If MonHoc had Diem
                            if (ret == "1")
                            {
                                MessageBox.Show("Mã môn này đã có điểm!", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                            }
                            if (ret == "0")
                            {
                                this.mONHOCBindingSource.RemoveCurrent();
                                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK);
                                this.mONHOCTableAdapter.Update(this.qLDSVROOT.MONHOC);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mã môn học không tồn tại.\n", "THÔNG BÁO", MessageBoxButtons.OK);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    // Can be if did not pick the Department 
                    MessageBox.Show("Lỗi kiểm tra mã môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }


        private void BtnSuaMonHoc_Click(object sender, EventArgs e)
        {
           
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không để trống!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không để trống!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                // SP return 
                // 1: exist
                // 0: not exist 
                // Check if MaMH exists
                String result = ExecuteSP_KiemMaMonHoc("SP_KiemMaMHTonTai");
                // If maMH exists
                if (result == "1")
                {

                    // Run sp Update monHoc
                    ExcuteSP_Update_Insert_MonHoc("SP_UpdateMonHoc", "Sửa môn học thành công");
                    Program.conn.Close();
                }
                else
                {
                     MessageBox.Show("Mã môn học không tồn tại.\n", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra mã môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
           
        }

        private void BtnThoatMonHoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
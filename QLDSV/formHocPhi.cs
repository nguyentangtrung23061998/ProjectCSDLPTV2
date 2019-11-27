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
    public partial class formHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private Boolean isAddNew = false;
        public formHocPhi()
        {
            InitializeComponent();
        }
        private void setComboboxKHOAbyDefault()
        {
           
            comboKHOA.DataSource = Program.bds_dspm;
            comboKHOA.DisplayMember = "TENCN";
            comboKHOA.ValueMember = "TENSERVER";
            // We already set mChinhanh when Login 
            comboKHOA.SelectedIndex = Program.mChinhanh;
            comboKHOA.Enabled = false;
        }
        private void FormHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVROOT.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVROOT.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVPMMaster.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVPMMaster.V_DS_PHANMANH);
            qLDSVROOT.EnforceConstraints = false;
            setComboboxKHOAbyDefault();

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "1");
            dict.Add(2, "2");
            dict.Add(3, "3");
            cmbHocKy.DataSource = new BindingSource(dict, null);
            cmbHocKy.DisplayMember = "Value";
            cmbHocKy.ValueMember = "Key";

            hOCPHIGridControl.Enabled = false;
            btnGhi.Enabled = false;
            btnNhapSV.Enabled = false;
            pnclHocPhi.Visible = false;
            txtNienKhoa.ReadOnly = true;
           
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (txtMASV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã SV!");
                txtMASV.Focus();
                return;
            }
            try
            {
                if (Program.conn.State == ConnectionState.Open) Program.conn.Close();
                SqlDataReader myReader;
                string strLenh = " exec SP_GetThongTinSinhVien '" + txtMASV.Text.Trim() + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (!myReader.HasRows)
                {
                    MessageBox.Show("Sinh viên không tồn tại hoặc đã NGHỈ HỌC!", "", MessageBoxButtons.OK);
                    myReader.Close();
                    txtMASV.Focus();
                    return;
                }
                if (myReader.Read())
                {
                    lbHOTEN.Text = myReader.GetString(0);
                    lbMALOP.Text = myReader.GetString(1);

                    this.sP_DongHocPhiSinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_DongHocPhiSinhVienTableAdapter.Fill(this.qLDSVROOT.SP_DongHocPhiSinhVien, txtMASV.Text.Trim());

                    txtMASV.Enabled = false;
                    btnLoad.Enabled = true;
                    btnNhapSV.Enabled = true;
                    btnGhi.Enabled = true;
                    hOCPHIGridControl.Enabled = true;
                    pnclHocPhi.Visible = true;

                    sINHVIENGridControl.Enabled = false;


                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu học phí:\n" + ex.Message, "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {

            if(txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống!", "Lỗi", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            if(txtHocPhi.Text.Trim() == "")
            {
                MessageBox.Show("Học phí không được để trống!", "Lỗi", MessageBoxButtons.OK);
                txtHocPhi.Focus();
                return;
            }else
            {
                int hocPhi = int.Parse(txtHocPhi.Text);
                if(hocPhi < 0)
                {
                    MessageBox.Show("Học phí không được âm!", "Lỗi", MessageBoxButtons.OK);
                    txtHocPhi.Focus();
                    return;
                }
            }
            if(txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Số tiền đã đóng không được để trống!", "Lỗi", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }else
            {
                int soTien = int.Parse(txtSoTien.Text);
                if(soTien < 0)
                {
                    MessageBox.Show("Số tiền không được âm!", "Lỗi", MessageBoxButtons.OK);
                    txtSoTien.Focus();
                    return;
                }
            }

            Boolean stopUpdate = false;
            if(isAddNew)
            {
                try
                {
                    SqlDataReader myReader;
                    string strLenh = "SELECT * FROM DBO.HOCPHI WHERE MASV='" + txtMASV.Text.Trim() + "' and NIENKHOA='" + txtNienKhoa.Text.Trim() + "' AND HOCKY='" + cmbHocKy.SelectedValue.ToString() + "' ";
                    myReader = Program.ExecSqlDataReader(strLenh);
                    if (myReader.HasRows)
                    {
                        DialogResult result = MessageBox.Show("Mã SV, niên khóa, học kỳ đã có trong database!\n Bạn có muốn cập nhật lại không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            isAddNew = false;
                        }
                        else
                        {
                            // remove addnew when click clear button
                            this.sPDongHocPhiSinhVienBindingSource.RemoveCurrent();
                            this.sPDongHocPhiSinhVienBindingSource.EndEdit();
                            stopUpdate = true;
                        }
                        myReader.Close();
                    }
                    Program.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra MASV, NIENKHOA, HOCKY: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                    Program.conn.Close();
                    return;
                }
            }

            if(!stopUpdate)
            {
                if (isAddNew)
                {
                    isAddNew = false;
                    try
                    {
                        string strLenh = "INSERT INTO dbo.HOCPHI (MASV,NIENKHOA,HOCKY,HOCPHI,SOTIENDADONG) VALUES (@MASV,@NIENKHOA,@HOCKY,@HOCPHI,@SOTIENDADONG)";
                        if (Program.conn.State == ConnectionState.Closed)
                            Program.conn.Open();
                        Program.sqlcmd = Program.conn.CreateCommand();
                        Program.sqlcmd.CommandType = CommandType.Text;
                        Program.sqlcmd.CommandText = strLenh;
                        Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = txtMASV.Text.Trim();
                        Program.sqlcmd.Parameters.Add("@NIENKHOA", SqlDbType.NVarChar).Value = txtNienKhoa.Text.Trim();
                        Program.sqlcmd.Parameters.Add("@HOCKY", SqlDbType.Int).Value = int.Parse(cmbHocKy.SelectedValue.ToString());
                        Program.sqlcmd.Parameters.Add("@HOCPHI", SqlDbType.Int).Value = int.Parse(txtHocPhi.Text.Trim());
                        Program.sqlcmd.Parameters.Add("@SOTIENDADONG", SqlDbType.Int).Value = int.Parse(txtSoTien.Text.Trim());
                        Program.sqlcmd.ExecuteNonQuery();
                        Program.conn.Close();

                        MessageBox.Show("Đã thêm mới vào cơ sỡ dữ liệu", "", MessageBoxButtons.OK);
                        this.sPDongHocPhiSinhVienBindingSource.EndEdit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                        Program.conn.Close();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        string strLenh = "UPDATE dbo.HOCPHI SET NIENKHOA = @NIENKHOA, HOCKY=@HOCKY, HOCPHI=@HOCPHI, SOTIENDADONG=@SOTIENDADONG WHERE MASV = @MASV and NIENKHOA=N'" + txtNienKhoa.Text.Trim() + "' and HOCKY='" + cmbHocKy.SelectedValue.ToString() + "'";
                        if (Program.conn.State == ConnectionState.Closed)
                            Program.conn.Open();
                        Program.sqlcmd = Program.conn.CreateCommand();
                        Program.sqlcmd.CommandType = CommandType.Text;
                        Program.sqlcmd.CommandText = strLenh;
                        Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = txtMASV.Text.Trim();
                        Program.sqlcmd.Parameters.Add("@NIENKHOA", SqlDbType.NVarChar).Value = txtNienKhoa.Text.Trim();
                        Program.sqlcmd.Parameters.Add("@HOCKY", SqlDbType.Int).Value = int.Parse(cmbHocKy.SelectedValue.ToString());
                        Program.sqlcmd.Parameters.Add("@HOCPHI", SqlDbType.Int).Value = int.Parse(txtHocPhi.Text.Trim());
                        Program.sqlcmd.Parameters.Add("@SOTIENDADONG", SqlDbType.Int).Value = int.Parse(txtSoTien.Text.Trim());
                        Program.sqlcmd.ExecuteNonQuery();
                        Program.conn.Close();
                        MessageBox.Show("Đã cập nhật dữ liệu", "", MessageBoxButtons.OK);
                        this.sPDongHocPhiSinhVienBindingSource.EndEdit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                        Program.conn.Close();
                        return;
                    }
                }
            }
            btnClear.Enabled = true;
            txtNienKhoa.ReadOnly = true;
            this.sP_DongHocPhiSinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DongHocPhiSinhVienTableAdapter.Fill(this.qLDSVROOT.SP_DongHocPhiSinhVien, txtMASV.Text.Trim());
        }

        private void BtnNhapSV_Click(object sender, EventArgs e)
        {
            txtMASV.Enabled = true;
            btnNhapSV.Enabled = false;
            btnLoad.Enabled = true;
            hOCPHIGridControl.Enabled = false;
            pnclHocPhi.Visible = false;
            sINHVIENGridControl.Enabled = true;
            // Clear fields
            //txtMASV.Text = "";
            lbHOTEN.Text = "";
            lbMALOP.Text = "";
        }
        
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNienKhoa.Focus();
            // Create new row in grid control
            this.sPDongHocPhiSinhVienBindingSource.AddNew();
            isAddNew = true;
            btnClear.Enabled = false;
            txtNienKhoa.ReadOnly = false;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
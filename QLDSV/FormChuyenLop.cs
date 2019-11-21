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
    public partial class FormChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenLop()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVROOT);

        }
        public void enableInput()
        {
            txtMaSV.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled =  false;
            txtMaLop.Enabled = false;
            comboNgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtDiaChi.Enabled = false;
            cbPhai.Enabled = false;
            cbNghiHoc.Enabled = false;
            txtTL.Enabled = false;
        }
        public void info()
        {
            txtMaSV.Text = formSinhVienV2.saveInfo.maSV;
            txtHo.Text = formSinhVienV2.saveInfo.ho;
            txtTen.Text = formSinhVienV2.saveInfo.ten;
            txtMaLop.Text = formSinhVienV2.saveInfo.maLop;
            comboNgaySinh.Text = formSinhVienV2.saveInfo.ngaySinh;
            txtNoiSinh.Text = formSinhVienV2.saveInfo.noiSinh;
            txtDiaChi.Text = formSinhVienV2.saveInfo.diaChi;
            cbPhai.Checked = formSinhVienV2.saveInfo.phai;
            cbNghiHoc.Checked = formSinhVienV2.saveInfo.nghiHoc;
            txtTL.Text = txtMaLop.Text;
        }
        public void cmdSinhVien(String maSV, String ho, String ten, String maLop,
                               Boolean checkBoxPhai, String comboNgaySinh, String noiSinh,
                               String diaChi, Boolean checkboxNghiHoc)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                Program.sqlcmd.Parameters.Add("@HO", SqlDbType.NVarChar).Value = ho;
                Program.sqlcmd.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = ten;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = maLop;
                Program.sqlcmd.Parameters.Add("@PHAI", SqlDbType.Bit).Value = checkBoxPhai ? 1 : 0;
                Program.sqlcmd.Parameters.Add("@NGAYSINH", SqlDbType.NVarChar).Value = comboNgaySinh;
                Program.sqlcmd.Parameters.Add("@NOISINH", SqlDbType.NVarChar).Value = noiSinh;
                Program.sqlcmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = diaChi;
                Program.sqlcmd.Parameters.Add("@NGHIHOC", SqlDbType.Bit).Value = checkboxNghiHoc ? 1 : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void FormChuyenLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVROOT.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVROOT.LOP);
            // TODO: This line of code loads data into the 'qLDSVROOT.V_DS_PHANMANH' table. You can move, or remove it, as needed.
           

            enableInput();
            info();
            toolStripStatusMaSV.Text = "MaSV: " + txtMaSV.Text;
            toolStripStatusHoTen.Text = "Họ Tên: " + txtHo.Text + " " + txtTen.Text;
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            try
            {
                String maLop = comboMaLop.SelectedValue.ToString();
                String updateSinhVien = "SP_UpdateSinhVien";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = updateSinhVien;
                cmdSinhVien(txtMaSV.Text, txtHo.Text, txtTen.Text, maLop, cbPhai.Checked,
                       comboNgaySinh.Text, txtNoiSinh.Text, txtDiaChi.Text, cbNghiHoc.Checked);
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                MessageBox.Show("Chuyển lớp thành công!", "", MessageBoxButtons.OK);
                this.sINHVIENBindingSource.EndEdit();
                this.Hide();
                this.Close();
                formSinhVienV2 frm = new formSinhVienV2();
                frm.formSinhVienV2_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển lớp sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
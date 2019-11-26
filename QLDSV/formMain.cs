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
    public partial class formMain : DevExpress.XtraEditors.XtraForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (Program.maCN != "KETOAN")
            {
                btnHocPhi.Enabled = false;
               
            }else
            {
                btnDiem.Enabled = false;
                btnMonHoc.Enabled = false;
                btnLop.Enabled = false;
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype) return f;
            return null;
        }
        public void HienThiMenu()
        {
            toolStripStatusLabelMaUSER.Text = "Id: " + Program.username;
            toolStripStatusLabelTenUser.Text = "USER: " + Program.mHoten;
            toolStripStatusLabelRole.Text = "ROLE: " + Program.mGroup;
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                formMonHoc f = new formMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formLop));
            if (frm != null) frm.Activate();
            else
            {
                formLop f = new formLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDiem));
            if (frm != null) frm.Activate();
            else
            {
                formDiem f = new formDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                formHocPhi f = new formHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                formSinhVien f = new formSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Open) Program.conn.Close();
            // Close formMain and open formDangNhap
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Xóa môn học", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                formDangNhap form2 = new formDangNhap();
                form2.ShowDialog();
                this.Close();
            }  
        }

        private void BtnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                formTaoLogin f = new formTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnDSThiHetMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDanhSachThiHetMon));
            if (frm != null) frm.Activate();
            else
            {
                formDanhSachThiHetMon f = new formDanhSachThiHetMon();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
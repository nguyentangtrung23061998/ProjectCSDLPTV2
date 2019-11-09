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
        }

        public void HienThiMenu()
        {
            toolStripStatusLabelMaUSER.Text = "Id: " + Program.username;
            toolStripStatusLabelTenUser.Text = "USER: " + Program.mHoten;
            toolStripStatusLabelRole.Text = "ROLE: " + Program.mGroup;
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formMonHoc frm = new formMonHoc();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formLop frm = new formLop();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
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
    public partial class formHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public formHocPhi()
        {
            InitializeComponent();
        }

        private void HOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCPHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVROOT);

        }

        private void FormHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVROOT.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVROOT.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVROOT.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Fill(this.qLDSVROOT.HOCPHI);

        }
    }
}
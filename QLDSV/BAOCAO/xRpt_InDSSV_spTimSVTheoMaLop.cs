using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.BaoCao
{
    public partial class xRpt_InDSSV_spTimSVTheoMaLop : DevExpress.XtraReports.UI.XtraReport
    {
        //public xRpt_InDSSV_spTimSVTheoMaLop()
        //{
        //    InitializeComponent();
        //}

        public xRpt_InDSSV_spTimSVTheoMaLop(String maLop)
        {
            InitializeComponent();
            qldsvroot3.EnforceConstraints = false;
            this.sP_XuatSinhVienTheoMaLopTableAdapter2.Connection.ConnectionString = Program.connstr;
            this.sP_XuatSinhVienTheoMaLopTableAdapter2.Fill(qldsvroot3.SP_XuatSinhVienTheoMaLop, maLop);
        }

    }
}

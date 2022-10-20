using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTtrebLop17_10_2022
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        KetNoi kn = new KetNoi();


        
        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from nhanvien");
            cboMaNV.DataSource = dta;
            cboMaNV.ValueMember = "manv";

            cboMaNV.DisplayMember = "manv";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from nhanvien where manv like'" + cboMaNV.Text + "'");
            baocao bao_cao = new baocao();
            bao_cao.SetDataSource(dta);
            crystalReportViewerBaoCao.ReportSource = bao_cao;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

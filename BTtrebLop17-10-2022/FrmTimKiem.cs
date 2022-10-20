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
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void lay_du_lieu_NV()
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from nhanvien");
            cboMaNV.DataSource = dta;
            cboMaNV.DisplayMember = "manv";
            cboMaNV.ValueMember = "manv";
        }

        public void lay_du_lieu_Phong()
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from phonggd");
            cboMaPhong.DataSource = dta;
            cboMaPhong.DisplayMember = "maphong";
            cboMaPhong.ValueMember = "maphong";
        }

        public void lay_du_lieu_LoaiTK()
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from loaitk");
            cboMaLoaiTK.DataSource = dta;
            cboMaLoaiTK.DisplayMember = "maloai";
            cboMaLoaiTK.ValueMember = "maloai";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            lay_du_lieu_NV();
            lay_du_lieu_Phong();
            lay_du_lieu_LoaiTK();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;


            if (optMaNV.Checked == true)
            {
                cboMaNV.Focus();
                sqltk = "select * from v_tonghop where manv like '" + cboMaNV.Text + "'";
                dta = kn.LayDuLieu(sqltk);
            }
                
            if (optMaPhong.Checked == true)
            {
                cboMaPhong.Focus();
                sqltk = "select * from v_tonghop where maphong like '" + cboMaPhong.Text + "'";
                dta = kn.LayDuLieu(sqltk);
            }

            if (optMaTK.Checked == true)
            {
                cboMaLoaiTK.Focus();
                sqltk = "select * from v_tonghop where maloai like '" + cboMaLoaiTK.Text + "'";
                dta = kn.LayDuLieu(sqltk);
            }

            dataGridViewTimKiem.DataSource = dta;
        }
    }
}

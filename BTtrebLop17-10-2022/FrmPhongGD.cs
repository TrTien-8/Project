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
    public partial class FrmPhongGD : Form
    {
        public FrmPhongGD()
        {
            InitializeComponent();
        }


        KetNoi kn = new KetNoi();

        public void laybang_phongGD()
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from phonggd");
            dataGridViewPhongGD.DataSource = dta;
        }

        public void hienthi_dulieu()
        {
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("Text", dataGridViewPhongGD.DataSource, "maphong");

            txtTenPhong.DataBindings.Clear();
            txtTenPhong.DataBindings.Add("Text", dataGridViewPhongGD.DataSource, "tenphong");

            txtDiaDiem.DataBindings.Clear();
            txtDiaDiem.DataBindings.Add("Text", dataGridViewPhongGD.DataSource, "diadiem");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dataGridViewPhongGD.DataSource, "dienthoai");
        }


        private void FrmPhongGD_Load(object sender, EventArgs e)
        {
            laybang_phongGD();
            hienthi_dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";

            txtDiaDiem.Text = "";
            txtDienThoai.Text = "";

            txtMaPhong.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.ThucThi("delete from phonggd where maphong = '" + txtMaPhong.Text + "'");
            laybang_phongGD();
            hienthi_dulieu();
        }

        private void btmThem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into phonggd values('" + txtMaPhong.Text + "', '" + txtTenPhong.Text + "', '" + txtDiaDiem.Text + "', '" + txtDienThoai.Text + "')";
            kn.ThucThi(sqlthem);
            laybang_phongGD();
            hienthi_dulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlsua = "update  phonggd set  tenphong = '" + txtTenPhong.Text + "',diadiem ='" + txtDiaDiem.Text + "' ,dienthoai ='" + txtDienThoai.Text + "' ";
            kn.ThucThi(sqlsua);
            laybang_phongGD();
            hienthi_dulieu();
        }
    }
}



/*
    maphong varchar(10) not null primary key,
	tenphong nvarchar(100) not null,
	diadiem nvarchar(255),
	dienthoai varchar(20)
 */

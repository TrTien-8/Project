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
    public partial class FrmLoaiTK : Form
    {
        public FrmLoaiTK()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void laybang_LoaiTK()
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from loaitk");
            dataGridViewLoaiTK.DataSource = dta;
        }


        public void hienthi_dulieu()
        {
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text", dataGridViewLoaiTK.DataSource, "maloai");

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", dataGridViewLoaiTK.DataSource, "tenloai");

            txtKyHan.DataBindings.Clear();
            txtKyHan.DataBindings.Add("Text", dataGridViewLoaiTK.DataSource, "kyhan");

            txtLoaiTien.DataBindings.Clear();
            txtLoaiTien.DataBindings.Add("Text", dataGridViewLoaiTK.DataSource, "loaitien");

            txtLaiSuat.DataBindings.Clear();
            txtLaiSuat.DataBindings.Add("Text", dataGridViewLoaiTK.DataSource, "laisuat");


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLoaiTK_Load(object sender, EventArgs e)
        {
            laybang_LoaiTK();
            hienthi_dulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.ThucThi("delete from loaitk where maloai = '" + txtMaLoai.Text + "'");
            laybang_LoaiTK();
            hienthi_dulieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into loaitk values('" + txtMaLoai.Text + "', '" + txtTenLoai.Text + "', '" + txtKyHan.Text + "', '" + txtLoaiTien.Text + "', '" + txtLaiSuat.Text + "')";
            kn.ThucThi(sqlthem);
            laybang_LoaiTK();
            hienthi_dulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlsua = "update  loaitk set  tenloai = '" + txtTenLoai.Text + "',kyhan ='" + txtKyHan.Text + "' ,loaitien ='" + txtLoaiTien.Text + "', laisuat ='" + txtLaiSuat.Text + "' ";
            kn.ThucThi(sqlsua);
            laybang_LoaiTK();
            hienthi_dulieu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";

            txtKyHan.Text = "";
            txtLoaiTien.Text = "";
            txtLaiSuat.Text = "";

            txtMaLoai.Focus();
        }
    }
}


/*
    maloai varchar(10) not null primary key,
	tenloai nvarchar(255) not null,
	kyhan int not null,
	loaitien varchar(10) not null,
	laisuat int not null,
 */
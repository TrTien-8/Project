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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void laybang_nhanvien()
        {
            DataTable dta = new DataTable();
            dta = kn.LayDuLieu("select * from nhanvien");
            dataGridViewNhanVien.DataSource = dta;
        }



        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            laybang_nhanvien();
            hienthi_dulieu();
        }


        public void hienthi_dulieu()
        {
            txtNhanVien.DataBindings.Clear();
            txtNhanVien.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "manv");

            dateTimeNgaySinh.DataBindings.Clear();
            dateTimeNgaySinh.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "ngaysinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "diachi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "dienthoai");

            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "maphong");
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtNhanVien.Text = "";
            dateTimeNgaySinh.Text = "";
            
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaPhong.Text = "";

            txtNhanVien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.ThucThi("delete from nhanvien where manv = '" + txtNhanVien.Text + "'");
            laybang_nhanvien();
            hienthi_dulieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into nhanvien values('" + txtNhanVien.Text + "', '" + dateTimeNgaySinh.Text + "', '" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "', " +
                " '" + txtMaPhong.Text + "')";
            kn.ThucThi(sqlthem);
            laybang_nhanvien();
            hienthi_dulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlsua = "update  nhanvien set  ngaysinh = '" + dateTimeNgaySinh.Text + "',diachi ='" + txtDiaChi.Text + "' ,dienthoai ='" + txtDienThoai.Text + "',maphong='" + txtMaPhong.Text + "' ";
            kn.ThucThi(sqlsua);
            laybang_nhanvien();
            hienthi_dulieu();
        }
    }
}


/*
    manv varchar(10) not null primary key,
	ngaysinh date not null,
	diachi nvarchar(100),
	dienthoai varchar(20),
	maphong varchar(10) references phonggd(maphong)
 */

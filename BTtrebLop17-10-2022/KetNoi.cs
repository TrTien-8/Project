using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTtrebLop17_10_2022
{
    class KetNoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void ket_noi()
        {
            string strKetNoi = @"Data Source= ABCD\SQLEXPRESS; Initial Catalog= quanlytietkiem1710; Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable LayDuLieu(string Sql)
        {
            ket_noi();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string sql)
        {
            ket_noi();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}

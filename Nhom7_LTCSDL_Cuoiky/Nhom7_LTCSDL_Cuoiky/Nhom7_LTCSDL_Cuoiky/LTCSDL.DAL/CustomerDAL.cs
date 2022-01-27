using LTCSDL_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL.DAL
{

    public class CustomerDAL
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        public CustomerDAL()
        {
            string cnStr = $"Data Source={Utility.DB_NAME};Initial Catalog=QuanCF;Integrated Security=True";
            cnn = new SqlConnection(cnStr);
        }

        public bool Login(string taikhoan, string matkhau)
        {
            string sql = "select * from KhachHang where TaiKhoan='" + taikhoan + "'and MatKhau='" + matkhau + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dta = cmd.ExecuteReader();
            var result = dta.Read();
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            return result;
        }

        public bool Register(CustomerDTO customer)
        {
            StringBuilder sb = new StringBuilder("Insert into KhachHang(TenKhachHang, DiaChi, SDT, Email, TaiKhoan, MatKhau)");
            sb.AppendFormat("values(N'{0}', N'{1}', '{2}', '{3}', '{4}', '{5}')", customer.TenKH, customer.DiaChi, customer.SDT, customer.Email, customer.TaiKhoan, customer.MatKhau);
            sb.Append("select @@IDENTITY as MaKH");
            try
            {
                cnn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                var result = cmd.ExecuteNonQuery() == 1;
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                return result;
            }
            catch (Exception e)
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                return false;
            }

        }

        public CustomerDTO getInfoCustomer(string taikhoan)
        {
            string sql = "select top(1) * from KhachHang where TaiKhoan='" + taikhoan + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dta = cmd.ExecuteReader();
            var result = dta.Read();
            var model = new CustomerDTO();
            if (result)
            {
                model.DiaChi = dta["DiaChi"].ToString();
                model.Email = dta["Email"].ToString();
                model.MaKH = int.Parse(dta["MaKH"].ToString());
                model.SDT = dta["SDT"].ToString();
                model.TaiKhoan = dta["TaiKhoan"].ToString();
                model.TenKH = dta["TenKhachHang"].ToString();
            }

            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            return model;
        }


    }
}

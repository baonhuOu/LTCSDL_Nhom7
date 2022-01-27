using LTCSDL_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;


namespace LTCSDL.DAL
{
    public class GiohangDAL
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        public GiohangDAL()
        {
            string cnStr = $"Data Source={Utility.DB_NAME};Initial Catalog=QuanCF;Integrated Security=True";
            cnn = new SqlConnection(cnStr);
        }
        public bool Register(GiohangDTO gioHang)
        {
            StringBuilder sb = new StringBuilder("Insert into GioHang(MaGioHang,MaMon,SoLuong, DonGia)");
            sb.AppendFormat("values('{0}', '{1}', '{2}', '{3}')", gioHang.MaGioHang, gioHang.MaMon, gioHang.SoLuong, gioHang.DonGia);
            sb.Append("select @@IDENTITY as MaGioHang");
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

        //public GiohangDTO getInfoCustomer(string taikhoan)
        //{
            //return new GiohangDTO();
        //}
    }
}

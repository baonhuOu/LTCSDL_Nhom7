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
    public class MonAnDAL
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        public MonAnDAL()
        {
            string cnStr = $"Data Source={Utility.DB_NAME};Initial Catalog=QuanCF;Integrated Security=True";
            cnn = new SqlConnection(cnStr);
        }


        public List<MonAnDTO> GetAllMonAn()
        {
            string sqlStr = "select * from MonAn";
            List<MonAnDTO> lst = new List<MonAnDTO>();
            try
            {
                cnn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sqlStr;
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MonAnDTO monAn = new MonAnDTO();
                    monAn.MaMon = int.Parse(reader["MaMon"].ToString());
                    monAn.TenMon = reader["TenMon"].ToString();
                    monAn.GiaMon = decimal.Parse(reader["GiaMon"].ToString());
                    monAn.ChuThich = reader["ChuThich"].ToString();
                    monAn.MaLoai = int.Parse(reader["MaLoai"].ToString());
                    monAn.HinhAnh = reader["HinhAnh"].ToString();
                    lst.Add(monAn);
                }
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            catch (Exception e)
            {
                lst = null;
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return lst;
        }
    }
}

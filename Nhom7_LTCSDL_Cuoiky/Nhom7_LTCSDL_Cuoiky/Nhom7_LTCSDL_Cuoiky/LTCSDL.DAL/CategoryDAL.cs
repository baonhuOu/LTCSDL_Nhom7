using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using LTCSDL_DTO;

namespace LTCSDL.DAL
{
   public class CategoryDAL
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        
        public CategoryDAL()
        {
            string cnStr = $"Server = Data Source={Utility.DB_NAME};Initial Catalog=QuanCF;Integrated Security=True";
            cnn = new SqlConnection(cnStr);
        }
        public List<ChiTietDonHang> GetAll()
        {
            string sqlStr = "select MaCTDH, MaKH from ChiTietDonHang";
            List<ChiTietDonHang> lst = new List<ChiTietDonHang>();
            try
            {
                cnn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sqlStr;
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ChiTietDonHang CTDH = new ChiTietDonHang();
                    CTDH.MaCTDH = int.Parse(reader["MaCTDH"].ToString());
                    CTDH.MaKH = int.Parse(reader["MaKH"].ToString());
                    //CTDH.MaDDH = reader["MaDDH"].ToString();
                    //CTDH.MaMon = reader["MaMon"].ToString();
                    //CTDH.SoLuong = reader["SoLuong"].ToString();
                    //CTDH.DonGia = reader["DonGia"].ToString();
                    lst.Add(CTDH);
                }    
                    
                   
                cnn.Close();
            
            }
            catch(Exception e)
            {
                lst = null;
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return lst;
        }
        public int Insert(ChiTietDonHang CTDH)
        {
            StringBuilder sb = new StringBuilder("Insert into ChiTietDonHang(MaCTDH, MaKH) ");
            sb.AppendFormat( "values('{0}', '{1}')",  CTDH.MaCTDH, CTDH.MaKH);
            sb.Append("select @@IDENTITY as MaCTDH");
            int res=0;
            try
            {
                cnn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                int newID = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                res = 0;
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return res;




        }    
    }

}

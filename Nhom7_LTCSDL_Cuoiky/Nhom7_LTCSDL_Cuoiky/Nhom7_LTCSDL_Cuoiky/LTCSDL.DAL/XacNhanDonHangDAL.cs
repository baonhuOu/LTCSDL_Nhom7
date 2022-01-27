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
    public class XacNhanDonHangDAL
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public XacNhanDonHangDAL()
        {
            string cnStr = $"Data Source={Utility.DB_NAME};Initial Catalog=QuanCF;Integrated Security=True";
            cnn = new SqlConnection(cnStr);
        }
        public bool XacNhanDonHang(string TenKH, string sdt, string diachi)
        {
            string sql = "select * from DonDatHang where TenKhachHang='" + TenKH + "' SDT='" + sdt + "'DiaChi='" + diachi + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dta = cmd.ExecuteReader();
            var result = dta.Read();
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            return result;
        }


        public bool Register(DonDatHangDTO donDatHang)
        {
            StringBuilder sb = new StringBuilder("Insert into DonDatHang(MaKH,NgayDatHang,TongTien,MaKhuyenMai,TenKhachHang, DiaChi, SDT)");
            sb.AppendFormat("values('{0}', convert(datetime,'{1}',5), '{2}', '{3}', N'{4}', N'{5}', '{6}')", donDatHang.MaKH, donDatHang.NgayDatHang, donDatHang.TongTien, donDatHang.MaKhuyenMai == 0 ? "" : donDatHang.MaKhuyenMai.ToString(), 
                donDatHang.TenKhachHang, donDatHang.DiaChi, donDatHang.SDT);
            sb.Append("select @@IDENTITY as MaDDH");


            try
            {
                cnn.Open();
                cmd = new SqlCommand(sb.ToString(), cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception e)
            {

                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                return false;
            }
        }
        public DonDatHangDTO getInfodonDatHang(string TenKH)
        {
            return new DonDatHangDTO();
        }
    }
}


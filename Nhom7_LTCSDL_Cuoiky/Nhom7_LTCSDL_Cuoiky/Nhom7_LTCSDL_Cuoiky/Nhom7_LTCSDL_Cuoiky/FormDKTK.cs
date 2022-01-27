using LTCSDL.DAL;
using LTCSDL_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_LTCSDL_Cuoiky
{
    public partial class FormDKTK : Form
    {
        CustomerDAL customerDAL;
        public FormDKTK()
        {
            customerDAL = new CustomerDAL();
            InitializeComponent();
        }

        private void FormDKTK_Load(object sender, EventArgs e)
        {

        }

        bool ValidForm()
        {
            // check nhập lại mật khẩu , để trống dữ liệu
            return true;
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!ValidForm())
                return;

            var customer = new CustomerDTO()
            {
                TenKH = txtTenKhachHang.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                MatKhau = txtMatkhau.Text,
                SDT = txtSDT.Text,
                TaiKhoan = txtTaiKhoan.Text
            };
            bool flagRegister = customerDAL.Register(customer);

            if (!flagRegister) { 
                MessageBox.Show("Đăng ký không thành công vui lòng thử lại.");
                return;
            }
            MessageBox.Show("Đăng ký thành công.");
            Formlogin f = new Formlogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

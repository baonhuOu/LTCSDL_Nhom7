using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using LTCSDL.DAL;

namespace Nhom7_LTCSDL_Cuoiky
{
    public partial class Formlogin : Form
    {
        public static string CUSTOMER_CURRENT = "";

        private CustomerDAL customerDAL;
        public Formlogin()
        {
            InitializeComponent();
            customerDAL = new CustomerDAL();
        }

        private void btThoat1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btDN_Click(object sender, EventArgs e)
        {
            var flagLogin = customerDAL.Login(txtTenDN2.Text, txtMK2.Text);

            if (flagLogin)
            {
                CUSTOMER_CURRENT = txtTenDN2.Text;
                FormOD f = new FormOD();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btTaoTKM_Click(object sender, EventArgs e)
        {
            FormDKTK f = new FormDKTK();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }
    }
}

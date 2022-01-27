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
using LTCSDL_DTO;
using LTCSDL.DAL;
using Nhom7_LTCSDL_Cuoiky.Models;

namespace Nhom7_LTCSDL_Cuoiky
{
    public partial class XacNhanDH : Form
    {
        XacNhanDonHangDAL xacNhanDonHangDAL;
        CustomerDAL customerDAL;
        CustomerDTO customer;

        public XacNhanDH()
        {
            xacNhanDonHangDAL = new XacNhanDonHangDAL();
            customerDAL = new CustomerDAL();
            customer = customerDAL.getInfoCustomer(Formlogin.CUSTOMER_CURRENT);
            InitializeComponent();
            txtTenKH.Text = customer.TenKH;
            txtDiaChi.Text = customer.DiaChi;
            txtSDT.Text = customer.SDT;
            lbTongTien.Text = FormOD.Cart.Sum(x => x.DonGia * x.SL).ToString("N0") +  " VNĐ";
          
        }

        private void btDH_Click(object sender, EventArgs e)
        {

            var donDatHang = new DonDatHangDTO()
            {
                TenKhachHang = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                MaKH = customer.MaKH,
                TongTien = (int)FormOD.Cart.Sum(x => x.DonGia * x.SL),
                NgayDatHang = DateTime.Now.ToString("dd/MM/yy hh:mm:ss")
            };
            bool flagRegister = xacNhanDonHangDAL.Register(donDatHang);

            if (flagRegister == false)
            {
                MessageBox.Show("Đặt hàng không thành công.");
                return;
            }
            MessageBox.Show("Đặt hàng thành công!!!!");
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            FormOD.Cart.Clear();
        }

        private void btHuyDH_Click(object sender, EventArgs e)
        {
            FormOD.Cart.Clear();
            this.Close();
        }

        private void XacNhanDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy đơn hàng?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void picTroVe_OD_Click(object sender, EventArgs e)
        {
            FormOD f = new FormOD();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void XacNhanDH_Load(object sender, EventArgs e)
        {
            btTongTien.Enabled = false;
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                btDH.Enabled = false;
            else btDH.Enabled = true;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                btTongTien.Enabled = true;
                btDH.Enabled = false;

            }
            else
            {
                btDH.Enabled = true;
            }

            btTongTien.Enabled = true;

        }       
        private void btTongTien_Click(object sender, EventArgs e)
        {
            
        }

        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }
    }
}

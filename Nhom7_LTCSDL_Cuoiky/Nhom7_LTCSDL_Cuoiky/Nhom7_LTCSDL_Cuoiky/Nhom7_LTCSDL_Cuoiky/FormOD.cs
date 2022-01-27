using LTCSDL.DAL;
using LTCSDL_DTO;
using Nhom7_LTCSDL_Cuoiky.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_LTCSDL_Cuoiky
{
    public partial class FormOD : Form
    {
        MonAnDAL monAnDAL;
        List<Label> lstlbl = new List<Label>();
        public static List<CartModel> Cart = new List<CartModel>();
        List<MonAnDTO> model;
        public FormOD()
        {
            InitializeComponent();
            monAnDAL = new MonAnDAL();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void LoadMenu()
        {
            model = monAnDAL.GetAllMonAn();
            var lstMaLoai = model.Select(x => x.MaLoai).Distinct().ToList();


            foreach (var maloai in lstMaLoai)
            {
                var index_maloai = lstMaLoai.IndexOf(maloai);
                var width_maloai = 320;
                var x_maloai = ((width_maloai * index_maloai) + (20 * (index_maloai + 1))); //3: 320 * 2 + 20*3
                Panel pnlLoai = new Panel();
                pnlLoai.BorderStyle = BorderStyle.FixedSingle;
                pnlLoai.Location = new Point(x_maloai, 20);
                // pnlLoai.Margin = new Padding(4, 5, 4, 5);
                pnlLoai.Size = new Size(width_maloai, 400);
                // pnlLoai.AutoScroll = true;
                var lstMonAn = model.Where(x => x.MaLoai == maloai).ToList();

                foreach (var monAn in lstMonAn)
                {
                    var index = lstMonAn.IndexOf(monAn);
                    var h = 35;
                    var y = ((h * index) + (10 * (index + 1))); // height + khoảng cách
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(10, y);
                    pic.Size = new Size(35, h);
                    pic.Visible = true;
                    pic.Tag = monAn.MaMon;
                    pic.Image = Image.FromFile($@"{Path.Combine(Directory.GetCurrentDirectory(), monAn.HinhAnh)}");
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    Button btnMon = new Button();
                    btnMon.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
                    btnMon.FlatStyle = FlatStyle.Flat;
                    btnMon.Location = new Point(60, y);
                    btnMon.Margin = new Padding(4, 5, 4, 5);
                    btnMon.Size = new Size(100, h);
                    btnMon.TabIndex = 1;
                    btnMon.Text = monAn.TenMon;
                    btnMon.Tag = monAn.MaMon;
                    btnMon.UseVisualStyleBackColor = true;
                    btnMon.Click += BtnMon_Click;

                    Label lblPrice = new Label();
                    lblPrice.BorderStyle = BorderStyle.FixedSingle;
                    lblPrice.Location = new Point(170, y);
                    lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                    lblPrice.Margin = new Padding(4, 0, 4, 0);
                    lblPrice.Size = new Size(60, h);
                    lblPrice.Tag = monAn.MaMon;
                    lblPrice.Text = monAn.GiaMon.ToString("N0");

                    Label lblSL = new Label();
                    lblSL.BorderStyle = BorderStyle.FixedSingle;
                    lblSL.Location = new Point(240, y);
                    lblSL.TextAlign = ContentAlignment.MiddleCenter;
                    lblSL.Margin = new Padding(4, 0, 4, 0);
                    lblSL.Size = new Size(70, h);
                    lblSL.Tag = monAn.MaMon;
                    lblSL.Text = $"SL: {0}";

                    pnlLoai.Controls.Add(pic);
                    pnlLoai.Controls.Add(btnMon);
                    pnlLoai.Controls.Add(lblPrice);
                    pnlLoai.Controls.Add(lblSL);
                    lstlbl.Add(lblSL);

                }
                grMenu.Controls.Add(pnlLoai);
            }


        }


        private void LoadOD()
        {
            //reset lai text so luong
            foreach (var lbl in lstlbl)
            {
                lbl.Text = "SL: 0";
            }

            foreach (var item in Cart)
            {
                var lbl = lstlbl.FirstOrDefault(x => (int)x.Tag == item.MaMon);

                lbl.Text = "SL: " + item.SL.ToString("N0");
            }
        }

        private void BtnMon_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var maMon = (int)btn.Tag;
            var lbl = lstlbl.FirstOrDefault(x => (int)x.Tag == maMon);
            var checkCart = Cart.FirstOrDefault(x => x.MaMon == maMon);
            var mon = model.FirstOrDefault(x => x.MaMon == maMon);
            if (checkCart == null)
            {
                Cart.Add(new CartModel()
                {
                    MaMon = maMon,
                    DonGia = mon.GiaMon,
                    SL = 1,
                    TaiKhoan = Formlogin.CUSTOMER_CURRENT
                });
                lbl.Text = "SL: 1";
            }
            else
            {
                checkCart.SL += 1;
                lbl.Text = "SL: " + checkCart.SL.ToString("N0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbFFOrder.Text = "       SEVEN_CAFE and  CAKE        ";

            LoadMenu();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            XacNhanDH f = new XacNhanDH();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy order?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFFOrder.Text = lbFFOrder.Text.Substring(1) + lbFFOrder.Text.Substring(0, 1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (this.gVOrder.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.gVOrder.SelectedRows)
                {
                    //gVOrder.Rows.RemoveAt(item.Index);
                    var ma = int.Parse(item.Cells[0].Value.ToString());
                    var item_cart = Cart.FirstOrDefault(x => x.MaMon == ma);
                    Cart.Remove(item_cart);
                    LoadDataGV();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Chú ý");
            }

        }

        private void lbGiaCfDen_Click(object sender, EventArgs e)
        {

        }

        private void btCafeDen_Click(object sender, EventArgs e)
        {

        }

        private void grMenu_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOD();
            LoadDataGV();
        }

        private void LoadDataGV()
        {
            var lst = new List<OrderCardGVModel>();
            var sum = 0;
            foreach (var item in Cart)
            {
                var mon = model.FirstOrDefault(x => x.MaMon == item.MaMon);
                var row = new OrderCardGVModel()
                {
                    DonGia = mon.GiaMon.ToString("N0"),
                    MaMon = mon.MaMon,
                    SoLuong = item.SL.ToString("N0"),
                    TenMon = mon.TenMon,
                    ThanhTien = (mon.GiaMon * item.SL).ToString("N0")

                };
                sum += int.Parse(mon.GiaMon.ToString()) * item.SL;
                lst.Add(row);
            }
            gVOrder.DataSource = lst;
            gVOrder.Columns["MaMon"].Visible = true;
        }

        private void gVOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

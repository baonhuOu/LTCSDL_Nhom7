
namespace Nhom7_LTCSDL_Cuoiky
{
    partial class XacNhanDH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XacNhanDH));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTongTien = new System.Windows.Forms.Button();
            this.btDH = new System.Windows.Forms.Button();
            this.btHuyDH = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.picTroVe_OD = new System.Windows.Forms.PictureBox();
            this.picShipper = new System.Windows.Forms.PictureBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.dpkNgayDat = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe_OD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShipper)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông Tin Giao Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(191, 260);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(191, 208);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(240, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(191, 148);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(240, 20);
            this.txtTenKH.TabIndex = 0;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên khách hàng:";
            // 
            // btTongTien
            // 
            this.btTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btTongTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTongTien.ForeColor = System.Drawing.Color.White;
            this.btTongTien.Location = new System.Drawing.Point(16, 77);
            this.btTongTien.Name = "btTongTien";
            this.btTongTien.Size = new System.Drawing.Size(93, 35);
            this.btTongTien.TabIndex = 15;
            this.btTongTien.Text = "Tổng tiền: ";
            this.btTongTien.UseVisualStyleBackColor = false;
            this.btTongTien.Click += new System.EventHandler(this.btTongTien_Click);
            // 
            // btDH
            // 
            this.btDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDH.ForeColor = System.Drawing.Color.White;
            this.btDH.Location = new System.Drawing.Point(80, 329);
            this.btDH.Name = "btDH";
            this.btDH.Size = new System.Drawing.Size(144, 35);
            this.btDH.TabIndex = 3;
            this.btDH.Text = "Đặt hàng";
            this.btDH.UseVisualStyleBackColor = false;
            this.btDH.Click += new System.EventHandler(this.btDH_Click);
            // 
            // btHuyDH
            // 
            this.btHuyDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btHuyDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuyDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuyDH.ForeColor = System.Drawing.Color.White;
            this.btHuyDH.Location = new System.Drawing.Point(422, 329);
            this.btHuyDH.Name = "btHuyDH";
            this.btHuyDH.Size = new System.Drawing.Size(144, 35);
            this.btHuyDH.TabIndex = 4;
            this.btHuyDH.Text = "Hủy đơn hàng";
            this.btHuyDH.UseVisualStyleBackColor = false;
            this.btHuyDH.Click += new System.EventHandler(this.btHuyDH_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 35);
            this.label13.TabIndex = 17;
            this.label13.Text = "Thank You !";
            // 
            // picTroVe_OD
            // 
            this.picTroVe_OD.Image = global::Nhom7_LTCSDL_Cuoiky.Properties.Resources.mũi_tên;
            this.picTroVe_OD.Location = new System.Drawing.Point(585, 24);
            this.picTroVe_OD.Name = "picTroVe_OD";
            this.picTroVe_OD.Size = new System.Drawing.Size(43, 39);
            this.picTroVe_OD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTroVe_OD.TabIndex = 19;
            this.picTroVe_OD.TabStop = false;
            this.picTroVe_OD.Click += new System.EventHandler(this.picTroVe_OD_Click);
            // 
            // picShipper
            // 
            this.picShipper.Image = global::Nhom7_LTCSDL_Cuoiky.Properties.Resources.SP;
            this.picShipper.Location = new System.Drawing.Point(462, 101);
            this.picShipper.Name = "picShipper";
            this.picShipper.Size = new System.Drawing.Size(166, 179);
            this.picShipper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShipper.TabIndex = 18;
            this.picShipper.TabStop = false;
            // 
            // lbTongTien
            // 
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongTien.Location = new System.Drawing.Point(124, 77);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(89, 34);
            this.lbTongTien.TabIndex = 20;
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTongTien.Click += new System.EventHandler(this.lbTongTien_Click);
            // 
            // dpkNgayDat
            // 
            this.dpkNgayDat.Location = new System.Drawing.Point(232, 83);
            this.dpkNgayDat.Name = "dpkNgayDat";
            this.dpkNgayDat.Size = new System.Drawing.Size(200, 20);
            this.dpkNgayDat.TabIndex = 21;
            // 
            // XacNhanDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(665, 413);
            this.Controls.Add(this.dpkNgayDat);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.picTroVe_OD);
            this.Controls.Add(this.picShipper);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btHuyDH);
            this.Controls.Add(this.btDH);
            this.Controls.Add(this.btTongTien);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XacNhanDH";
            this.Text = "XacNhanDH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XacNhanDH_FormClosing);
            this.Load += new System.EventHandler(this.XacNhanDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe_OD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShipper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTongTien;
        private System.Windows.Forms.Button btDH;
        private System.Windows.Forms.Button btHuyDH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox picShipper;
        private System.Windows.Forms.PictureBox picTroVe_OD;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DateTimePicker dpkNgayDat;
    }
}
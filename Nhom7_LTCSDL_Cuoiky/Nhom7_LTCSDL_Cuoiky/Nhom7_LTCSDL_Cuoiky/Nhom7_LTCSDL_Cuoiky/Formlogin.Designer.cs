
namespace Nhom7_LTCSDL_Cuoiky
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.picLogo4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTaoTKM = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.btThoat1 = new System.Windows.Forms.Button();
            this.txtTenDN2 = new System.Windows.Forms.TextBox();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo4)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo4
            // 
            this.picLogo4.Image = global::Nhom7_LTCSDL_Cuoiky.Properties.Resources.logo;
            this.picLogo4.Location = new System.Drawing.Point(12, 12);
            this.picLogo4.Name = "picLogo4";
            this.picLogo4.Size = new System.Drawing.Size(100, 80);
            this.picLogo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo4.TabIndex = 0;
            this.picLogo4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "MỜI BẠN ĐĂNG NHẬP TÀI KHOẢN!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÊN ĐĂNG NHẬP ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "MẬT KHẨU ";
            // 
            // btTaoTKM
            // 
            this.btTaoTKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btTaoTKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaoTKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoTKM.ForeColor = System.Drawing.Color.White;
            this.btTaoTKM.Location = new System.Drawing.Point(27, 266);
            this.btTaoTKM.Name = "btTaoTKM";
            this.btTaoTKM.Size = new System.Drawing.Size(144, 35);
            this.btTaoTKM.TabIndex = 4;
            this.btTaoTKM.Text = "Tạo Tài Khoản mới ";
            this.btTaoTKM.UseVisualStyleBackColor = false;
            this.btTaoTKM.Click += new System.EventHandler(this.btTaoTKM_Click);
            // 
            // btDN
            // 
            this.btDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btDN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.ForeColor = System.Drawing.Color.White;
            this.btDN.Location = new System.Drawing.Point(191, 266);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(108, 35);
            this.btDN.TabIndex = 2;
            this.btDN.Text = "Đăng nhập";
            this.btDN.UseVisualStyleBackColor = false;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // btThoat1
            // 
            this.btThoat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btThoat1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat1.ForeColor = System.Drawing.Color.White;
            this.btThoat1.Location = new System.Drawing.Point(323, 266);
            this.btThoat1.Name = "btThoat1";
            this.btThoat1.Size = new System.Drawing.Size(108, 35);
            this.btThoat1.TabIndex = 3;
            this.btThoat1.Text = "Thoát";
            this.btThoat1.UseVisualStyleBackColor = false;
            this.btThoat1.Click += new System.EventHandler(this.btThoat1_Click);
            // 
            // txtTenDN2
            // 
            this.txtTenDN2.Location = new System.Drawing.Point(191, 133);
            this.txtTenDN2.Name = "txtTenDN2";
            this.txtTenDN2.Size = new System.Drawing.Size(240, 20);
            this.txtTenDN2.TabIndex = 0;
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(191, 193);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(240, 20);
            this.txtMK2.TabIndex = 1;
            this.txtMK2.UseSystemPasswordChar = true;
            // 
            // Formlogin
            // 
            this.AcceptButton = this.btDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btThoat1;
            this.ClientSize = new System.Drawing.Size(518, 342);
            this.Controls.Add(this.txtMK2);
            this.Controls.Add(this.txtTenDN2);
            this.Controls.Add(this.btThoat1);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.btTaoTKM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formlogin";
            this.Text = "Formlogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formlogin_FormClosing);
            this.Load += new System.EventHandler(this.Formlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTaoTKM;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.Button btThoat1;
        private System.Windows.Forms.TextBox txtTenDN2;
        private System.Windows.Forms.TextBox txtMK2;
    }
}
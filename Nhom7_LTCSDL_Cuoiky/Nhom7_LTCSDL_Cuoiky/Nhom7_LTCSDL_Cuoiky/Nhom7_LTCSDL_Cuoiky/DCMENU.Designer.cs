
namespace Nhom7_LTCSDL_Cuoiky
{
    partial class DCMENU
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
            this.dtMenu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMA = new System.Windows.Forms.TextBox();
            this.gVCSMenu = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDuongDan = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVCSMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMenu
            // 
            this.dtMenu.Location = new System.Drawing.Point(450, 356);
            this.dtMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dtMenu.Name = "dtMenu";
            this.dtMenu.Size = new System.Drawing.Size(151, 20);
            this.dtMenu.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(43, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ảnh";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giá";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(557, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chỉnh sửa Menu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên món ăn";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(189, 302);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(182, 20);
            this.txtGia.TabIndex = 11;
            // 
            // txtTenMA
            // 
            this.txtTenMA.Location = new System.Drawing.Point(189, 258);
            this.txtTenMA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenMA.Name = "txtTenMA";
            this.txtTenMA.Size = new System.Drawing.Size(182, 20);
            this.txtTenMA.TabIndex = 12;
            // 
            // gVCSMenu
            // 
            this.gVCSMenu.BackgroundColor = System.Drawing.Color.White;
            this.gVCSMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVCSMenu.Location = new System.Drawing.Point(43, 67);
            this.gVCSMenu.Margin = new System.Windows.Forms.Padding(2);
            this.gVCSMenu.Name = "gVCSMenu";
            this.gVCSMenu.RowHeadersWidth = 51;
            this.gVCSMenu.RowTemplate.Height = 24;
            this.gVCSMenu.Size = new System.Drawing.Size(557, 167);
            this.gVCSMenu.TabIndex = 10;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.SeaShell;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Location = new System.Drawing.Point(550, 246);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(50, 35);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // btDuongDan
            // 
            this.btDuongDan.BackColor = System.Drawing.Color.SeaShell;
            this.btDuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDuongDan.Location = new System.Drawing.Point(200, 327);
            this.btDuongDan.Margin = new System.Windows.Forms.Padding(2);
            this.btDuongDan.Name = "btDuongDan";
            this.btDuongDan.Size = new System.Drawing.Size(91, 37);
            this.btDuongDan.TabIndex = 7;
            this.btDuongDan.Text = "Đường dẫn";
            this.btDuongDan.UseVisualStyleBackColor = false;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.SeaShell;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(479, 247);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(50, 35);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.SeaShell;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Location = new System.Drawing.Point(404, 247);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(50, 35);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // DCMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(618, 386);
            this.Controls.Add(this.dtMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenMA);
            this.Controls.Add(this.gVCSMenu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btDuongDan);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Name = "DCMENU";
            this.Text = "DCMENU";
            ((System.ComponentModel.ISupportInitialize)(this.gVCSMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMA;
        private System.Windows.Forms.DataGridView gVCSMenu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btDuongDan;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
    }
}

namespace Nhom7_LTCSDL_Cuoiky
{
    partial class FormOD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOD));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.grMenu = new System.Windows.Forms.GroupBox();
            this.lbFFOrder = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.gVOrder = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.picLogo2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Controls.Add(this.tabCart);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 564);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabMenu.Controls.Add(this.grMenu);
            this.tabMenu.Controls.Add(this.lbFFOrder);
            this.tabMenu.Controls.Add(this.picLogo);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1192, 538);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // grMenu
            // 
            this.grMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.grMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grMenu.Location = new System.Drawing.Point(3, 103);
            this.grMenu.Name = "grMenu";
            this.grMenu.Size = new System.Drawing.Size(1415, 439);
            this.grMenu.TabIndex = 2;
            this.grMenu.TabStop = false;
            this.grMenu.Text = "MENU ";
            this.grMenu.Enter += new System.EventHandler(this.grMenu_Enter);
            // 
            // lbFFOrder
            // 
            this.lbFFOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFFOrder.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFFOrder.ForeColor = System.Drawing.Color.Black;
            this.lbFFOrder.Location = new System.Drawing.Point(112, 20);
            this.lbFFOrder.Name = "lbFFOrder";
            this.lbFFOrder.Size = new System.Drawing.Size(562, 67);
            this.lbFFOrder.TabIndex = 1;
            this.lbFFOrder.Text = "SEVEN_CAFE and  CAKE  ";
            this.lbFFOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Nhom7_LTCSDL_Cuoiky.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(6, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 91);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tabCart
            // 
            this.tabCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabCart.Controls.Add(this.label14);
            this.tabCart.Controls.Add(this.label13);
            this.tabCart.Controls.Add(this.btClose);
            this.tabCart.Controls.Add(this.btOrder);
            this.tabCart.Controls.Add(this.btDelete);
            this.tabCart.Controls.Add(this.gVOrder);
            this.tabCart.Controls.Add(this.label12);
            this.tabCart.Controls.Add(this.picLogo2);
            this.tabCart.Location = new System.Drawing.Point(4, 22);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(1192, 538);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "order cart";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(517, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 35);
            this.label14.TabIndex = 18;
            this.label14.Text = "Thank You !";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(507, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 35);
            this.label13.TabIndex = 4;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(525, 397);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(111, 38);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.ForeColor = System.Drawing.Color.White;
            this.btOrder.Location = new System.Drawing.Point(304, 397);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(111, 38);
            this.btOrder.TabIndex = 2;
            this.btOrder.Text = "ORDER";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(53, 397);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(111, 38);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // gVOrder
            // 
            this.gVOrder.BackgroundColor = System.Drawing.Color.White;
            this.gVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVOrder.Location = new System.Drawing.Point(0, 118);
            this.gVOrder.Name = "gVOrder";
            this.gVOrder.RowHeadersWidth = 62;
            this.gVOrder.Size = new System.Drawing.Size(705, 233);
            this.gVOrder.TabIndex = 1;
            this.gVOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVOrder_CellClick);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("SimSun", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(247, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 51);
            this.label12.TabIndex = 0;
            this.label12.Text = "ORDER CART";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLogo2
            // 
            this.picLogo2.Image = global::Nhom7_LTCSDL_Cuoiky.Properties.Resources.logo;
            this.picLogo2.Location = new System.Drawing.Point(37, 19);
            this.picLogo2.Name = "picLogo2";
            this.picLogo2.Size = new System.Drawing.Size(100, 74);
            this.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo2.TabIndex = 3;
            this.picLogo2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormOD
            // 
            this.AcceptButton = this.btOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(1084, 487);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOD";
            this.Text = "FormORDER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOD_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.GroupBox grMenu;
        private System.Windows.Forms.Label lbFFOrder;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox picLogo2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView gVOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
    }
}


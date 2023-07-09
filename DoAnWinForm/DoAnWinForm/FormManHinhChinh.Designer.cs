namespace DoAnWinForm
{
    partial class FormManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManHinhChinh));
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnQuanLySanPham = new System.Windows.Forms.Button();
            this.btnQuanLyBan = new System.Windows.Forms.Button();
            this.btnNhanVienQuanLy = new System.Windows.Forms.Button();
            this.btnCapNhatSanPham = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(0, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 39);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnQuanLySanPham
            // 
            this.btnQuanLySanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySanPham.Location = new System.Drawing.Point(163, 12);
            this.btnQuanLySanPham.Name = "btnQuanLySanPham";
            this.btnQuanLySanPham.Size = new System.Drawing.Size(235, 39);
            this.btnQuanLySanPham.TabIndex = 2;
            this.btnQuanLySanPham.Text = "QUẢN LÝ SẢN PHẨM";
            this.btnQuanLySanPham.UseVisualStyleBackColor = true;
            this.btnQuanLySanPham.Click += new System.EventHandler(this.btnQuanLySanPham_Click);
            // 
            // btnQuanLyBan
            // 
            this.btnQuanLyBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBan.Location = new System.Drawing.Point(422, 12);
            this.btnQuanLyBan.Name = "btnQuanLyBan";
            this.btnQuanLyBan.Size = new System.Drawing.Size(197, 39);
            this.btnQuanLyBan.TabIndex = 3;
            this.btnQuanLyBan.Text = "QUẢN LÝ BÀN";
            this.btnQuanLyBan.UseVisualStyleBackColor = true;
            this.btnQuanLyBan.Click += new System.EventHandler(this.btnQuanLyBan_Click);
            // 
            // btnNhanVienQuanLy
            // 
            this.btnNhanVienQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVienQuanLy.Location = new System.Drawing.Point(51, 57);
            this.btnNhanVienQuanLy.Name = "btnNhanVienQuanLy";
            this.btnNhanVienQuanLy.Size = new System.Drawing.Size(244, 39);
            this.btnNhanVienQuanLy.TabIndex = 4;
            this.btnNhanVienQuanLy.Text = "NHÂN VIÊN QUẢN LÝ";
            this.btnNhanVienQuanLy.UseVisualStyleBackColor = true;
            this.btnNhanVienQuanLy.Click += new System.EventHandler(this.btnNhanVienQuanLy_Click);
            // 
            // btnCapNhatSanPham
            // 
            this.btnCapNhatSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSanPham.Location = new System.Drawing.Point(337, 57);
            this.btnCapNhatSanPham.Name = "btnCapNhatSanPham";
            this.btnCapNhatSanPham.Size = new System.Drawing.Size(256, 39);
            this.btnCapNhatSanPham.TabIndex = 5;
            this.btnCapNhatSanPham.Text = "CẬP NHẬT SẢN PHẨM";
            this.btnCapNhatSanPham.UseVisualStyleBackColor = true;
            this.btnCapNhatSanPham.Click += new System.EventHandler(this.btnCapNhatSanPham_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(663, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(136, 39);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(638, 57);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(197, 39);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // FormManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCapNhatSanPham);
            this.Controls.Add(this.btnNhanVienQuanLy);
            this.Controls.Add(this.btnQuanLyBan);
            this.Controls.Add(this.btnQuanLySanPham);
            this.Controls.Add(this.btnOrder);
            this.Name = "FormManHinhChinh";
            this.Text = "FormManHinhChinh";
            this.Load += new System.EventHandler(this.FormManHinhChinh_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnQuanLySanPham;
        private System.Windows.Forms.Button btnQuanLyBan;
        private System.Windows.Forms.Button btnNhanVienQuanLy;
        private System.Windows.Forms.Button btnCapNhatSanPham;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDangXuat;
    }
}
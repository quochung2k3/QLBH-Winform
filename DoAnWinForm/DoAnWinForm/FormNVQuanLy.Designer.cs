namespace DoAnWinForm
{
    partial class FormNVQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNVQuanLy));
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaySinhNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChucVuNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdtNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaChiNhanh = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiNhanhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLuuKH.Location = new System.Drawing.Point(694, 462);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(137, 58);
            this.btnLuuKH.TabIndex = 37;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemKH.Location = new System.Drawing.Point(65, 462);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(137, 58);
            this.btnThemKH.TabIndex = 35;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.NgaySinhKH,
            this.SDT});
            this.dgvKhachHang.Location = new System.Drawing.Point(32, 129);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(875, 303);
            this.dgvKhachHang.TabIndex = 34;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.Frozen = true;
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "Ten";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 125;
            // 
            // NgaySinhKH
            // 
            this.NgaySinhKH.DataPropertyName = "NgaySinh";
            this.NgaySinhKH.HeaderText = "Ngày Sinh";
            this.NgaySinhKH.MinimumWidth = 6;
            this.NgaySinhKH.Name = "NgaySinhKH";
            this.NgaySinhKH.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // txtNgaySinhNV
            // 
            this.txtNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinhNV.Location = new System.Drawing.Point(570, 130);
            this.txtNgaySinhNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgaySinhNV.Name = "txtNgaySinhNV";
            this.txtNgaySinhNV.Size = new System.Drawing.Size(173, 30);
            this.txtNgaySinhNV.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(410, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh:";
            // 
            // txtChucVuNV
            // 
            this.txtChucVuNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVuNV.Location = new System.Drawing.Point(188, 120);
            this.txtChucVuNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChucVuNV.Name = "txtChucVuNV";
            this.txtChucVuNV.Size = new System.Drawing.Size(173, 30);
            this.txtChucVuNV.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(19, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Chức vụ:";
            // 
            // txtsdtNV
            // 
            this.txtsdtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdtNV.Location = new System.Drawing.Point(570, 73);
            this.txtsdtNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsdtNV.Name = "txtsdtNV";
            this.txtsdtNV.Size = new System.Drawing.Size(173, 30);
            this.txtsdtNV.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(410, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số điện thoại:";
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSuaKH.Location = new System.Drawing.Point(378, 462);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(172, 58);
            this.btnSuaKH.TabIndex = 36;
            this.btnSuaKH.Text = "Cập Nhật";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(673, 81);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(234, 30);
            this.txtNgaySinh.TabIndex = 33;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(673, 24);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(234, 30);
            this.txtSDT.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(514, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(215, 75);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(234, 30);
            this.txtTenKH.TabIndex = 29;
            // 
            // txtMaChiNhanh
            // 
            this.txtMaChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChiNhanh.Location = new System.Drawing.Point(771, 56);
            this.txtMaChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaChiNhanh.Name = "txtMaChiNhanh";
            this.txtMaChiNhanh.Size = new System.Drawing.Size(153, 30);
            this.txtMaChiNhanh.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(973, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 30);
            this.textBox1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(770, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Mã Chi Nhánh:";
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLuuNV.Location = new System.Drawing.Point(738, 481);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(143, 50);
            this.btnLuuNV.TabIndex = 40;
            this.btnLuuNV.Text = "Lưu";
            this.btnLuuNV.UseVisualStyleBackColor = true;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSuaNV.Location = new System.Drawing.Point(380, 483);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(186, 46);
            this.btnSuaNV.TabIndex = 39;
            this.btnSuaNV.Text = "Cập Nhật";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemNV.Location = new System.Drawing.Point(85, 485);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(109, 42);
            this.btnThemNV.TabIndex = 38;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click_1);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.tenNV,
            this.LoaiNhanVien,
            this.DiaChi,
            this.SoDT,
            this.MaChiNhanhNV,
            this.NgaySinh});
            this.dgvNhanVien.Location = new System.Drawing.Point(24, 169);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(903, 303);
            this.dgvNhanVien.TabIndex = 25;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.Frozen = true;
            this.maNV.HeaderText = "Mã NV";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 125;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "ten";
            this.tenNV.HeaderText = "Tên NV";
            this.tenNV.MinimumWidth = 6;
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 125;
            // 
            // LoaiNhanVien
            // 
            this.LoaiNhanVien.DataPropertyName = "LoaiNhanVien";
            this.LoaiNhanVien.HeaderText = "Loại NV";
            this.LoaiNhanVien.MinimumWidth = 6;
            this.LoaiNhanVien.Name = "LoaiNhanVien";
            this.LoaiNhanVien.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SDT";
            this.SoDT.HeaderText = "SDT";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.Width = 125;
            // 
            // MaChiNhanhNV
            // 
            this.MaChiNhanhNV.DataPropertyName = "MaChiNhanh";
            this.MaChiNhanhNV.HeaderText = "Mã Chi Nhánh";
            this.MaChiNhanhNV.MinimumWidth = 6;
            this.MaChiNhanhNV.Name = "MaChiNhanhNV";
            this.MaChiNhanhNV.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(514, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngày sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(27, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tên khách hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(27, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Mã khách hàng:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(188, 65);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(173, 30);
            this.txtTenNV.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNV.Location = new System.Drawing.Point(570, 19);
            this.txtDiaChiNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(173, 30);
            this.txtDiaChiNV.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(410, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Địa chỉ:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(188, 17);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(173, 30);
            this.txtMaNV.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(215, 27);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(234, 30);
            this.txtMaKH.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMaChiNhanh);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnLuuNV);
            this.tabPage1.Controls.Add(this.btnSuaNV);
            this.tabPage1.Controls.Add(this.btnThemNV);
            this.tabPage1.Controls.Add(this.dgvNhanVien);
            this.tabPage1.Controls.Add(this.txtNgaySinhNV);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtChucVuNV);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtsdtNV);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTenNV);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDiaChiNV);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMaNV);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLuuKH);
            this.tabPage2.Controls.Add(this.btnSuaKH);
            this.tabPage2.Controls.Add(this.btnThemKH);
            this.tabPage2.Controls.Add(this.dgvKhachHang);
            this.tabPage2.Controls.Add(this.txtNgaySinh);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtSDT);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtTenKH);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtMaKH);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Khách Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // FormNVQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(987, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormNVQuanLy";
            this.Text = "FormNVQuanLy";
            this.Load += new System.EventHandler(this.FormNVQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.TextBox txtNgaySinhNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChucVuNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdtNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaChiNhanh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiNhanhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
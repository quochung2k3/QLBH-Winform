namespace DoAnWinForm
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.tabBan = new System.Windows.Forms.TabControl();
            this.Tang1 = new System.Windows.Forms.TabPage();
            this.dtgvKV1 = new System.Windows.Forms.DataGridView();
            this.Tang2 = new System.Windows.Forms.TabPage();
            this.dtgvKV2 = new System.Windows.Forms.DataGridView();
            this.BanCong = new System.Windows.Forms.TabPage();
            this.dtgvKV3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayThang = new System.Windows.Forms.TextBox();
            this.lviDanhMucOrder = new System.Windows.Forms.ListView();
            this.MaDoDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenDoDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnChonBan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDoDung = new System.Windows.Forms.DataGridView();
            this.dtgvMaDoDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvTenDoDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLoaiDoDung = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.tabBan.SuspendLayout();
            this.Tang1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKV1)).BeginInit();
            this.Tang2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKV2)).BeginInit();
            this.BanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoDung)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBan
            // 
            this.tabBan.Controls.Add(this.Tang1);
            this.tabBan.Controls.Add(this.Tang2);
            this.tabBan.Controls.Add(this.BanCong);
            this.tabBan.Location = new System.Drawing.Point(8, 69);
            this.tabBan.Name = "tabBan";
            this.tabBan.SelectedIndex = 0;
            this.tabBan.Size = new System.Drawing.Size(451, 462);
            this.tabBan.TabIndex = 2;
            // 
            // Tang1
            // 
            this.Tang1.Controls.Add(this.dtgvKV1);
            this.Tang1.Location = new System.Drawing.Point(4, 25);
            this.Tang1.Name = "Tang1";
            this.Tang1.Padding = new System.Windows.Forms.Padding(3);
            this.Tang1.Size = new System.Drawing.Size(443, 433);
            this.Tang1.TabIndex = 0;
            this.Tang1.Tag = "0";
            this.Tang1.Text = "Tầng 1";
            this.Tang1.UseVisualStyleBackColor = true;
            this.Tang1.Click += new System.EventHandler(this.tvDanhSachBan_Click);
            // 
            // dtgvKV1
            // 
            this.dtgvKV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKV1.Location = new System.Drawing.Point(13, 19);
            this.dtgvKV1.Name = "dtgvKV1";
            this.dtgvKV1.RowHeadersWidth = 51;
            this.dtgvKV1.RowTemplate.Height = 24;
            this.dtgvKV1.Size = new System.Drawing.Size(417, 458);
            this.dtgvKV1.TabIndex = 1;
            this.dtgvKV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKV1_CellClick);
            // 
            // Tang2
            // 
            this.Tang2.Controls.Add(this.dtgvKV2);
            this.Tang2.Location = new System.Drawing.Point(4, 25);
            this.Tang2.Name = "Tang2";
            this.Tang2.Padding = new System.Windows.Forms.Padding(3);
            this.Tang2.Size = new System.Drawing.Size(443, 433);
            this.Tang2.TabIndex = 1;
            this.Tang2.Tag = "1";
            this.Tang2.Text = "Tầng 2";
            this.Tang2.UseVisualStyleBackColor = true;
            // 
            // dtgvKV2
            // 
            this.dtgvKV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKV2.Location = new System.Drawing.Point(12, 19);
            this.dtgvKV2.Name = "dtgvKV2";
            this.dtgvKV2.RowHeadersWidth = 51;
            this.dtgvKV2.RowTemplate.Height = 24;
            this.dtgvKV2.Size = new System.Drawing.Size(417, 458);
            this.dtgvKV2.TabIndex = 0;
            this.dtgvKV2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKV2_CellClick);
            // 
            // BanCong
            // 
            this.BanCong.Controls.Add(this.dtgvKV3);
            this.BanCong.Location = new System.Drawing.Point(4, 25);
            this.BanCong.Name = "BanCong";
            this.BanCong.Padding = new System.Windows.Forms.Padding(3);
            this.BanCong.Size = new System.Drawing.Size(443, 433);
            this.BanCong.TabIndex = 2;
            this.BanCong.Tag = "2";
            this.BanCong.Text = "Ban Công";
            this.BanCong.UseVisualStyleBackColor = true;
            // 
            // dtgvKV3
            // 
            this.dtgvKV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKV3.Location = new System.Drawing.Point(13, 19);
            this.dtgvKV3.Name = "dtgvKV3";
            this.dtgvKV3.RowHeadersWidth = 51;
            this.dtgvKV3.RowTemplate.Height = 24;
            this.dtgvKV3.Size = new System.Drawing.Size(417, 401);
            this.dtgvKV3.TabIndex = 1;
            this.dtgvKV3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKV3_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày Tháng:";
            // 
            // txtNgayThang
            // 
            this.txtNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThang.Location = new System.Drawing.Point(153, 24);
            this.txtNgayThang.Name = "txtNgayThang";
            this.txtNgayThang.Size = new System.Drawing.Size(250, 30);
            this.txtNgayThang.TabIndex = 2;
            // 
            // lviDanhMucOrder
            // 
            this.lviDanhMucOrder.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lviDanhMucOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaDoDung,
            this.TenDoDung,
            this.SoTien});
            this.lviDanhMucOrder.FullRowSelect = true;
            this.lviDanhMucOrder.GridLines = true;
            this.lviDanhMucOrder.HideSelection = false;
            this.lviDanhMucOrder.HotTracking = true;
            this.lviDanhMucOrder.HoverSelection = true;
            this.lviDanhMucOrder.Location = new System.Drawing.Point(466, 448);
            this.lviDanhMucOrder.Name = "lviDanhMucOrder";
            this.lviDanhMucOrder.Size = new System.Drawing.Size(445, 143);
            this.lviDanhMucOrder.TabIndex = 6;
            this.lviDanhMucOrder.UseCompatibleStateImageBehavior = false;
            this.lviDanhMucOrder.View = System.Windows.Forms.View.Details;
            this.lviDanhMucOrder.SelectedIndexChanged += new System.EventHandler(this.lviDanhMucOrder_SelectedIndexChanged);
            // 
            // MaDoDung
            // 
            this.MaDoDung.Text = "Mã đồ dùng";
            this.MaDoDung.Width = 80;
            // 
            // TenDoDung
            // 
            this.TenDoDung.Text = "Tên đồ dùng";
            this.TenDoDung.Width = 140;
            // 
            // SoTien
            // 
            this.SoTien.Text = "Số tiền";
            this.SoTien.Width = 110;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXacNhan.Location = new System.Drawing.Point(744, 597);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(167, 45);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHuy.Location = new System.Drawing.Point(466, 597);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(167, 45);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaBan
            // 
            this.txtMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.Location = new System.Drawing.Point(114, 603);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(85, 30);
            this.txtMaBan.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(15, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mã Bàn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(370, 604);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(85, 30);
            this.txtMaHD.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(279, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã HD:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThanhToan.Location = new System.Drawing.Point(744, 15);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(167, 60);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnChonBan
            // 
            this.btnChonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonBan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChonBan.Location = new System.Drawing.Point(298, 537);
            this.btnChonBan.Name = "btnChonBan";
            this.btnChonBan.Size = new System.Drawing.Size(157, 52);
            this.btnChonBan.TabIndex = 23;
            this.btnChonBan.Text = "Chọn Bàn";
            this.btnChonBan.UseVisualStyleBackColor = true;
            this.btnChonBan.Click += new System.EventHandler(this.btnChonBan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(484, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Loại đồ dùng:";
            // 
            // dtgvDoDung
            // 
            this.dtgvDoDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvMaDoDung,
            this.dtgvTenDoDung,
            this.dtgvGia,
            this.dtgvTrangThai});
            this.dtgvDoDung.Location = new System.Drawing.Point(466, 130);
            this.dtgvDoDung.Name = "dtgvDoDung";
            this.dtgvDoDung.RowHeadersWidth = 51;
            this.dtgvDoDung.RowTemplate.Height = 24;
            this.dtgvDoDung.Size = new System.Drawing.Size(445, 271);
            this.dtgvDoDung.TabIndex = 26;
            // 
            // dtgvMaDoDung
            // 
            this.dtgvMaDoDung.DataPropertyName = "MaDoDung";
            this.dtgvMaDoDung.Frozen = true;
            this.dtgvMaDoDung.HeaderText = "MaDoDung";
            this.dtgvMaDoDung.MinimumWidth = 6;
            this.dtgvMaDoDung.Name = "dtgvMaDoDung";
            this.dtgvMaDoDung.Width = 125;
            // 
            // dtgvTenDoDung
            // 
            this.dtgvTenDoDung.DataPropertyName = "TenDoDung";
            this.dtgvTenDoDung.HeaderText = "TenDoDung";
            this.dtgvTenDoDung.MinimumWidth = 6;
            this.dtgvTenDoDung.Name = "dtgvTenDoDung";
            this.dtgvTenDoDung.Width = 125;
            // 
            // dtgvGia
            // 
            this.dtgvGia.DataPropertyName = "Gia";
            this.dtgvGia.HeaderText = "Gia";
            this.dtgvGia.MinimumWidth = 6;
            this.dtgvGia.Name = "dtgvGia";
            this.dtgvGia.Width = 125;
            // 
            // dtgvTrangThai
            // 
            this.dtgvTrangThai.DataPropertyName = "TrangThai";
            this.dtgvTrangThai.HeaderText = "TrangThai";
            this.dtgvTrangThai.MinimumWidth = 6;
            this.dtgvTrangThai.Name = "dtgvTrangThai";
            this.dtgvTrangThai.Width = 125;
            // 
            // cboLoaiDoDung
            // 
            this.cboLoaiDoDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiDoDung.FormattingEnabled = true;
            this.cboLoaiDoDung.Items.AddRange(new object[] {
            "Tra",
            "Banh",
            "Ca phe",
            "ALL"});
            this.cboLoaiDoDung.Location = new System.Drawing.Point(644, 89);
            this.cboLoaiDoDung.Name = "cboLoaiDoDung";
            this.cboLoaiDoDung.Size = new System.Drawing.Size(137, 33);
            this.cboLoaiDoDung.TabIndex = 27;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChon.Location = new System.Drawing.Point(798, 407);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(113, 35);
            this.btnChon.TabIndex = 28;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(419, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(595, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(123, 27);
            this.txtMaNV.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(419, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tên Nhân Viên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(595, 52);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(123, 27);
            this.txtTenNV.TabIndex = 17;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(114, 570);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(151, 27);
            this.txtTenKH.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(13, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên KH:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(114, 533);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(151, 27);
            this.txtMaKH.TabIndex = 30;
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(13, 536);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 20);
            this.label.TabIndex = 29;
            this.label.Text = "Mã KH:";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTim.Location = new System.Drawing.Point(798, 87);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(113, 35);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 664);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cboLoaiDoDung);
            this.Controls.Add(this.dtgvDoDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChonBan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lviDanhMucOrder);
            this.Controls.Add(this.txtNgayThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabBan);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.tabBan.ResumeLayout(false);
            this.Tang1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKV1)).EndInit();
            this.Tang2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKV2)).EndInit();
            this.BanCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabBan;
        private System.Windows.Forms.TabPage Tang1;
        private System.Windows.Forms.TabPage Tang2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayThang;
        private System.Windows.Forms.ListView lviDanhMucOrder;
        private System.Windows.Forms.ColumnHeader MaDoDung;
        private System.Windows.Forms.ColumnHeader TenDoDung;
        private System.Windows.Forms.ColumnHeader SoTien;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TabPage BanCong;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dtgvKV2;
        private System.Windows.Forms.DataGridView dtgvKV1;
        private System.Windows.Forms.DataGridView dtgvKV3;
        private System.Windows.Forms.Button btnChonBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvDoDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvMaDoDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvTenDoDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvTrangThai;
        private System.Windows.Forms.ComboBox cboLoaiDoDung;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnTim;
    }
}
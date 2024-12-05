namespace ViDuSQL
{
    partial class Form1
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
            this.grb_tk_nv = new System.Windows.Forms.GroupBox();
            this.btn_tk_nv = new System.Windows.Forms.Button();
            this.cbb_find_pb_nv = new System.Windows.Forms.ComboBox();
            this.cb_phongban = new System.Windows.Forms.CheckBox();
            this.cbb_find_cv_nv = new System.Windows.Forms.ComboBox();
            this.cb_chucvu = new System.Windows.Forms.CheckBox();
            this.txt_find_nv_address = new System.Windows.Forms.TextBox();
            this.cb_diachi = new System.Windows.Forms.CheckBox();
            this.dtp_find_nv_birth = new System.Windows.Forms.DateTimePicker();
            this.cb_ngaysinh = new System.Windows.Forms.CheckBox();
            this.cbb_find_gt_nv = new System.Windows.Forms.ComboBox();
            this.cb_gt = new System.Windows.Forms.CheckBox();
            this.txt_find_nv_name = new System.Windows.Forms.TextBox();
            this.cb_hoten = new System.Windows.Forms.CheckBox();
            this.cb_mnv = new System.Windows.Forms.CheckBox();
            this.nud_nv_id = new System.Windows.Forms.NumericUpDown();
            this.grb_nv_info = new System.Windows.Forms.GroupBox();
            this.cbb_phongban_nv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_chucvu_nv = new System.Windows.Forms.ComboBox();
            this.txt_nv_address = new System.Windows.Forms.TextBox();
            this.dtp_nv_birth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_gioitinh_nv = new System.Windows.Forms.ComboBox();
            this.txt_nv_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_nv_exec = new System.Windows.Forms.GroupBox();
            this.btn_nv_xoa = new System.Windows.Forms.Button();
            this.btn_nv_sua = new System.Windows.Forms.Button();
            this.btn_nv_add = new System.Windows.Forms.Button();
            this.grb_nv_data = new System.Windows.Forms.GroupBox();
            this.dgv_nv_load = new System.Windows.Forms.DataGridView();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_tk_nv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nv_id)).BeginInit();
            this.grb_nv_info.SuspendLayout();
            this.grb_nv_exec.SuspendLayout();
            this.grb_nv_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv_load)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_tk_nv
            // 
            this.grb_tk_nv.Controls.Add(this.btn_tk_nv);
            this.grb_tk_nv.Controls.Add(this.cbb_find_pb_nv);
            this.grb_tk_nv.Controls.Add(this.cb_phongban);
            this.grb_tk_nv.Controls.Add(this.cbb_find_cv_nv);
            this.grb_tk_nv.Controls.Add(this.cb_chucvu);
            this.grb_tk_nv.Controls.Add(this.txt_find_nv_address);
            this.grb_tk_nv.Controls.Add(this.cb_diachi);
            this.grb_tk_nv.Controls.Add(this.dtp_find_nv_birth);
            this.grb_tk_nv.Controls.Add(this.cb_ngaysinh);
            this.grb_tk_nv.Controls.Add(this.cbb_find_gt_nv);
            this.grb_tk_nv.Controls.Add(this.cb_gt);
            this.grb_tk_nv.Controls.Add(this.txt_find_nv_name);
            this.grb_tk_nv.Controls.Add(this.cb_hoten);
            this.grb_tk_nv.Controls.Add(this.cb_mnv);
            this.grb_tk_nv.Controls.Add(this.nud_nv_id);
            this.grb_tk_nv.Location = new System.Drawing.Point(4, 4);
            this.grb_tk_nv.Name = "grb_tk_nv";
            this.grb_tk_nv.Size = new System.Drawing.Size(302, 648);
            this.grb_tk_nv.TabIndex = 0;
            this.grb_tk_nv.TabStop = false;
            this.grb_tk_nv.Text = "Tìm Kiếm Nhân Viên";
            // 
            // btn_tk_nv
            // 
            this.btn_tk_nv.Location = new System.Drawing.Point(10, 577);
            this.btn_tk_nv.Name = "btn_tk_nv";
            this.btn_tk_nv.Size = new System.Drawing.Size(211, 42);
            this.btn_tk_nv.TabIndex = 3;
            this.btn_tk_nv.Text = "Tìm kiếm";
            this.btn_tk_nv.UseVisualStyleBackColor = true;
            this.btn_tk_nv.Click += new System.EventHandler(this.btn_tk_nv_Click);
            // 
            // cbb_find_pb_nv
            // 
            this.cbb_find_pb_nv.DisplayMember = "TenPhongBan";
            this.cbb_find_pb_nv.FormattingEnabled = true;
            this.cbb_find_pb_nv.Location = new System.Drawing.Point(8, 512);
            this.cbb_find_pb_nv.Name = "cbb_find_pb_nv";
            this.cbb_find_pb_nv.Size = new System.Drawing.Size(235, 24);
            this.cbb_find_pb_nv.TabIndex = 18;
            this.cbb_find_pb_nv.ValueMember = "MaPhongBan";
            // 
            // cb_phongban
            // 
            this.cb_phongban.AutoSize = true;
            this.cb_phongban.Location = new System.Drawing.Point(8, 482);
            this.cb_phongban.Name = "cb_phongban";
            this.cb_phongban.Size = new System.Drawing.Size(97, 20);
            this.cb_phongban.TabIndex = 17;
            this.cb_phongban.Text = "Phòng ban:";
            this.cb_phongban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_phongban.UseVisualStyleBackColor = true;
            // 
            // cbb_find_cv_nv
            // 
            this.cbb_find_cv_nv.DisplayMember = "TenChucVu";
            this.cbb_find_cv_nv.FormattingEnabled = true;
            this.cbb_find_cv_nv.Location = new System.Drawing.Point(8, 436);
            this.cbb_find_cv_nv.Name = "cbb_find_cv_nv";
            this.cbb_find_cv_nv.Size = new System.Drawing.Size(235, 24);
            this.cbb_find_cv_nv.TabIndex = 16;
            this.cbb_find_cv_nv.ValueMember = "MaChucVu";
            // 
            // cb_chucvu
            // 
            this.cb_chucvu.AutoSize = true;
            this.cb_chucvu.Location = new System.Drawing.Point(8, 406);
            this.cb_chucvu.Name = "cb_chucvu";
            this.cb_chucvu.Size = new System.Drawing.Size(79, 20);
            this.cb_chucvu.TabIndex = 15;
            this.cb_chucvu.Text = "Chức vụ:";
            this.cb_chucvu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_chucvu.UseVisualStyleBackColor = true;
            // 
            // txt_find_nv_address
            // 
            this.txt_find_nv_address.Location = new System.Drawing.Point(8, 362);
            this.txt_find_nv_address.Name = "txt_find_nv_address";
            this.txt_find_nv_address.Size = new System.Drawing.Size(255, 22);
            this.txt_find_nv_address.TabIndex = 14;
            // 
            // cb_diachi
            // 
            this.cb_diachi.AutoSize = true;
            this.cb_diachi.Location = new System.Drawing.Point(8, 336);
            this.cb_diachi.Name = "cb_diachi";
            this.cb_diachi.Size = new System.Drawing.Size(72, 20);
            this.cb_diachi.TabIndex = 13;
            this.cb_diachi.Text = "Địa chỉ:";
            this.cb_diachi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_diachi.UseVisualStyleBackColor = true;
            // 
            // dtp_find_nv_birth
            // 
            this.dtp_find_nv_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_find_nv_birth.Location = new System.Drawing.Point(8, 295);
            this.dtp_find_nv_birth.Name = "dtp_find_nv_birth";
            this.dtp_find_nv_birth.Size = new System.Drawing.Size(148, 22);
            this.dtp_find_nv_birth.TabIndex = 12;
            // 
            // cb_ngaysinh
            // 
            this.cb_ngaysinh.AutoSize = true;
            this.cb_ngaysinh.Location = new System.Drawing.Point(8, 260);
            this.cb_ngaysinh.Name = "cb_ngaysinh";
            this.cb_ngaysinh.Size = new System.Drawing.Size(92, 20);
            this.cb_ngaysinh.TabIndex = 7;
            this.cb_ngaysinh.Text = "Ngày sinh:";
            this.cb_ngaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_ngaysinh.UseVisualStyleBackColor = true;
            // 
            // cbb_find_gt_nv
            // 
            this.cbb_find_gt_nv.FormattingEnabled = true;
            this.cbb_find_gt_nv.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_find_gt_nv.Location = new System.Drawing.Point(8, 209);
            this.cbb_find_gt_nv.Name = "cbb_find_gt_nv";
            this.cbb_find_gt_nv.Size = new System.Drawing.Size(121, 24);
            this.cbb_find_gt_nv.TabIndex = 6;
            // 
            // cb_gt
            // 
            this.cb_gt.AutoSize = true;
            this.cb_gt.Location = new System.Drawing.Point(8, 179);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(79, 20);
            this.cb_gt.TabIndex = 4;
            this.cb_gt.Text = "Giới tính:";
            this.cb_gt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_gt.UseVisualStyleBackColor = true;
            // 
            // txt_find_nv_name
            // 
            this.txt_find_nv_name.Location = new System.Drawing.Point(8, 121);
            this.txt_find_nv_name.Name = "txt_find_nv_name";
            this.txt_find_nv_name.Size = new System.Drawing.Size(255, 22);
            this.txt_find_nv_name.TabIndex = 3;
            // 
            // cb_hoten
            // 
            this.cb_hoten.AutoSize = true;
            this.cb_hoten.Location = new System.Drawing.Point(8, 95);
            this.cb_hoten.Name = "cb_hoten";
            this.cb_hoten.Size = new System.Drawing.Size(71, 20);
            this.cb_hoten.TabIndex = 2;
            this.cb_hoten.Text = "Họ tên:";
            this.cb_hoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_hoten.UseVisualStyleBackColor = true;
            // 
            // cb_mnv
            // 
            this.cb_mnv.AutoSize = true;
            this.cb_mnv.Location = new System.Drawing.Point(8, 23);
            this.cb_mnv.Name = "cb_mnv";
            this.cb_mnv.Size = new System.Drawing.Size(111, 20);
            this.cb_mnv.TabIndex = 1;
            this.cb_mnv.Text = "Mã nhân viên:";
            this.cb_mnv.UseVisualStyleBackColor = true;
            // 
            // nud_nv_id
            // 
            this.nud_nv_id.Location = new System.Drawing.Point(8, 49);
            this.nud_nv_id.Name = "nud_nv_id";
            this.nud_nv_id.Size = new System.Drawing.Size(139, 22);
            this.nud_nv_id.TabIndex = 0;
            this.nud_nv_id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grb_nv_info
            // 
            this.grb_nv_info.Controls.Add(this.cbb_phongban_nv);
            this.grb_nv_info.Controls.Add(this.label6);
            this.grb_nv_info.Controls.Add(this.cbb_chucvu_nv);
            this.grb_nv_info.Controls.Add(this.txt_nv_address);
            this.grb_nv_info.Controls.Add(this.dtp_nv_birth);
            this.grb_nv_info.Controls.Add(this.label5);
            this.grb_nv_info.Controls.Add(this.cbb_gioitinh_nv);
            this.grb_nv_info.Controls.Add(this.txt_nv_name);
            this.grb_nv_info.Controls.Add(this.label4);
            this.grb_nv_info.Controls.Add(this.label3);
            this.grb_nv_info.Controls.Add(this.label2);
            this.grb_nv_info.Controls.Add(this.label1);
            this.grb_nv_info.Location = new System.Drawing.Point(341, 4);
            this.grb_nv_info.Name = "grb_nv_info";
            this.grb_nv_info.Size = new System.Drawing.Size(853, 172);
            this.grb_nv_info.TabIndex = 1;
            this.grb_nv_info.TabStop = false;
            this.grb_nv_info.Text = "Thông tin nhân viên";
            // 
            // cbb_phongban_nv
            // 
            this.cbb_phongban_nv.DisplayMember = "TenPhongBan";
            this.cbb_phongban_nv.FormattingEnabled = true;
            this.cbb_phongban_nv.Location = new System.Drawing.Point(399, 127);
            this.cbb_phongban_nv.Name = "cbb_phongban_nv";
            this.cbb_phongban_nv.Size = new System.Drawing.Size(254, 24);
            this.cbb_phongban_nv.TabIndex = 11;
            this.cbb_phongban_nv.ValueMember = "MaPhongBan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phòng ban:";
            // 
            // cbb_chucvu_nv
            // 
            this.cbb_chucvu_nv.DisplayMember = "TenChucVu";
            this.cbb_chucvu_nv.FormattingEnabled = true;
            this.cbb_chucvu_nv.Location = new System.Drawing.Point(62, 127);
            this.cbb_chucvu_nv.Name = "cbb_chucvu_nv";
            this.cbb_chucvu_nv.Size = new System.Drawing.Size(208, 24);
            this.cbb_chucvu_nv.TabIndex = 9;
            this.cbb_chucvu_nv.ValueMember = "MaChucVu";
            // 
            // txt_nv_address
            // 
            this.txt_nv_address.Location = new System.Drawing.Point(62, 93);
            this.txt_nv_address.Name = "txt_nv_address";
            this.txt_nv_address.Size = new System.Drawing.Size(401, 22);
            this.txt_nv_address.TabIndex = 8;
            // 
            // dtp_nv_birth
            // 
            this.dtp_nv_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nv_birth.Location = new System.Drawing.Point(276, 49);
            this.dtp_nv_birth.Name = "dtp_nv_birth";
            this.dtp_nv_birth.Size = new System.Drawing.Size(148, 22);
            this.dtp_nv_birth.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày sinh:";
            // 
            // cbb_gioitinh_nv
            // 
            this.cbb_gioitinh_nv.FormattingEnabled = true;
            this.cbb_gioitinh_nv.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gioitinh_nv.Location = new System.Drawing.Point(61, 46);
            this.cbb_gioitinh_nv.Name = "cbb_gioitinh_nv";
            this.cbb_gioitinh_nv.Size = new System.Drawing.Size(133, 24);
            this.cbb_gioitinh_nv.TabIndex = 5;
            // 
            // txt_nv_name
            // 
            this.txt_nv_name.Location = new System.Drawing.Point(61, 15);
            this.txt_nv_name.Name = "txt_nv_name";
            this.txt_nv_name.Size = new System.Drawing.Size(363, 22);
            this.txt_nv_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // grb_nv_exec
            // 
            this.grb_nv_exec.Controls.Add(this.btn_nv_xoa);
            this.grb_nv_exec.Controls.Add(this.btn_nv_sua);
            this.grb_nv_exec.Controls.Add(this.btn_nv_add);
            this.grb_nv_exec.Location = new System.Drawing.Point(344, 213);
            this.grb_nv_exec.Name = "grb_nv_exec";
            this.grb_nv_exec.Size = new System.Drawing.Size(849, 88);
            this.grb_nv_exec.TabIndex = 2;
            this.grb_nv_exec.TabStop = false;
            this.grb_nv_exec.Text = "Chức năng";
            // 
            // btn_nv_xoa
            // 
            this.btn_nv_xoa.Location = new System.Drawing.Point(326, 29);
            this.btn_nv_xoa.Name = "btn_nv_xoa";
            this.btn_nv_xoa.Size = new System.Drawing.Size(95, 42);
            this.btn_nv_xoa.TabIndex = 2;
            this.btn_nv_xoa.Text = "Xoá";
            this.btn_nv_xoa.UseVisualStyleBackColor = true;
            this.btn_nv_xoa.Click += new System.EventHandler(this.btn_nv_xoa_Click);
            // 
            // btn_nv_sua
            // 
            this.btn_nv_sua.Location = new System.Drawing.Point(172, 29);
            this.btn_nv_sua.Name = "btn_nv_sua";
            this.btn_nv_sua.Size = new System.Drawing.Size(95, 42);
            this.btn_nv_sua.TabIndex = 1;
            this.btn_nv_sua.Text = "Sửa";
            this.btn_nv_sua.UseVisualStyleBackColor = true;
            this.btn_nv_sua.Click += new System.EventHandler(this.btn_nv_sua_Click);
            // 
            // btn_nv_add
            // 
            this.btn_nv_add.Location = new System.Drawing.Point(26, 29);
            this.btn_nv_add.Name = "btn_nv_add";
            this.btn_nv_add.Size = new System.Drawing.Size(95, 42);
            this.btn_nv_add.TabIndex = 0;
            this.btn_nv_add.Text = "Thêm";
            this.btn_nv_add.UseVisualStyleBackColor = true;
            this.btn_nv_add.Click += new System.EventHandler(this.btn_nv_add_Click);
            // 
            // grb_nv_data
            // 
            this.grb_nv_data.Controls.Add(this.dgv_nv_load);
            this.grb_nv_data.Location = new System.Drawing.Point(344, 340);
            this.grb_nv_data.Name = "grb_nv_data";
            this.grb_nv_data.Size = new System.Drawing.Size(849, 374);
            this.grb_nv_data.TabIndex = 3;
            this.grb_nv_data.TabStop = false;
            this.grb_nv_data.Text = "Danh sách nhân viên";
            // 
            // dgv_nv_load
            // 
            this.dgv_nv_load.AllowUserToAddRows = false;
            this.dgv_nv_load.AllowUserToDeleteRows = false;
            this.dgv_nv_load.AllowUserToResizeColumns = false;
            this.dgv_nv_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhanVien,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colChucVu,
            this.colPhongBan});
            this.dgv_nv_load.Location = new System.Drawing.Point(6, 21);
            this.dgv_nv_load.Name = "dgv_nv_load";
            this.dgv_nv_load.RowHeadersWidth = 51;
            this.dgv_nv_load.RowTemplate.Height = 24;
            this.dgv_nv_load.Size = new System.Drawing.Size(837, 347);
            this.dgv_nv_load.TabIndex = 4;
            this.dgv_nv_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nv_load_RowEnter);
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Mã Nhân Viên";
            this.colMaNhanVien.MinimumWidth = 6;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            this.colMaNhanVien.Width = 120;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 81;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 98;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 125;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 78;
            // 
            // colChucVu
            // 
            this.colChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colChucVu.DataPropertyName = "TenChucVu";
            this.colChucVu.HeaderText = "Chức Vụ";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            this.colChucVu.Width = 85;
            // 
            // colPhongBan
            // 
            this.colPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhongBan.DataPropertyName = "TenPhongBan";
            this.colPhongBan.HeaderText = "Phòng Ban";
            this.colPhongBan.MinimumWidth = 6;
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.ReadOnly = true;
            this.colPhongBan.Width = 102;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 726);
            this.Controls.Add(this.grb_nv_data);
            this.Controls.Add(this.grb_nv_exec);
            this.Controls.Add(this.grb_nv_info);
            this.Controls.Add(this.grb_tk_nv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb_tk_nv.ResumeLayout(false);
            this.grb_tk_nv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nv_id)).EndInit();
            this.grb_nv_info.ResumeLayout(false);
            this.grb_nv_info.PerformLayout();
            this.grb_nv_exec.ResumeLayout(false);
            this.grb_nv_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv_load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_tk_nv;
        private System.Windows.Forms.GroupBox grb_nv_info;
        private System.Windows.Forms.GroupBox grb_nv_exec;
        private System.Windows.Forms.GroupBox grb_nv_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_chucvu_nv;
        private System.Windows.Forms.TextBox txt_nv_address;
        private System.Windows.Forms.DateTimePicker dtp_nv_birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_gioitinh_nv;
        private System.Windows.Forms.TextBox txt_nv_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_phongban_nv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_nv_xoa;
        private System.Windows.Forms.Button btn_nv_sua;
        private System.Windows.Forms.Button btn_nv_add;
        private System.Windows.Forms.DataGridView dgv_nv_load;
        private System.Windows.Forms.CheckBox cb_ngaysinh;
        private System.Windows.Forms.ComboBox cbb_find_gt_nv;
        private System.Windows.Forms.CheckBox cb_gt;
        private System.Windows.Forms.TextBox txt_find_nv_name;
        private System.Windows.Forms.CheckBox cb_hoten;
        private System.Windows.Forms.CheckBox cb_mnv;
        private System.Windows.Forms.NumericUpDown nud_nv_id;
        private System.Windows.Forms.CheckBox cb_diachi;
        private System.Windows.Forms.DateTimePicker dtp_find_nv_birth;
        private System.Windows.Forms.TextBox txt_find_nv_address;
        private System.Windows.Forms.ComboBox cbb_find_pb_nv;
        private System.Windows.Forms.CheckBox cb_phongban;
        private System.Windows.Forms.ComboBox cbb_find_cv_nv;
        private System.Windows.Forms.CheckBox cb_chucvu;
        private System.Windows.Forms.Button btn_tk_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
    }
}


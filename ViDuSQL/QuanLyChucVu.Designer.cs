namespace ViDuSQL
{
    partial class QuanLyChucVu
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
            this.dgv_cv_load = new System.Windows.Forms.DataGridView();
            this.grb_data_pb = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.grb_control_pb = new System.Windows.Forms.GroupBox();
            this.txt_cv_name = new System.Windows.Forms.TextBox();
            this.txt_cv_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_info_cv = new System.Windows.Forms.GroupBox();
            this.cb_find_cv_id = new System.Windows.Forms.CheckBox();
            this.btn_find_cv = new System.Windows.Forms.Button();
            this.txt_find_name_cv = new System.Windows.Forms.TextBox();
            this.cb_find_name_cv = new System.Windows.Forms.CheckBox();
            this.nud_ma_cv = new System.Windows.Forms.NumericUpDown();
            this.grp_find_cv = new System.Windows.Forms.GroupBox();
            this.colMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cv_load)).BeginInit();
            this.grb_data_pb.SuspendLayout();
            this.grb_control_pb.SuspendLayout();
            this.grp_info_cv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ma_cv)).BeginInit();
            this.grp_find_cv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cv_load
            // 
            this.dgv_cv_load.AllowUserToAddRows = false;
            this.dgv_cv_load.AllowUserToDeleteRows = false;
            this.dgv_cv_load.AllowUserToResizeColumns = false;
            this.dgv_cv_load.AllowUserToResizeRows = false;
            this.dgv_cv_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cv_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChucVu,
            this.colTenChucVu});
            this.dgv_cv_load.Location = new System.Drawing.Point(16, 28);
            this.dgv_cv_load.Name = "dgv_cv_load";
            this.dgv_cv_load.ReadOnly = true;
            this.dgv_cv_load.RowHeadersWidth = 51;
            this.dgv_cv_load.RowTemplate.Height = 24;
            this.dgv_cv_load.Size = new System.Drawing.Size(808, 294);
            this.dgv_cv_load.TabIndex = 0;
            this.dgv_cv_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cv_load_RowEnter);
            // 
            // grb_data_pb
            // 
            this.grb_data_pb.Controls.Add(this.dgv_cv_load);
            this.grb_data_pb.Location = new System.Drawing.Point(391, 401);
            this.grb_data_pb.Margin = new System.Windows.Forms.Padding(4);
            this.grb_data_pb.Name = "grb_data_pb";
            this.grb_data_pb.Padding = new System.Windows.Forms.Padding(4);
            this.grb_data_pb.Size = new System.Drawing.Size(878, 365);
            this.grb_data_pb.TabIndex = 8;
            this.grb_data_pb.TabStop = false;
            this.grb_data_pb.Text = "Danh sách phòng ban";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(294, 38);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 51);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(157, 38);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(113, 51);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(22, 38);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 51);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // grb_control_pb
            // 
            this.grb_control_pb.Controls.Add(this.btn_delete);
            this.grb_control_pb.Controls.Add(this.btn_update);
            this.grb_control_pb.Controls.Add(this.btn_add);
            this.grb_control_pb.Location = new System.Drawing.Point(391, 274);
            this.grb_control_pb.Margin = new System.Windows.Forms.Padding(4);
            this.grb_control_pb.Name = "grb_control_pb";
            this.grb_control_pb.Padding = new System.Windows.Forms.Padding(4);
            this.grb_control_pb.Size = new System.Drawing.Size(878, 106);
            this.grb_control_pb.TabIndex = 7;
            this.grb_control_pb.TabStop = false;
            this.grb_control_pb.Text = "Chức năng";
            // 
            // txt_cv_name
            // 
            this.txt_cv_name.Location = new System.Drawing.Point(132, 93);
            this.txt_cv_name.Name = "txt_cv_name";
            this.txt_cv_name.Size = new System.Drawing.Size(198, 27);
            this.txt_cv_name.TabIndex = 6;
            // 
            // txt_cv_id
            // 
            this.txt_cv_id.Location = new System.Drawing.Point(132, 32);
            this.txt_cv_id.Name = "txt_cv_id";
            this.txt_cv_id.ReadOnly = true;
            this.txt_cv_id.Size = new System.Drawing.Size(198, 27);
            this.txt_cv_id.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng ban:";
            // 
            // grp_info_cv
            // 
            this.grp_info_cv.Controls.Add(this.txt_cv_name);
            this.grp_info_cv.Controls.Add(this.txt_cv_id);
            this.grp_info_cv.Controls.Add(this.label2);
            this.grp_info_cv.Controls.Add(this.label1);
            this.grp_info_cv.Location = new System.Drawing.Point(391, 13);
            this.grp_info_cv.Margin = new System.Windows.Forms.Padding(4);
            this.grp_info_cv.Name = "grp_info_cv";
            this.grp_info_cv.Padding = new System.Windows.Forms.Padding(4);
            this.grp_info_cv.Size = new System.Drawing.Size(878, 222);
            this.grp_info_cv.TabIndex = 6;
            this.grp_info_cv.TabStop = false;
            this.grp_info_cv.Text = "Thông tin chức vụ:";
            // 
            // cb_find_cv_id
            // 
            this.cb_find_cv_id.AutoSize = true;
            this.cb_find_cv_id.Location = new System.Drawing.Point(22, 27);
            this.cb_find_cv_id.Name = "cb_find_cv_id";
            this.cb_find_cv_id.Size = new System.Drawing.Size(122, 24);
            this.cb_find_cv_id.TabIndex = 5;
            this.cb_find_cv_id.Text = "Mã chức vụ:";
            this.cb_find_cv_id.UseVisualStyleBackColor = true;
            // 
            // btn_find_cv
            // 
            this.btn_find_cv.Location = new System.Drawing.Point(22, 205);
            this.btn_find_cv.Name = "btn_find_cv";
            this.btn_find_cv.Size = new System.Drawing.Size(198, 37);
            this.btn_find_cv.TabIndex = 4;
            this.btn_find_cv.Text = "Tìm Kiếm";
            this.btn_find_cv.UseVisualStyleBackColor = true;
            this.btn_find_cv.Click += new System.EventHandler(this.btn_find_cv_Click);
            // 
            // txt_find_name_cv
            // 
            this.txt_find_name_cv.Location = new System.Drawing.Point(22, 146);
            this.txt_find_name_cv.Name = "txt_find_name_cv";
            this.txt_find_name_cv.Size = new System.Drawing.Size(198, 27);
            this.txt_find_name_cv.TabIndex = 3;
            // 
            // cb_find_name_cv
            // 
            this.cb_find_name_cv.AutoSize = true;
            this.cb_find_name_cv.Location = new System.Drawing.Point(22, 116);
            this.cb_find_name_cv.Name = "cb_find_name_cv";
            this.cb_find_name_cv.Size = new System.Drawing.Size(122, 24);
            this.cb_find_name_cv.TabIndex = 2;
            this.cb_find_name_cv.Text = "Tên chức vụ";
            this.cb_find_name_cv.UseVisualStyleBackColor = true;
            // 
            // nud_ma_cv
            // 
            this.nud_ma_cv.Location = new System.Drawing.Point(22, 65);
            this.nud_ma_cv.Name = "nud_ma_cv";
            this.nud_ma_cv.Size = new System.Drawing.Size(198, 27);
            this.nud_ma_cv.TabIndex = 1;
            this.nud_ma_cv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grp_find_cv
            // 
            this.grp_find_cv.Controls.Add(this.cb_find_cv_id);
            this.grp_find_cv.Controls.Add(this.btn_find_cv);
            this.grp_find_cv.Controls.Add(this.txt_find_name_cv);
            this.grp_find_cv.Controls.Add(this.cb_find_name_cv);
            this.grp_find_cv.Controls.Add(this.nud_ma_cv);
            this.grp_find_cv.Location = new System.Drawing.Point(13, 13);
            this.grp_find_cv.Margin = new System.Windows.Forms.Padding(4);
            this.grp_find_cv.Name = "grp_find_cv";
            this.grp_find_cv.Padding = new System.Windows.Forms.Padding(4);
            this.grp_find_cv.Size = new System.Drawing.Size(274, 641);
            this.grp_find_cv.TabIndex = 5;
            this.grp_find_cv.TabStop = false;
            this.grp_find_cv.Text = "Tìm kiếm chức vụ";
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaChucVu.DataPropertyName = "MaChucVu";
            this.colMaChucVu.HeaderText = "Mã Chức Vụ";
            this.colMaChucVu.MinimumWidth = 6;
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.ReadOnly = true;
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenChucVu.DataPropertyName = "TenChucVu";
            this.colTenChucVu.HeaderText = "Tên Chức Vụ";
            this.colTenChucVu.MinimumWidth = 6;
            this.colTenChucVu.Name = "colTenChucVu";
            this.colTenChucVu.ReadOnly = true;
            // 
            // QuanLyChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 760);
            this.Controls.Add(this.grb_data_pb);
            this.Controls.Add(this.grb_control_pb);
            this.Controls.Add(this.grp_info_cv);
            this.Controls.Add(this.grp_find_cv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyChucVu";
            this.Text = "QuanLyChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cv_load)).EndInit();
            this.grb_data_pb.ResumeLayout(false);
            this.grb_control_pb.ResumeLayout(false);
            this.grp_info_cv.ResumeLayout(false);
            this.grp_info_cv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ma_cv)).EndInit();
            this.grp_find_cv.ResumeLayout(false);
            this.grp_find_cv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_cv_load;
        private System.Windows.Forms.GroupBox grb_data_pb;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox grb_control_pb;
        private System.Windows.Forms.TextBox txt_cv_name;
        private System.Windows.Forms.TextBox txt_cv_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_info_cv;
        private System.Windows.Forms.CheckBox cb_find_cv_id;
        private System.Windows.Forms.Button btn_find_cv;
        private System.Windows.Forms.TextBox txt_find_name_cv;
        private System.Windows.Forms.CheckBox cb_find_name_cv;
        private System.Windows.Forms.NumericUpDown nud_ma_cv;
        private System.Windows.Forms.GroupBox grp_find_cv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChucVu;
    }
}
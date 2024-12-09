namespace ViDuSQL
{
    partial class QuanLyPhongBan
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
            this.grp_find_pb = new System.Windows.Forms.GroupBox();
            this.cb_find_pb_id = new System.Windows.Forms.CheckBox();
            this.btn_find_pb = new System.Windows.Forms.Button();
            this.txt_find_name_pb = new System.Windows.Forms.TextBox();
            this.cb_find_name_pb = new System.Windows.Forms.CheckBox();
            this.nud_ma_pb = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp_info_pb = new System.Windows.Forms.GroupBox();
            this.txt_pb_name = new System.Windows.Forms.TextBox();
            this.txt_pb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_control_pb = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.grb_data_pb = new System.Windows.Forms.GroupBox();
            this.dgv_pb_load = new System.Windows.Forms.DataGridView();
            this.colMaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_find_id_pb = new System.Windows.Forms.CheckBox();
            this.grp_find_pb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ma_pb)).BeginInit();
            this.grp_info_pb.SuspendLayout();
            this.grb_control_pb.SuspendLayout();
            this.grb_data_pb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb_load)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_find_pb
            // 
            this.grp_find_pb.Controls.Add(this.cb_find_pb_id);
            this.grp_find_pb.Controls.Add(this.btn_find_pb);
            this.grp_find_pb.Controls.Add(this.txt_find_name_pb);
            this.grp_find_pb.Controls.Add(this.cb_find_name_pb);
            this.grp_find_pb.Controls.Add(this.nud_ma_pb);
            this.grp_find_pb.Location = new System.Drawing.Point(13, 44);
            this.grp_find_pb.Margin = new System.Windows.Forms.Padding(4);
            this.grp_find_pb.Name = "grp_find_pb";
            this.grp_find_pb.Padding = new System.Windows.Forms.Padding(4);
            this.grp_find_pb.Size = new System.Drawing.Size(274, 641);
            this.grp_find_pb.TabIndex = 0;
            this.grp_find_pb.TabStop = false;
            this.grp_find_pb.Text = "Tìm kiếm phòng ban";
            // 
            // cb_find_pb_id
            // 
            this.cb_find_pb_id.AutoSize = true;
            this.cb_find_pb_id.Location = new System.Drawing.Point(22, 27);
            this.cb_find_pb_id.Name = "cb_find_pb_id";
            this.cb_find_pb_id.Size = new System.Drawing.Size(141, 24);
            this.cb_find_pb_id.TabIndex = 5;
            this.cb_find_pb_id.Text = "Mã phòng ban:";
            this.cb_find_pb_id.UseVisualStyleBackColor = true;
            // 
            // btn_find_pb
            // 
            this.btn_find_pb.Location = new System.Drawing.Point(22, 205);
            this.btn_find_pb.Name = "btn_find_pb";
            this.btn_find_pb.Size = new System.Drawing.Size(198, 37);
            this.btn_find_pb.TabIndex = 4;
            this.btn_find_pb.Text = "Tìm Kiếm";
            this.btn_find_pb.UseVisualStyleBackColor = true;
            this.btn_find_pb.Click += new System.EventHandler(this.btn_find_pb_Click);
            // 
            // txt_find_name_pb
            // 
            this.txt_find_name_pb.Location = new System.Drawing.Point(22, 146);
            this.txt_find_name_pb.Name = "txt_find_name_pb";
            this.txt_find_name_pb.Size = new System.Drawing.Size(198, 27);
            this.txt_find_name_pb.TabIndex = 3;
            // 
            // cb_find_name_pb
            // 
            this.cb_find_name_pb.AutoSize = true;
            this.cb_find_name_pb.Location = new System.Drawing.Point(22, 116);
            this.cb_find_name_pb.Name = "cb_find_name_pb";
            this.cb_find_name_pb.Size = new System.Drawing.Size(141, 24);
            this.cb_find_name_pb.TabIndex = 2;
            this.cb_find_name_pb.Text = "Tên phòng ban";
            this.cb_find_name_pb.UseVisualStyleBackColor = true;
            // 
            // nud_ma_pb
            // 
            this.nud_ma_pb.Location = new System.Drawing.Point(22, 65);
            this.nud_ma_pb.Name = "nud_ma_pb";
            this.nud_ma_pb.Size = new System.Drawing.Size(198, 27);
            this.nud_ma_pb.TabIndex = 1;
            this.nud_ma_pb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grp_info_pb
            // 
            this.grp_info_pb.Controls.Add(this.txt_pb_name);
            this.grp_info_pb.Controls.Add(this.txt_pb_id);
            this.grp_info_pb.Controls.Add(this.label2);
            this.grp_info_pb.Controls.Add(this.label1);
            this.grp_info_pb.Location = new System.Drawing.Point(391, 44);
            this.grp_info_pb.Margin = new System.Windows.Forms.Padding(4);
            this.grp_info_pb.Name = "grp_info_pb";
            this.grp_info_pb.Padding = new System.Windows.Forms.Padding(4);
            this.grp_info_pb.Size = new System.Drawing.Size(878, 222);
            this.grp_info_pb.TabIndex = 1;
            this.grp_info_pb.TabStop = false;
            this.grp_info_pb.Text = "Thông tin phòng ban";
            // 
            // txt_pb_name
            // 
            this.txt_pb_name.Location = new System.Drawing.Point(132, 93);
            this.txt_pb_name.Name = "txt_pb_name";
            this.txt_pb_name.Size = new System.Drawing.Size(198, 27);
            this.txt_pb_name.TabIndex = 6;
            // 
            // txt_pb_id
            // 
            this.txt_pb_id.Location = new System.Drawing.Point(132, 32);
            this.txt_pb_id.Name = "txt_pb_id";
            this.txt_pb_id.ReadOnly = true;
            this.txt_pb_id.Size = new System.Drawing.Size(198, 27);
            this.txt_pb_id.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng ban:";
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
            // grb_control_pb
            // 
            this.grb_control_pb.Controls.Add(this.btn_delete);
            this.grb_control_pb.Controls.Add(this.btn_update);
            this.grb_control_pb.Controls.Add(this.btn_add);
            this.grb_control_pb.Location = new System.Drawing.Point(391, 305);
            this.grb_control_pb.Margin = new System.Windows.Forms.Padding(4);
            this.grb_control_pb.Name = "grb_control_pb";
            this.grb_control_pb.Padding = new System.Windows.Forms.Padding(4);
            this.grb_control_pb.Size = new System.Drawing.Size(878, 106);
            this.grb_control_pb.TabIndex = 2;
            this.grb_control_pb.TabStop = false;
            this.grb_control_pb.Text = "Chức năng";
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
            // grb_data_pb
            // 
            this.grb_data_pb.Controls.Add(this.dgv_pb_load);
            this.grb_data_pb.Location = new System.Drawing.Point(391, 432);
            this.grb_data_pb.Margin = new System.Windows.Forms.Padding(4);
            this.grb_data_pb.Name = "grb_data_pb";
            this.grb_data_pb.Padding = new System.Windows.Forms.Padding(4);
            this.grb_data_pb.Size = new System.Drawing.Size(878, 365);
            this.grb_data_pb.TabIndex = 3;
            this.grb_data_pb.TabStop = false;
            this.grb_data_pb.Text = "Danh sách phòng ban";
            // 
            // dgv_pb_load
            // 
            this.dgv_pb_load.AllowUserToAddRows = false;
            this.dgv_pb_load.AllowUserToDeleteRows = false;
            this.dgv_pb_load.AllowUserToResizeColumns = false;
            this.dgv_pb_load.AllowUserToResizeRows = false;
            this.dgv_pb_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pb_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhongBan,
            this.colTenPhongBan});
            this.dgv_pb_load.Location = new System.Drawing.Point(16, 28);
            this.dgv_pb_load.Name = "dgv_pb_load";
            this.dgv_pb_load.ReadOnly = true;
            this.dgv_pb_load.RowHeadersWidth = 51;
            this.dgv_pb_load.RowTemplate.Height = 24;
            this.dgv_pb_load.Size = new System.Drawing.Size(808, 294);
            this.dgv_pb_load.TabIndex = 0;
            this.dgv_pb_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pb_load_RowEnter);
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaPhongBan.DataPropertyName = "MaPhongBan";
            this.colMaPhongBan.HeaderText = "Mã Phòng Ban";
            this.colMaPhongBan.MinimumWidth = 6;
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.ReadOnly = true;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenPhongBan.DataPropertyName = "TenPhongBan";
            this.colTenPhongBan.HeaderText = "Tên Phòng Ban";
            this.colTenPhongBan.MinimumWidth = 6;
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.ReadOnly = true;
            // 
            // cb_find_id_pb
            // 
            this.cb_find_id_pb.AutoSize = true;
            this.cb_find_id_pb.Location = new System.Drawing.Point(22, 35);
            this.cb_find_id_pb.Name = "cb_find_id_pb";
            this.cb_find_id_pb.Size = new System.Drawing.Size(136, 24);
            this.cb_find_id_pb.TabIndex = 0;
            this.cb_find_id_pb.Text = "Mã phòng ban";
            this.cb_find_id_pb.UseVisualStyleBackColor = true;
            // 
            // QuanLyPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 813);
            this.Controls.Add(this.grb_data_pb);
            this.Controls.Add(this.grb_control_pb);
            this.Controls.Add(this.grp_info_pb);
            this.Controls.Add(this.grp_find_pb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyPhongBan";
            this.Text = "QuanLyPhongBan";
            this.grp_find_pb.ResumeLayout(false);
            this.grp_find_pb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ma_pb)).EndInit();
            this.grp_info_pb.ResumeLayout(false);
            this.grp_info_pb.PerformLayout();
            this.grb_control_pb.ResumeLayout(false);
            this.grb_data_pb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb_load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_find_pb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grp_info_pb;
        private System.Windows.Forms.GroupBox grb_control_pb;
        private System.Windows.Forms.GroupBox grb_data_pb;
        private System.Windows.Forms.Button btn_find_pb;
        private System.Windows.Forms.TextBox txt_find_name_pb;
        private System.Windows.Forms.CheckBox cb_find_name_pb;
        private System.Windows.Forms.NumericUpDown nud_ma_pb;
        private System.Windows.Forms.CheckBox cb_find_id_pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pb_name;
        private System.Windows.Forms.TextBox txt_pb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_pb_load;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhongBan;
        private System.Windows.Forms.CheckBox cb_find_pb_id;
    }
}
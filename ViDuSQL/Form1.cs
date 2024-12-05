using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ViDuSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadCbbs();
            loadDgv();
        }

        private void loadCbbs()
        {
            cbb_gioitinh_nv.Text = "Nam";
            cbb_find_gt_nv.Text = "Nam";
            cbb_chucvu_nv.DataSource = Database.Query("SELECT * FROM ChucVu");
            cbb_chucvu_nv.DisplayMember = "TenChucVu";
            cbb_chucvu_nv.ValueMember = "MaChucVu";
            cbb_phongban_nv.DataSource = Database.Query("SELECT * FROM PhongBan");
            cbb_phongban_nv.DisplayMember = "TenPhongBan";
            cbb_phongban_nv.ValueMember = "MaPhongBan";
            cbb_find_cv_nv.DataSource = Database.Query("SELECT * FROM ChucVu");
            cbb_find_cv_nv.DisplayMember = "TenChucVu";
            cbb_find_cv_nv.ValueMember = "MaChucVu";
            cbb_find_pb_nv.DataSource = Database.Query("SELECT * FROM PhongBan");
            cbb_find_pb_nv.DisplayMember = "TenPhongBan";
            cbb_find_pb_nv.ValueMember = "MaPhongBan";
        }

        private void loadDgv()
        {
            string sql =
                "SELECT * FROM TimKiemNhanVien(@MaNhanVien,@HoTen,"
                + "@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (cb_mnv.Checked)
            {
                dictionary.Add("@MaNhanVien", nud_nv_id.Value);
            }
            else
            {
                dictionary.Add("@MaNhanVien", DBNull.Value);
            }
            if (cb_hoten.Checked)
            {
                dictionary.Add("@HoTen", txt_find_nv_name.Text);
            }
            else
            {
                dictionary.Add("@HoTen", "");
            }

            if (cb_ngaysinh.Checked)
            {
                dictionary.Add("@NgaySinh", dtp_find_nv_birth.Value);
            }
            else
            {
                dictionary.Add("@NgaySinh", DBNull.Value);
            }
            if (cb_gt.Checked)
            {
                dictionary.Add("@GioiTinh", cbb_find_gt_nv.Text);
            }
            else
            {
                dictionary.Add("@GioiTinh", DBNull.Value);
            }
            if (cb_diachi.Checked)
            {
                dictionary.Add("@DiaChi", txt_find_nv_address.Text);
            }
            else
            {
                dictionary.Add("@DiaChi", "");
            }
            if (cb_chucvu.Checked)
            {
                dictionary.Add("@MaChucVu", cbb_find_cv_nv.SelectedValue);
            }
            else
            {
                dictionary.Add("@MaChucVu", DBNull.Value);
            }
            if (cb_phongban.Checked)
            {
                dictionary.Add("@MaPhongBan", cbb_find_pb_nv.SelectedValue);
            }
            else
            {
                dictionary.Add("@MaPhongBan", DBNull.Value);
            }
            dgv_nv_load.DataSource = Database.Query(sql, dictionary);
            btn_nv_sua.Enabled = btn_nv_xoa.Enabled = dgv_nv_load.Rows.Count > 0;
        }

        private void btn_tk_nv_Click(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void btn_nv_add_Click(object sender, EventArgs e)
        {
            string sql =
                "EXEC ThemNhanVien @HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@HoTen", txt_nv_name.Text);
            dictionary.Add("@NgaySinh", dtp_nv_birth.Value);
            dictionary.Add("@GioiTinh", cbb_gioitinh_nv.Text == "Nam" ? "1" : "0");
            dictionary.Add("@DiaChi", txt_nv_address.Text);
            dictionary.Add("@MaChucVu", cbb_chucvu_nv.SelectedValue);
            dictionary.Add("@MaPhongBan", cbb_phongban_nv.SelectedValue);
            try
            {
                Database.Execute(sql, dictionary);
                loadDgv();
                txt_nv_name.Text = "";
                txt_nv_address.Text = "";
                cbb_gioitinh_nv.Text = "Nam";
                cbb_chucvu_nv.SelectedIndex = 0;
                cbb_phongban_nv.SelectedIndex = 0;
                dtp_find_nv_birth.Value = DateTime.Now;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_nv_sua_Click(object sender, EventArgs e)
        {
            string sql =
                "EXEC SuaNhanVien @MaNhanVien,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add(
                "@MaNhanVien",
                dgv_nv_load.Rows[dgv_nv_load.CurrentRow.Index].Cells["colMaNhanVien"].Value
            );
            dictionary.Add("@HoTen", txt_nv_name.Text);
            dictionary.Add("@NgaySinh", dtp_nv_birth.Value);
            dictionary.Add("@GioiTinh", cbb_gioitinh_nv.Text == "Nam" ? "1" : "0");
            dictionary.Add("@DiaChi", txt_nv_address.Text);
            dictionary.Add("@MaChucVu", cbb_chucvu_nv.SelectedValue);
            dictionary.Add("@MaPhongBan", cbb_phongban_nv.SelectedValue);
            try
            {
                Database.Execute(sql, dictionary);
                loadDgv();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_nv_xoa_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaNhanVien @MaNhanVien";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add(
                "@MaNhanVien",
                dgv_nv_load.Rows[dgv_nv_load.CurrentRow.Index].Cells["colMaNhanVien"].Value
            );
            try
            {
                Database.Execute(sql, dictionary);
                loadDgv();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgv_nv_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_nv_name.Text = dgv_nv_load.Rows[e.RowIndex].Cells["colHoTen"].Value.ToString();
            dtp_find_nv_birth.Value = DateTime.Parse(
                dgv_nv_load.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString()
            );
            cbb_gioitinh_nv.Text = dgv_nv_load
                .Rows[e.RowIndex]
                .Cells["colGioiTinh"]
                .Value.ToString();
            txt_nv_address.Text = dgv_nv_load.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            cbb_chucvu_nv.Text = dgv_nv_load.Rows[e.RowIndex].Cells["colChucVu"].Value.ToString();
            cbb_phongban_nv.Text = dgv_nv_load
                .Rows[e.RowIndex]
                .Cells["colPhongBan"]
                .Value.ToString();
        }
    }
}

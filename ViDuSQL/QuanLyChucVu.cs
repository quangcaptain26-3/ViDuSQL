using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDuSQL
{
    public partial class QuanLyChucVu : Form
    {
        public QuanLyChucVu()
        {
            InitializeComponent();
            loadDgv();
        }

        private void loadDgv()
        {
            string sql = "SELECT * FROM TimKiemChucVuCheck(@MaChucVu, @TenChucVu)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (cb_find_cv_id.Checked)
            {
                dictionary.Add("MaChucVu", nud_ma_cv.Value);
            }
            else
            {
                dictionary.Add("MaChucVu", DBNull.Value);
            }
            if (cb_find_name_cv.Checked)
            {
                dictionary.Add("TenChucVu", txt_find_name_cv.Text);
            }
            else
            {
                dictionary.Add("TenChucVu", "");
            }
            dgv_cv_load.DataSource = Database.Query(sql, dictionary);
            btn_delete.Enabled = btn_add.Enabled = dgv_cv_load.Rows.Count > 0;
        }

        private void btn_find_cv_Click(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string sql = "EXEC ThemChucVu @TenChucVu";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@TenChucVu", txt_cv_name.Text);
            try
            {
                Database.Execute(sql, dictionary);
                MessageBox.Show("Thêm thành công");
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "EXEC SuaChucVu @MaChucVu, @TenChucVu";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add(
                "@MaChucVu",
                dgv_cv_load.Rows[dgv_cv_load.CurrentRow.Index].Cells["colMaChucVu"].Value
            );
            dictionary.Add("@TenChucVu", txt_cv_name.Text);
            try
            {
                Database.Execute(sql, dictionary);
                MessageBox.Show("Sua thành công");
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaChucVu @MaChucVu";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add(
                "@MaChucVu",
                dgv_cv_load.Rows[dgv_cv_load.CurrentRow.Index].Cells["colMaChucVu"].Value
            );
            try
            {
                Database.Execute(sql, dictionary);
                MessageBox.Show("Xóa thành công");
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_cv_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_cv_id.Text = dgv_cv_load.Rows[e.RowIndex].Cells["colMaChucVu"].Value.ToString();
            txt_cv_name.Text = dgv_cv_load.Rows[e.RowIndex].Cells["colTenChucVu"].Value.ToString();
        }
    }
}

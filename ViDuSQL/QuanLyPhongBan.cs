using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDuSQL
{
    public partial class QuanLyPhongBan : Form
    {
        public QuanLyPhongBan()
        {
            InitializeComponent();
            loadDgv();
        }

        private void loadDgv()
        {
            string sql = "SELECT * FROM TimKiemPhongBanCheck(@MaPhongBan,@TenPhongBan)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (cb_find_pb_id.Checked)
            {
                dictionary.Add("@MaPhongBan", nud_ma_pb.Value);
            }
            else
            {
                dictionary.Add("@MaPhongBan", DBNull.Value);
            }
            if (cb_find_name_pb.Checked)
            {
                dictionary.Add("@TenPhongBan", txt_find_name_pb.Text);
            }
            else
            {
                dictionary.Add("@TenPhongBan", "");
            }
            dgv_pb_load.DataSource = Database.Query(sql, dictionary);
            btn_delete.Enabled = btn_update.Enabled = dgv_pb_load.Rows.Count > 0;
        }

        private void btn_find_pb_Click(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string sql = "EXEC ThemPhongBan @TenPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@TenPhongBan", txt_pb_name.Text);
            try
            {
                Database.Execute(sql, dictionary);
                MessageBox.Show("Thêm phòng ban thành công");
                loadDgv();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "EXEC SuaPhongBan @MaPhongBan,@TenPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add(
                "@MaPhongBan",
                dgv_pb_load.Rows[dgv_pb_load.CurrentRow.Index].Cells["colMaPhongBan"].Value
            );
            dictionary.Add("@TenPhongBan", txt_pb_name.Text);
            try
            {
                Database.Execute(sql, dictionary);
                MessageBox.Show("Sửa phòng ban thành công");
                loadDgv();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaPhongBan @MaPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add(
                "@MaPhongBan",
                dgv_pb_load.Rows[dgv_pb_load.CurrentRow.Index].Cells["colMaPhongBan"].Value
            );
            try
            {
                Database.Execute(sql, dictionary);
                MessageBox.Show("Xóa phòng ban thành công");
                loadDgv();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgv_pb_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_pb_id.Text = dgv_pb_load.Rows[e.RowIndex].Cells["colMaPhongBan"].Value.ToString();
            txt_pb_name.Text = dgv_pb_load
                .Rows[e.RowIndex]
                .Cells["colTenPhongBan"]
                .Value.ToString();
        }
    }
}

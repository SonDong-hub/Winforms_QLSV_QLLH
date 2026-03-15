using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_QLSV_QLLH
{
    public partial class QLLH : Form
    {
        public QLLH()
        {
            InitializeComponent();
        }

        private void QLLH_Load(object sender, EventArgs e)
        {
            txb_malop.Focus();
            LoadData();
            LoadAutoComplete();
        }

        // Hiển thị dữ liệu
        private void LoadData()
        {
            QLLHDataContext db = new QLLHDataContext();

            dgv_lop.DataSource = db.LopHoc.ToList();

            dgv_lop.Columns["MaLop"].HeaderText = "Mã lớp";
            dgv_lop.Columns["TenLop"].HeaderText = "Tên lớp";
            dgv_lop.Columns["Khoa"].HeaderText = "Khoa";
            dgv_lop.Columns["Khoa"].HeaderText = "Khóa";
        }

        // Thêm lớp
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txb_malop.Text == "" || txb_tenlop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            QLLHDataContext db = new QLLHDataContext();

            LopHoc lh = new LopHoc();

            lh.MaLop = txb_malop.Text;
            lh.TenLop = txb_tenlop.Text;
            lh.Khoa = txb_khoa.Text;
            lh.KhoaHoc = txb_khoá.Text;

            db.LopHoc.InsertOnSubmit(lh);
            db.SubmitChanges();

            MessageBox.Show("Thêm lớp thành công");

            LoadData();
        }

        // Đổ dữ liệu lên ô
        private void dgv_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_lop.Rows[e.RowIndex];

                txb_malop.Text = row.Cells["MaLop"].Value.ToString();
                txb_tenlop.Text = row.Cells["TenLop"].Value.ToString();
                txb_khoa.Text = row.Cells["Khoa"].Value.ToString();
                txb_khoá.Text = row.Cells["KhoaHoc"].Value.ToString();
            }
        }

        // Sửa lớp
        private void btn_sua_Click(object sender, EventArgs e)
        {
            QLLHDataContext db = new QLLHDataContext();

            var lh = db.LopHoc.FirstOrDefault(l => l.MaLop == txb_malop.Text);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy lớp");
                return;
            }

            lh.TenLop = txb_tenlop.Text;
            lh.Khoa = txb_khoa.Text;
            lh.KhoaHoc = txb_khoá.Text;

            db.SubmitChanges();

            MessageBox.Show("Cập nhật lớp thành công");

            LoadData();
        }

        // Xóa lớp
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QLLHDataContext db = new QLLHDataContext();

            var lh = db.LopHoc.FirstOrDefault(l => l.MaLop == txb_malop.Text);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy lớp");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                db.LopHoc.DeleteOnSubmit(lh);
                db.SubmitChanges();

                MessageBox.Show("Xóa lớp thành công");

                LoadData();
            }
        }

        // Tìm kiếm lớp
        private void btn_tim_Click(object sender, EventArgs e)
        {
            QLLHDataContext db = new QLLHDataContext();

            string keyword = txb_timkiem.Text.Trim();

            var ketqua = db.LopHoc
                .Where(l => l.MaLop.Contains(keyword) || l.TenLop.Contains(keyword))
                .ToList();

            dgv_lop.DataSource = ketqua;
        }

        // Gợi ý tìm kiếm
        private void LoadAutoComplete()
        {
            QLLHDataContext db = new QLLHDataContext();

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            var ds = db.LopHoc.Select(l => l.TenLop).ToList();

            foreach (var item in ds)
            {
                data.Add(item);
            }

            txb_timkiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txb_timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txb_timkiem.AutoCompleteCustomSource = data;
        }

        // Làm mới
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txb_malop.Clear();
            txb_tenlop.Clear();
            txb_khoa.Clear();
            txb_khoá.Clear();
            txb_timkiem.Clear();

            txb_malop.Focus();

            LoadData();
        }
    }
}

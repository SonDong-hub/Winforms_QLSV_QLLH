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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        // Ô đầu tiên là MaSV
        private void QLSV_Load(object sender, EventArgs e)
        {
            txb_masv.Focus();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");
            LoadData();
            LoadAutoComplete();
        }

        // Hiện thị dữ liệu
        private void LoadData()
        {
            QLSVDataContext db = new QLSVDataContext();

            dgv_sinhvien.DataSource = db.SinhVien.ToList();
            dgv_sinhvien.Columns["MaSV"].HeaderText = "Mã sinh viên";
            dgv_sinhvien.Columns["HoTen"].HeaderText = "Họ và tên";
            dgv_sinhvien.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dgv_sinhvien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgv_sinhvien.Columns["Lop"].HeaderText = "Lớp";
        }

        //Thêm 
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txb_masv.Text == "" || txb_hoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            QLSVDataContext db = new QLSVDataContext();
            SinhVien sv = new SinhVien();
            sv.MaSV = txb_masv.Text;
            sv.HoTen = txb_hoten.Text;
            sv.NgaySinh = dt_ngaysinh.Value;
            sv.GioiTinh = cmb_gioitinh.Text;
            sv.Lop = txb_lop.Text;

            db.SinhVien.InsertOnSubmit(sv);
            db.SubmitChanges();

            // Thông báo
            MessageBox.Show("Thêm thành công");

            //Load lại dgv
            LoadData();
        }

        //Đổ dữ liệu vào ô
        private void dgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_sinhvien.Rows[e.RowIndex];

                txb_masv.Text = row.Cells["MaSV"].Value.ToString();
                txb_hoten.Text = row.Cells["HoTen"].Value.ToString();
                dt_ngaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cmb_gioitinh.SelectedItem = row.Cells["GioiTinh"].Value.ToString();
                txb_lop.Text = row.Cells["Lop"].Value.ToString();
            }
        }

        //Sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();

            var sv = db.SinhVien.FirstOrDefault(s => s.MaSV == txb_masv.Text);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên");
                return;
            }

            sv.HoTen = txb_hoten.Text;
            sv.NgaySinh = dt_ngaysinh.Value;
            sv.GioiTinh = cmb_gioitinh.Text;
            sv.Lop = txb_lop.Text;

            db.SubmitChanges();

            //Thông báo
            MessageBox.Show("Cập nhật thành công");

            LoadData();
        }

        //Xoá
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();

            var sv = db.SinhVien.FirstOrDefault(s => s.MaSV == txb_masv.Text);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                db.SinhVien.DeleteOnSubmit(sv);
                db.SubmitChanges();

                MessageBox.Show("Xóa sinh viên thành công");

                LoadData();
            }
        }

        //Tìm kiếm
        private void btn_tim_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();

            string keyword = txb_timkiem.Text.Trim();

            var ketqua = db.SinhVien
                .Where(s => s.MaSV.Contains(keyword) || s.HoTen.Contains(keyword))
                .ToList();

            dgv_sinhvien.DataSource = ketqua;
        }

        //Gợi ý tìm
        private void LoadAutoComplete()
        {
            QLSVDataContext db = new QLSVDataContext();

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            var ds = db.SinhVien.Select(s => s.HoTen).ToList();

            foreach (var item in ds)
            {
                data.Add(item);
            }

            txb_timkiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txb_timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txb_timkiem.AutoCompleteCustomSource = data;
        }

        //Làm mới
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các ô
            txb_masv.Clear();
            txb_hoten.Clear();
            txb_lop.Clear();
            txb_timkiem.Clear();

            // Reset combobox
            cmb_gioitinh.SelectedIndex = -1;

            // Reset ngày sinh về hôm nay
            dt_ngaysinh.Value = DateTime.Now;

            // Focus lại ô mã sinh viên
            txb_masv.Focus();

            // Load lại toàn bộ dữ liệu
            LoadData();
        }
    }
}

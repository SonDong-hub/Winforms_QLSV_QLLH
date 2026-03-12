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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Xử lý đăng nhập
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            string password = txb_password.Text;

            if (username == "ĐôngĐS" && password == "0008368")
            {
                QLSV qlsv = new QLSV();
                qlsv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nhập sai username hoặc password",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //Hiệu ứng nút đăng nhập
        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            btn_dangnhap.BackColor = Color.RoyalBlue;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btn_dangnhap.BackColor = Color.DodgerBlue;
        }
    }
}

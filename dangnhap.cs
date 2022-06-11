using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        //Conn cn = new Conn();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo");
                return;
            }

            DataTable dt = Conn.getDataTable("Select * from nguoidung where taikhoan = '" + textBox1.Text + "' and matkhau = '" + textBox2.Text + "'");
            
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào " + textBox1.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                Form hethong  = new hethong();
                hethong.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }
    }
}

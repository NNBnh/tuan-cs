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
    public partial class mathang : Form
    {
        public mathang()
        {
            InitializeComponent();
        }

        private void mathang_Load(object sender, EventArgs e)
        {
            DataTable dt = Conn.getDataTable("select * from mathang");
            dgv.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conn.executeQuery("insert into mathang (mamathang,tenmathang,maloai,mota, dongia) values ('" + txtma.Text + "','" + txtten.Text + "','" + txtlaoi.Text + "','" + txtmota.Text + "','" + txtdongia.Text + "')");
            mathang_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conn.executeQuery("UPDATE mathang SET mamathang='" + txtma.Text + "',  tenmathang='" + txtten.Text + "', maloai='" + txtlaoi.Text + "',  mota='" + txtmota.Text + "', dongia='" + txtdongia.Text + "' Where mamathang='"+txtma.Text+"' ");
            mathang_Load(sender, e);
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv.Rows[e.RowIndex];
            txtma.Text = row.Cells[0].Value.ToString();
            txtma.Enabled = false;
            txtten.Text = row.Cells[1].Value.ToString();
            txtlaoi.Text = row.Cells[2].Value.ToString();
            txtmota.Text = row.Cells[3].Value.ToString();
            txtdongia.Text = row.Cells[4].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
               Conn.executeQuery("delete from mathang where mamathang='" + txtma.Text + "' ");
            mathang_Load(sender, e);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string Search = "SELECT * FROM mathang WHERE mamathang LIKE '%" + txttimkiem.Text + "%' or tenmathang LIKE N'%" + txttimkiem.Text + "%' or mota LIKE N'%" + txttimkiem.Text + "%'";
            DataTable dt = Conn.getDataTable(Search);
            dgv.DataSource = dt;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mathang mh = new mathang();
            mh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thongke mh = new thongke();
                mh.Hide();
                mh.Show();

        }
    }
}

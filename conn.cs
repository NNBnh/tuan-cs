using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApp3
{

    class Conn
    {
        static SqlConnection cnn;
        static SqlDataAdapter da;
        static DataSet ds;
        static SqlCommand cmd;
        static string source;

        public static void openConnection()
        {
            source = @"Data Source=DESKTOP-7TECEO3;Initial Catalog=Order;Integrated Security=True";
            cnn = new SqlConnection(source);
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể kết nối đến CSDL.");
            }
        }


        public static void executeQuery(String sql)
        {
            try
            {
                cmd = new SqlCommand();
                openConnection();

                cmd.Connection = cnn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể thực hiện.");
            }

        }



        public static DataSet getDataSet(String sql)
        {

            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds;
        }


        public static DataTable getDataTable(String sql)
        {
            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds.Tables[0];
        }
    }

}

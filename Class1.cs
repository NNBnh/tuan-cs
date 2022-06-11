using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public class Class1
    {
        string str_con = @"Data Source=DESKTOP-7TECEO3;Initial Catalog=Order;Integrated Security=True";
        public DataSet getdata(string querry, string table_name)
        {
            SqlConnection conn = new SqlConnection(str_con);
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            da.Fill(ds,table_name);
            return ds;
        }
        public bool thucthi(string querry)
        {
            SqlConnection conn = new SqlConnection(str_con);
            conn.Open();
            SqlCommand cmd = new SqlCommand(querry, conn);
            int sl = cmd.ExecuteNonQuery();
            conn.Close();
            return sl > 0;
        }
    }
}

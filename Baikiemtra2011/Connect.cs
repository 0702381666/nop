using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikiemtra2011
{
    internal class Connect
    {
        string conStr = "Data Source=LOVANANH-2812;Initial Catalog=MobileShop;Integrated Security=True";
        SqlConnection conn;

       
        public Connect()
        {
            conn = new SqlConnection(conStr);
        }

        // Phương thức trả về đối tượng SqlConnection
        public SqlConnection GetConnection()
        {
            return conn;
        }

        // Phương thức lấy dữ liệu từ cơ sở dữ liệu
        public DataSet Laydulieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public bool ThucThi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}

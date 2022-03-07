using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LKS_Hotel_API_4.Models
{
    public class Utils
    {
        public static string conn = @"Data Source=desktop-00eposj;Initial Catalog=LKS_Hotel_4;Integrated Security=True";
    }

    public class Command
    {
        public static DataTable data(string com)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(Utils.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com, connection);
            adapter.Fill(table);
            return table;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToshoLibrary
{
    public class YoyakuTable
    {
        public Yoyaku GetYoyakuByIsbn(string isbn)
        {
            Yoyaku yoyaku = null;
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT y.yoyakuno, b.Title, g.GakuName, g.MailAddress 
                           FROM yoyaku as y
                           INNER JOIN book b ON y.isbn = b.isbn
                           INNER JOIN gakusei g ON y.gakuno = g.gakuno
                           WHERE y.isbn = @isbn
                           ORDER BY y.yoyakuno ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                int cnt = adapter.Fill(table);

                if (cnt != 0)
                {
                    yoyaku = new Yoyaku();
                    yoyaku.YoyakuNo = (int)table.Rows[0]["yoyakuno"];
                    yoyaku.Title = table.Rows[0]["title"].ToString();
                    yoyaku.GakuName = table.Rows[0]["gakuname"].ToString();
                    yoyaku.MailAddres = table.Rows[0]["mailaddress"].ToString();


                }
                return yoyaku;
            }
        }

        public int Insert(Yoyaku yoyaku)
        {
            int ret = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO yoyaku(isbn,gakuno,yoyakudate) VALUES(@isbn,@gakuno,@yoyakudate)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", yoyaku.Isbn);
                command.Parameters.AddWithValue("@gakuno", yoyaku.GakuNo);
                command.Parameters.AddWithValue("@yoyakudate", yoyaku.YoyakuDate);

                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
        public DataTable GetYoyakuByGakuno(string gakuNo)
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT y.isbn,b.title,yoyakudate FROM yoyaku as y
                             INNER JOIN book as b ON y.isbn=b.isbn
                              WHERE gakuno=@gakuno";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@gakuno", gakuNo);
                adapter.Fill(table);
            }
            return table;
        }
        public bool IsYoyaku(string isbn, string gakuno)
        {
            bool ret = false;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT*FROM yoyaku
                            WHERE isbn=@isbn and gakuno=@gakuno";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                adapter.SelectCommand.Parameters.AddWithValue("@gakuno", gakuno);
                DataTable datatable = new DataTable();
                int cnt = adapter.Fill(datatable);

                if (cnt != 0)
                {
                    ret = true;
                }
                return ret;
            }
        }
        public int Delete(string isbn, string gakuno)
        {
            int ret = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM yoyaku
                            WHERE isbn=@isbn and gakuno=@gakuno";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@gakuno", gakuno);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToshoLibrary
{
    public class KashidashiTable
    {
        public DataTable GetKashidashiTableByGakuNo(string gakuNo)
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT kashidashi.*,title FROM kashidashi
                             INNER JOIN book
                             ON kashidashi.isbn=book.isbn
                             WHERE gakuno=@gakuno";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@gakuno", gakuNo);
                adapter.Fill(table);
            }
            return table;
        }
        public bool IsKashiDashi(string isbn)
        {
            bool ret = false;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT*FROM kashidashi 
                            WHERE isbn=@isbn and hendate is null";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                DataTable datatable = new DataTable();
                int cnt = adapter.Fill(datatable);

                if (cnt != 0)
                {
                    ret = true;
                }
                return ret;
            }
        }
        public int Insert(Kashidashi kashidashi)
        {
            int cnt = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO kashidashi(gakuno,isbn,kashidate,yoteidate) 
                            values(@gakuno,@isbn,@kashidate,@yoteidate)";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@gakuno", kashidashi.GakuNo);
                command.Parameters.AddWithValue("@isbn", kashidashi.Isbn);
                command.Parameters.AddWithValue("@kashidate", kashidashi.KashiDate);
                command.Parameters.AddWithValue("@yoteidate", kashidashi.YoteiDate);

                connection.Open();
                cnt = command.ExecuteNonQuery();

            }
            return cnt;
        }

        public int Henkyaky(string isbn)
        {
            int ret = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE kashidashi set hendate=@today
                            WHERE isbn=@isbn and hendate IS NULL";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@today", DateTime.Today);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
    }
}

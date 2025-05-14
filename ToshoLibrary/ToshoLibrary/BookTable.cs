using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ToshoLibrary
{
    public class BookTable
    {
        public Book GetBookByIsbn(string isbn)
        {
            Book book = null;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT * FROM book WHERE isbn=@isbn";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);

                if (cnt != 0)
                {
                    book = new Book();
                    book.Isbn = table.Rows[0]["isbn"].ToString();
                    book.Title = table.Rows[0]["title"].ToString();
                    book.Writer = table.Rows[0]["writer"].ToString();
                    book.Publisher = table.Rows[0]["publisher"].ToString();
                }
            }
            return book;
        }
        public DataTable GetBookByTitle(string title)
        {
            Book book=null;
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT * FROM book WHERE title LIKE @title";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@title", "%"+title+"%");
                int cnt=adapter.Fill(table);
                if (cnt != 0)
                {
                    book = new Book();
                    book.Isbn = table.Rows[0]["Isbn"].ToString();
                    book.Title = table.Rows[0]["Title"].ToString();
                    book.Writer = table.Rows[0]["Writer"].ToString();
                    book.Publisher = table.Rows[0]["Publisher"].ToString();
                }

            }
            return table;
        }
       
        
    }
}

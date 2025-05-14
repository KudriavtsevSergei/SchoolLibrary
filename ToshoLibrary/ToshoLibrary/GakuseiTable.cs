using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ToshoLibrary
{
    public class GakuseiTable
    {
        public Gakusei GetGakuseiByGakuNo(string gakuNo)
        {
            Gakusei gakusei = null;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT*FROM gakusei WHERE gakuno=@gakuno";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@gakuno", gakuNo);

                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);

                if (cnt != 0)
                {
                    gakusei = new Gakusei();

                    gakusei.GakunNo = table.Rows[0]["gakuno"].ToString();
                    gakusei.GakuName = table.Rows[0]["gakuname"].ToString();
                    gakusei.MailAddress = table.Rows[0]["mailaddress"].ToString();
                    gakusei.Zaiseki = (bool)table.Rows[0]["zaiseki"];
                }
            }
            return gakusei;
        }
        public int Insert(Gakusei gakusei)
        {
            int cnt = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO gakusei(GakuNo,GakuName,MailAddress,Zaiseki)VALUES(@gakuno,@gakuname,@mailaddress,@zaiseki)";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@gakuno", gakusei.GakunNo);
                command.Parameters.AddWithValue("@gakuname", gakusei.GakuName);
                command.Parameters.AddWithValue("@mailaddress", gakusei.MailAddress);
                command.Parameters.AddWithValue("@zaiseki", gakusei.Zaiseki);
                connection.Open();
                try
                {
                    cnt = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }

            }
            return cnt;
        }

        public int Update(Gakusei gakusei)
        {
            int ret = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE gakusei SET GakuName=@gakuname,MailAddress=@mailaddress,Zaiseki=@zaiseki
                WHERE gakuno=@gakuno";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@gakuname", gakusei.GakuName);
                command.Parameters.AddWithValue("@mailaddress", gakusei.MailAddress);
                command.Parameters.AddWithValue("@zaiseki", gakusei.Zaiseki);
                command.Parameters.AddWithValue("@gakuno", gakusei.GakunNo);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
    }
}

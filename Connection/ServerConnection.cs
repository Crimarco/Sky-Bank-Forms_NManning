using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sky_Bank_Forms.Connection
{
    internal class ServerConnection
    {
        public static string stringConnection = "Data Source=DESKTOP-CAAM698\\SQLEXPRESS;Initial Catalog=LoginDatabase;Integrated Security=True";

        public static DataTable executeSQL(string sql)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                connection.ConnectionString = stringConnection;
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error has occured: " + ex.Message,
                    "SQL Server Connection Failed : Sky Bank Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;

        }

    }
}

using Npgsql;
using System;
using System.Data;
using System.Windows;

namespace TabControl
{
    public class CRUD
    {
        public static string passw = "yourpassword";
              
        public static string GetConnectionString()
        {
            
            string host = "Server=localhost;";
            
            string port = "Port=5432;";

            string db = "Database=students;";
            
            string user = "Username=postgres;";
            string pass = "Password=" + passw + ";";

            string conString = String.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);
           
            return conString;

        }


        public static NpgsqlConnection con = new NpgsqlConnection(GetConnectionString());
        public static NpgsqlCommand cmd = default;

        public static string sql = string.Empty;
        public static NpgsqlDataAdapter adp = new NpgsqlDataAdapter();


        public static DataTable PerformCRUD(NpgsqlCommand com)
        {
            DataTable dt = new DataTable();

            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter
                {
                    SelectCommand = com
                };
                da.Fill(dt);

                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                dt = null;
            }

            return dt;
        }
    }
}

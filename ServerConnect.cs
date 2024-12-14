using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedDatabase
{
    internal class ServerConnect
    {
        private static string databaseName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "TestDatabase.mdf");
        /* Make sure to set the property of Database1.mdf named "Copy to Output Directory" to "Always Copy"
         * to be able to update the current version of the database within the build file...
         * 
         * IMPORTANT: With this, building another debug/release version of the application will overwrite the
         * data inside the database, meaning only the database scheme will retain/update. To prevent unnecessary
         * updates from happening, you may choose the option "Copy if newer".
         * 
         * IMPORTANT 2: Close or Detach the connection through the Server Explorer before building/running, or the build
         * may fail. If still does not build, reopen the project or restart your computer.
         */
        private static string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databaseName};Integrated Security=True;Connect Timeout=30;";

        private string TableName = "TestTable";

        internal void InsertData(string text, int number)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"INSERT INTO {TableName} (TextValue,NumberValue) VALUES (@TEXT,@NUMBER)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TEXT", text);
                        cmd.Parameters.AddWithValue("@NUMBER", number);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"QUERY RESULT: Rows affected: {rowsAffected}");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Database Connection Error");
                    conn.Close();
                }
            }
        }
    }
}

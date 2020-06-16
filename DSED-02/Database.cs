using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DSED_02
{
    class Database
    {
        private string connectionString = @"Data Source=DESKTOP-D50HAUI;Initial Catalog=Movies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DataView SelectAll(string selectFields, string table, string whereClause)
        {
            // Open connection
            using (SqlConnection Con = new SqlConnection(
                connectionString))
            {
                Con.Open();
                // Create new DataAdapter
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    $@"SELECT {selectFields} FROM {table} {whereClause}", Con))
                {
                    // Use DataAdapter to fill DataTable
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Create DataView and fill with DataTable
                    DataView returnView = new DataView(dataTable);

                    // Return DataView
                    return returnView;
                }
            }

        }
        public bool CreateData(string table, string setFields, string[] parameterAssign, string parameterAssignFields, string[] data)
        {
            // Define DB connection
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                // Define Query Statement
                string sql = $@"INSERT INTO {table} ({setFields}) VALUES ({parameterAssignFields})";

                // Define SQL Command
                SqlCommand updateData = new SqlCommand(sql, Con);

                if (parameterAssign.Length == data.Length)
                {
                    for (int i = 0; i < parameterAssign.Length; i++)
                    {
                        updateData.Parameters.AddWithValue(parameterAssign[i], data[i]);
                    }
                }

                try
                {
                    Con.Open();

                    // Run SQL Command - Will return how many rows were effected
                    int returnValue = updateData.ExecuteNonQuery();

                    // Close DB Connection
                    Con.Close();


                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
                // Open DB Connection

            }
        }

        public bool UpdateData(string table, string setFields, string whereClause, string[] parameterAssign, string[] data)
        {
            // Define DB connection
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                // Define Query Statement
                string sql = $@"UPDATE {table} SET {setFields} {whereClause}";

                // Define SQL Command
                SqlCommand updateData = new SqlCommand(sql, Con);

                if (parameterAssign.Length == data.Length)
                {
                    for (int i = 0; i < parameterAssign.Length; i++)
                    {
                        updateData.Parameters.AddWithValue(parameterAssign[i], data[i]);
                    }
                }

                try
                {
                    Con.Open();

                    // Run SQL Command - Will return how many rows were effected
                    int returnValue = updateData.ExecuteNonQuery();

                    // Close DB Connection
                    Con.Close();


                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
                // Open DB Connection

            }
        }

        public bool Delete(string table, string whereClause, string[] parameterAssign, string id)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                // Define Query Statement
                string sql = $@"DELETE FROM {table} {whereClause}";

                // Define SQL Command
                SqlCommand deleteData = new SqlCommand(sql, Con);


                deleteData.Parameters.AddWithValue(parameterAssign[0], id);


                // Open DB Connection
                Con.Open();
                try
                {
                    int returnValue = deleteData.ExecuteNonQuery();

                    // Close DB Connection
                    Con.Close();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
                // Run SQL Command - Will return how many rows were effected

            }

        }
    }
}

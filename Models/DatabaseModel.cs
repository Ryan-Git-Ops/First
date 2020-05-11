using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace ShoppingCartApp.Models
{
    public class DatabaseModel
    {
        
       

        
        public string Connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            
            string result = "";
            using (SqlConnection cnn = new SqlConnection(connectionString)) {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("SelectAllDepartments", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cnn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Call Read before accessing data.
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result += $"{ reader.GetValue(i) } \n";
                        }
                    }

                    // Call Close when done reading.
                    reader.Close();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    ex.StackTrace.ToString();
                }
                return result;

            }



        }
    }
}

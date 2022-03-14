using System.Data;
using System.Data.SqlClient;

namespace SnowLogCollector.Classes
{
    class DatabaseManager
    {

        public DataTable ExecuteQuery(string conn, string query, int cmdTimeout = 30)
        {
            using (SqlConnection sCon = new SqlConnection(conn)) // open connection
            {
                using (SqlCommand sCmd = new SqlCommand(query, sCon)) // set command details
                {
                    sCmd.CommandTimeout = cmdTimeout;
                    sCmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sDa = new SqlDataAdapter(sCmd)) // open a sweet data adapter
                    {
                        using (DataTable dt = new DataTable()) // create our datatable
                        {
                            sDa.Fill(dt); // fill it up baby
                            return dt; // return it for use
                        }
                    }

                }
            }
        }

    }
}

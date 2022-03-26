using System;
using System.Data;
using System.Data.SqlClient;

namespace SnowLogCollector.Classes
{
    class DatabaseManager
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DatabaseManager));

        private string _connectionString;
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public bool TestConnectionString(string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            } catch
            {
                return false;
            }
        }

        public string BuildConnectionString(string serverName, string userName = null, string userPass = null, bool winAuth = false)
        {
            if(winAuth)
            {
                SqlConnectionStringBuilder b = new SqlConnectionStringBuilder
                {
                    ["Server"] = serverName,
                    ["integrated Security"] = true,
                    ["Connect Timeout"] = 30,
                    ["Application Name"] = "SnowLogCollector"
                };

                log.Debug(string.Format("Connection string built for server {0} using Windows Authentication", serverName));

                return b.ConnectionString;
            } else
            {
                SqlConnectionStringBuilder b = new SqlConnectionStringBuilder
                {
                    ["Server"] = serverName,
                    ["User Id"] = userName,
                    ["Password"] = userPass,
                    ["Connect Timeout"] = 30,
                    ["Application Name"] = "SnowLogCollector"
                };

                log.Debug(string.Format("Connection string built for server {0} using SQL Authentication", serverName));

                return b.ConnectionString;
            }
        }

        public string DemolishConnectionString(string field)
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder(_connectionString);

            if(field == "Server")
            {
                return b.DataSource;
            } else if(field == "User ID")
            {
                return b.UserID;
            } else if(field == "Password")
            {
                return b.Password;
            } else if(field == "Integrated Security")
            {
                return b.IntegratedSecurity.ToString();
            } else
            {
                return "?";
            }
        }

        public DataTable ExecuteQuery(string query, int cmdTimeout = 30)
        {
            try
            {
                using (SqlConnection sCon = new SqlConnection(_connectionString)) // open connection
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
            } catch (Exception ex)
            {
                log.Error(ex.Message);
                return new DataTable();
            }
        }

        public string ExecuteQueryScalar(string query, string colName, int cmdTimeout = 30)
        {
            try
            {
                using (SqlConnection sCon = new SqlConnection(_connectionString)) // open connection
                {
                    using (SqlCommand sCmd = new SqlCommand(query, sCon)) // set command details
                    {
                        sCmd.CommandTimeout = cmdTimeout;
                        sCmd.CommandType = CommandType.Text;

                        sCon.Open();

                        string data = (string)sCmd.ExecuteScalar();

                        sCon.Close();

                        return data;

                    }
                }
            } catch (Exception ex)
            {
                log.Error(ex.Message);
                return "";
            }
        }

    }
}

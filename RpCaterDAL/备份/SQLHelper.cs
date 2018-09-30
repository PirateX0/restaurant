using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RpCater.DAL
{
    public class SQLHelper
    {
        public static readonly string conStr =
            ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetCon())
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = GetCon())
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameters);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            return table;
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetCon())
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        public static SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            return con;
        }
    }
}
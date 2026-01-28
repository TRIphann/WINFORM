using System.Data;
using System.Data.SqlClient;

namespace JumpArena
{
    internal static class Db
    {
        public static string Cs =>
            System.Configuration.ConfigurationManager.ConnectionStrings["JumpArenaContextDB"].ConnectionString;

        public static DataTable GetDataTable(string sql, params SqlParameter[] ps)
        {
            using (var conn = new SqlConnection(Cs))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

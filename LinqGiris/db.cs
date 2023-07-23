using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGiris
{
    public static class db
    {
        public static SqlConnection conn()
        {
            SqlConnection conn = new SqlConnection("Server=.; Database=nortwind; Integrated Security=true; TrustServerCertificate=True;");
            return conn;
        }
    }
}

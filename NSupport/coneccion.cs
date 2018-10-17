using System.Data.SqlClient;

namespace NSupport
{
    class Coneccion
    {
        public SqlConnection GetConecction()
        {
            SqlConnection myConnection = new SqlConnection("Data Source=64.250.116.210,8333;Initial Catalog=prueba;User ID=wilmer1104@yahoo.com;Password=Q1w2e3r4*/*");
            return myConnection;
        }
    }
}

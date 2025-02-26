using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sga
{
    internal class Conexión_BDD
    {
        private SqlConnection bdd_Con;
        private string cadenaConexion;

        public Conexión_BDD()
        {
            cadenaConexion = "Server=THEIRVIN\\SQLEXPRESS;" +
                "Database=SGA_bdd;" +
                "User Id=SGA_bdd;" +
                "Password=102030;";

            bdd_Con = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (bdd_Con.State == System.Data.ConnectionState.Closed)
                bdd_Con.Open();
            return bdd_Con;
        }

        public void CerrarConexion()
        {
            if (bdd_Con.State == System.Data.ConnectionState.Open)
                bdd_Con.Close();
        }
    }
}

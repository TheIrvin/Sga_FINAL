using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sga
{
    internal class Conexión_BDD
    {
        private SqlConnection bdd_Con;
        private string cadenaConexion;
        public DataTable oDT;
        public SqlCommand oCom;
        public SqlDataReader oDR;
        public SqlDataAdapter oDA;

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
        public DataTable retornaRegistros(string Sentencia)
        {
            if (Sentencia.Length > 0)
            {
                AbrirConexion();
                oCom = new SqlCommand(Sentencia, bdd_Con);
                oDA = new SqlDataAdapter(oCom);
                oDT = new DataTable();
                oDA.Fill(oDT);
                CerrarConexion();
            }
            return oDT;
        }
    }
}

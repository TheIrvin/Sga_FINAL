using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    internal class C_verificar_login
    {
        private string cadenaConexion = "Server=THEIRVIN\\SQLEXPRESS;Database=SGA_bdd;User Id=SGA_bdd;Password=102030;";
        public bool VerificarLogin(string gmail, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Gmail = @Gmail AND Contraseña = @Contraseña";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Gmail", gmail);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    int cuentaUsuarios = (int)cmd.ExecuteScalar();

                    if (cuentaUsuarios > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el login: " + ex.Message);
                    return false;
                }
            }
        }

        public string ObtenerTipoUsuario(string gmail)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT TipoUsuario FROM Usuarios WHERE Gmail = @Gmail";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Gmail", gmail);

                    string tipoUsuario = (string)cmd.ExecuteScalar();
                    return tipoUsuario;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el tipo de usuario: " + ex.Message);
                    return null;
                }
            }
        }

    }
}

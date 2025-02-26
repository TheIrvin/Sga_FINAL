using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    internal class C_el_Registro
    {
        private Conexión_BDD conexion = new Conexión_BDD();

        public bool RegistrarAlumno(string gmail, string contraseña, string nombreCompleto, string cedula, string nombrePadre, string nombreMadre, string telefono)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // Insertar en la tabla Usuarios primero
                        string queryUsuarios = "INSERT INTO Usuarios (Gmail, Contraseña, TipoUsuario) OUTPUT INSERTED.ID VALUES (@Gmail, @Contraseña, 'Alumno')";
                        SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con, transaction);
                        cmdUsuarios.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = gmail;
                        cmdUsuarios.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = contraseña;

                        int usuarioID = (int)cmdUsuarios.ExecuteScalar();

                        // Insertar en la tabla Alumnos con la relación a Usuarios
                        string queryAlumnos = "INSERT INTO Alumnos (UsuarioID, NombreCompleto, Cedula, NombrePadre, NombreMadre, Telefono, Gmail) " +
                                              "VALUES (@UsuarioID, @NombreCompleto, @Cedula, @NombrePadre, @NombreMadre, @Telefono, @Gmail)";
                        SqlCommand cmdAlumnos = new SqlCommand(queryAlumnos, con, transaction);
                        cmdAlumnos.Parameters.Add("@UsuarioID", SqlDbType.Int).Value = usuarioID;
                        cmdAlumnos.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = nombreCompleto;
                        cmdAlumnos.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = cedula;
                        cmdAlumnos.Parameters.Add("@NombrePadre", SqlDbType.VarChar).Value = nombrePadre;
                        cmdAlumnos.Parameters.Add("@NombreMadre", SqlDbType.VarChar).Value = nombreMadre;
                        cmdAlumnos.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;
                        cmdAlumnos.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = gmail;

                        cmdAlumnos.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al registrar alumno: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }

        public bool RegistrarProfesor(string nombres, string apellidos, string cedula, string telefono, string gmail, string contraseña)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string queryUsuarios = "INSERT INTO Usuarios (Gmail, Contraseña, TipoUsuario) OUTPUT INSERTED.ID VALUES (@Gmail, @Contraseña, 'Profesor')";
                        SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con, transaction);
                        cmdUsuarios.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = gmail;
                        cmdUsuarios.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = contraseña;

                        int usuarioID = (int)cmdUsuarios.ExecuteScalar();

                        string queryProfesores = "INSERT INTO Profesores (UsuarioID, Nombres, Apellidos, Cedula, Telefono, Gmail) VALUES (@UsuarioID, @Nombres, @Apellidos, @Cedula, @Telefono, @Gmail)";
                        SqlCommand cmdProfesores = new SqlCommand(queryProfesores, con, transaction);
                        cmdProfesores.Parameters.Add("@UsuarioID", SqlDbType.Int).Value = usuarioID;
                        cmdProfesores.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = nombres;
                        cmdProfesores.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = apellidos;
                        cmdProfesores.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = cedula;
                        cmdProfesores.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;
                        cmdProfesores.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = gmail;

                        cmdProfesores.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al registrar profesor: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }
    }
}

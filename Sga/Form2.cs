using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    public partial class GestionEstudiantes : Form
    {
        Conexión_BDD conSQL = new Conexión_BDD();
        private int? alumnoID = null;
        public GestionEstudiantes()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            string query = "SELECT * FROM Alumnos";
            dvg_Gestion_estudiante.DataSource = conSQL.retornaRegistros(query);
        }

        private void GestionEstudiantes_Load(object sender, EventArgs e)
        {
            dvg_Gestion_estudiante.DataSource = conSQL.retornaRegistros("Select * from Alumnos");
        }

        private void lbnEditar_MouseEnter(object sender, EventArgs e)
        {
            lbnEditar.Size = new Size(103, 34);
        }

        private void lbnEditar_MouseLeave(object sender, EventArgs e)
        {
            lbnEditar.Size = new Size(102, 33);
        }

        private void lbnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            lbnConfirmar.Size = new Size(102, 33);
        }

        private void lbnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            lbnConfirmar.Size = new Size(103, 34);
        }

        private void lbnEliminar_MouseEnter(object sender, EventArgs e)
        {
            lbnEliminar.Size = new Size(103, 34);
        }

        private void lbnEliminar_MouseLeave(object sender, EventArgs e)
        {
            lbnEliminar.Size = new Size(102, 33);
        }

        private void lbnActualizar_MouseEnter(object sender, EventArgs e)
        {
            lbnActualizar.Size = new Size(103, 34);
        }

        private void lbnActualizar_MouseLeave(object sender, EventArgs e)
        {
            lbnActualizar.Size = new Size(102, 33);
        }

        private void lbnConfirmar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conSQL.AbrirConexion())
            {
                if (alumnoID == null) // Si no hay ID, insertar nuevo alumno
                {
                    string queryUsuarios = "INSERT INTO Usuarios (Gmail, Contraseña, TipoUsuario) OUTPUT INSERTED.ID VALUES (@Gmail, @Contraseña, 'Alumno')";
                    using (SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con))
                    {
                        cmdUsuarios.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = txtBox_G_Gmail.Text;
                        cmdUsuarios.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = txtContraseñaEstudiante.Text;
                        int usuarioID = (int)cmdUsuarios.ExecuteScalar();

                        string queryAlumnos = "INSERT INTO Alumnos (UsuarioID, NombreCompleto, Cedula, NombrePadre, NombreMadre, Telefono, Gmail) " +
                                              "VALUES (@UsuarioID, @NombreCompleto, @Cedula, @NombrePadre, @NombreMadre, @Telefono, @Gmail)";
                        using (SqlCommand cmdAlumnos = new SqlCommand(queryAlumnos, con))
                        {
                            cmdAlumnos.Parameters.Add("@UsuarioID", SqlDbType.Int).Value = usuarioID;
                            cmdAlumnos.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = txtBox_G_nombresAlumno.Text;
                            cmdAlumnos.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = txtBox_G_cédulaAlumno.Text;
                            cmdAlumnos.Parameters.Add("@NombrePadre", SqlDbType.VarChar).Value = txtBox_G_nombresPadre.Text;
                            cmdAlumnos.Parameters.Add("@NombreMadre", SqlDbType.VarChar).Value = txtBox_G_nombres_madre.Text;
                            cmdAlumnos.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtBox_G_telefono.Text;
                            cmdAlumnos.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = txtBox_G_Gmail.Text;
                            cmdAlumnos.ExecuteNonQuery();
                        }
                    }
                }
                else // Si hay un ID, actualizar el alumno y la contraseña en Usuarios
                {
                    string queryAlumnos = "UPDATE Alumnos SET NombreCompleto=@NombreCompleto, Cedula=@Cedula, NombrePadre=@NombrePadre, NombreMadre=@NombreMadre, Telefono=@Telefono, Gmail=@Gmail WHERE ID=@ID";
                    using (SqlCommand cmdAlumnos = new SqlCommand(queryAlumnos, con))
                    {
                        cmdAlumnos.Parameters.Add("@ID", SqlDbType.Int).Value = alumnoID;
                        cmdAlumnos.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = txtBox_G_nombresAlumno.Text;
                        cmdAlumnos.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = txtBox_G_cédulaAlumno.Text;
                        cmdAlumnos.Parameters.Add("@NombrePadre", SqlDbType.VarChar).Value = txtBox_G_nombresPadre.Text;
                        cmdAlumnos.Parameters.Add("@NombreMadre", SqlDbType.VarChar).Value = txtBox_G_nombres_madre.Text;
                        cmdAlumnos.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtBox_G_telefono.Text;
                        cmdAlumnos.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = txtBox_G_Gmail.Text;
                        cmdAlumnos.ExecuteNonQuery();
                    }
                    string queryUsuarios = "UPDATE Usuarios SET Contraseña=@Contraseña WHERE Gmail=@Gmail";
                    using (SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con))
                    {
                        cmdUsuarios.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = txtBox_G_Gmail.Text;
                        cmdUsuarios.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = txtContraseñaEstudiante.Text;
                        cmdUsuarios.ExecuteNonQuery();
                    }
                    alumnoID = null; // Resetear ID después de actualizar
                }
            }
            CargarDatos();
        }

        private void dvg_Gestion_estudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvg_Gestion_estudiante.Rows[e.RowIndex];
                alumnoID = Convert.ToInt32(row.Cells["ID"].Value);
                txtBox_G_nombresAlumno.Text = row.Cells["NombreCompleto"].Value.ToString();
                txtBox_G_cédulaAlumno.Text = row.Cells["Cedula"].Value.ToString();
                txtBox_G_nombresPadre.Text = row.Cells["NombrePadre"].Value.ToString();
                txtBox_G_nombres_madre.Text = row.Cells["NombreMadre"].Value.ToString();
                txtBox_G_telefono.Text = row.Cells["Telefono"].Value.ToString();
                txtBox_G_Gmail.Text = row.Cells["Gmail"].Value.ToString();
            }
        }

        private void lbnEliminar_Click(object sender, EventArgs e)
        {
            if (dvg_Gestion_estudiante.SelectedRows.Count > 0)
            {
                string nombreAlumno = txtBox_G_nombresAlumno.Text;
                int idAlumno = Convert.ToInt32(dvg_Gestion_estudiante.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar al alumno {nombreAlumno} con ID {idAlumno}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Alumnos WHERE ID = @ID";
                    using (SqlConnection con = conSQL.AbrirConexion())
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", idAlumno);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un alumno para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}

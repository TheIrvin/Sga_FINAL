using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    public partial class Tareas : Form
    {
        Conexión_BDD conSQL = new Conexión_BDD();


        public Tareas()
        {
            InitializeComponent();
            
        }
        private void CargarDatos()
        {
            string query = "SELECT * FROM Tareas";
            dvg_Gestion_actividades.DataSource = conSQL.retornaRegistros(query);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            dvg_Gestion_actividades.DataSource = conSQL.retornaRegistros("Select * from Tareas");
        }

        private void dvg_Gestion_Actividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvg_Gestion_actividades.Rows[e.RowIndex];

                txtMateria.Text = row.Cells["Materia"].Value.ToString();
                txtTemaActividad.Text = row.Cells["Tema"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
               
            }

        }

        private void dvg_Gestion_Actividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmarTarea_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conSQL.AbrirConexion())
            {
                string queryTareas = "INSERT INTO Tareas (Materia, Tema, Descripcion) " +
                                              "VALUES (@Materia, @Tema, @Descripcion)";
                using (SqlCommand cmdTareas = new SqlCommand(queryTareas, con))
                {
                    cmdTareas.Parameters.Add("@Materia", SqlDbType.VarChar).Value = txtMateria.Text;
                    cmdTareas.Parameters.Add("@Tema", SqlDbType.VarChar).Value = txtTemaActividad.Text;
                    cmdTareas.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                    cmdTareas.ExecuteNonQuery();
                }

            }
            Limpiar();
            CargarDatos();
        }

        private void Limpiar()
        {
            txtMateria.Clear();
            txtTemaActividad.Clear();
            txtDescripcion.Clear();
            
        }
        

        private void btnConfirmarTarea_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmarTarea_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            if (dvg_Gestion_actividades.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar esta tarea?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection con = conSQL.AbrirConexion())
                    {
                        string queryEliminar = "DELETE FROM Tareas WHERE IDTarea = @IDTarea";

                        using (SqlCommand cmdEliminar = new SqlCommand(queryEliminar, con))
                        {
                            int idTarea = Convert.ToInt32(dvg_Gestion_actividades.SelectedRows[0].Cells["IDTarea"].Value);
                            cmdEliminar.Parameters.Add("@IDTarea", SqlDbType.Int).Value = idTarea;
                            cmdEliminar.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Tarea eliminada correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos(); 
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarEliminacion_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnConfirmarEliminacion_MouseLeave(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    public partial class Asistencia00 : Form
    {
        public Asistencia00()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void lbnRegistro_Click(object sender, EventArgs e)
        {

        }
        private void CargarDatos()
        {
            Conexión_BDD conexion = new Conexión_BDD();
            dgv_verAlumnos.RowTemplate.Height = 50;

            dgv_verAlumnos.DataSource = conexion.ObtenerAlumnos();
            PersonalizarDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_verAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void PersonalizarDataGridView()
        {
            dgv_verAlumnos.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv_verAlumnos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv_verAlumnos.GridColor = Color.Black;
            dgv_verAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_verAlumnos.DefaultCellStyle.Font = new Font("Arial", 12);
            dgv_verAlumnos.AllowUserToResizeColumns = false; // No permitir redimensionar columnas
            dgv_verAlumnos.AllowUserToResizeRows = false;
            
            dgv_verAlumnos.Refresh();

        }
        private void Asistencia00_Load(object sender, EventArgs e)
        {
            PersonalizarDataGridView();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Checkbox_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pnl_Checkbox1_Paint(object sender, PaintEventArgs e)
        {
            //Control panel = (Control)sender;
            //using (Pen pen = new Pen(Color.DarkBlue, 2)) // Color y grosor del borde
            //{
            //    e.Graphics.DrawRectangle(pen, 2, 1, panel.Width - 3, panel.Height - 3);
            //}
        }
        private Dictionary<string, bool> pictureBoxStates = new Dictionary<string, bool>();
        public void CambioImagen(string pictureBoxName)
        {
            // Verificar si el estado del PictureBox ya está registrado en el diccionario
            if (!pictureBoxStates.ContainsKey(pictureBoxName))
            {
                pictureBoxStates[pictureBoxName] = false; // Inicialmente, el estado es "unchecked"
            }

            // Obtener el PictureBox correspondiente usando el nombre proporcionado
            PictureBox picbox = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;

            // Verificar que el PictureBox realmente exista
            if (picbox != null)
            {
                // Alternar la imagen de acuerdo con el estado
                if (pictureBoxStates[pictureBoxName])
                {
                    picbox.Image = Properties.Resources.cuadrado_vacio2; // Imagen vacía
                }
                else
                {
                    picbox.Image = Properties.Resources.cuadrado_LLENO; // Imagen con el check
                }

                // Cambiar el estado del PictureBox
                pictureBoxStates[pictureBoxName] = !pictureBoxStates[pictureBoxName];
            }
            else
            {
                MessageBox.Show($"No se encontró el PictureBox con el nombre: {pictureBoxName}");
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool isChecked = false;

        public void cambio()
        {
           
        }
       

        private void pc_a2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_a2");
        }

        private void pc_a3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_a3");
        }

        private void pc_a4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_a4");
        }

        private void pc_a5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_a5");
        }

        private void pc_b1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_a1");
        }

        private void pc_b2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_b2");
        }

        private void pc_b3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_b3");
        }

        private void pc_b4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_b4");
        }

        private void pc_b5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_b5");
        }

        private void pc_c1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_c1");
        }

        private void pc_c2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_c2");
        }

        private void pc_c3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_c3");
        }

        private void pc_c4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_c4");
        }

        private void pc_c5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_c5");
        }

        private void pc_d1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_d1");
        }

        private void pc_d2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_d2");
        }

        private void pc_d3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_d3");
        }

        private void pc_d4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_d4");
        }

        private void pc_d5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_d5");
        }

        private void pc_e1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_e1");
        }

        private void pc_e2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_e2");
        }

        private void pc_e3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_e3");
        }

        private void pc_e4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_e4");
        }

        private void pc_e5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_e5");
        }

        private void pc_f1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_f1");
        }

        private void pc_f2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_f2");
        }

        private void pc_f3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_f3");
        }

        private void pc_f4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_f4");
        }

        private void pc_f5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_f5");
        }

        private void pc_g1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_g1");
        }

        private void pc_g2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_g2");
        }

        private void pc_g3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_g3");
        }

        private void pc_g4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_g4");
        }

        private void pc_g5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_g5");
        }

        private void pc_h1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_h1");
        }

        private void pc_h2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_h2");
        }

        private void pc_h3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_h3");
        }

        private void pc_h4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_h4");
        }

        private void pc_h5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_h5");
        }

        private void pc_i1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_i1");
        }

        private void pc_i2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_i2");
        }

        private void pc_i3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_i3");
        }

        private void pc_i4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_i4");
        }

        private void pc_i5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_i5");
        }

        private void pc_j1_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_j1");
        }

        private void pc_j2_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_j2");
        }

        private void pc_j3_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_j3");
        }

        private void pc_j4_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_j4");
        }

        private void pc_j5_Click(object sender, EventArgs e)
        {
            CambioImagen("pc_j5");
        }

        private void pc_a1_Click_1(object sender, EventArgs e)
        {
            CambioImagen("pc_a1");
        }
    }
}

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
    public partial class GestionEstudiantes : Form
    {
        Conexión_BDD conSQL = new Conexión_BDD();
        
        public GestionEstudiantes()
        {
            InitializeComponent();
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

        private void lbnAtras_MouseEnter(object sender, EventArgs e)
        {
            lbnAtras.Size = new Size(103, 34);
        }

        private void lbnAtras_MouseLeave(object sender, EventArgs e)
        {
            lbnAtras.Size = new Size(102, 33);
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
    }
}

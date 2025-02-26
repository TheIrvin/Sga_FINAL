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
    public partial class Menu_Profesor : Form
    {
        public Menu_Profesor()
        {
            InitializeComponent();
        }

       
        private void AbrirEnPanelCliente(Form formClientes)
        {
            if (this.panel_menuProfesor.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }

            Form fn = formClientes as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.panel_menuProfesor.Controls.Add(fn);
                this.panel_menuProfesor.Tag = fn;
                fn.Show();
            }
        }

        private void Menu_Profesor_Load(object sender, EventArgs e)
        {

        }

        private void btnAggAlumnos_Click(object sender, EventArgs e)
        {
            AbrirEnPanelCliente(new GestionEstudiantes());
        }

        private void btnCerrarMP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

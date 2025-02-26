using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sga
{
    public partial class Registro_profesor : Form
    {
        public Registro_profesor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void bt_CerrarRegis_profesor_Clik(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxiRegisProfe_Click(object sender, EventArgs e)
        {
            btnMaxiRegisProfe.Visible = false;
            btnRestauRegisProfe.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMiniRegisProfe_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestauRegisProfe_Click(object sender, EventArgs e)
        {
            btnRestauRegisProfe.Visible = false;
            btnMaxiRegisProfe.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void panel_sga_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_regresar_profesor_Click(object sender, EventArgs e)
        {
            Form1 regresar_profesor = new Form1();
            regresar_profesor.Show();
            this.Close();
        }

        private void bt_crearCuenta_profesor_Click(object sender, EventArgs e)
        {
            C_el_Registro registro_profesor = new C_el_Registro();

            bool resultado = registro_profesor.RegistrarProfesor(
                txtbox_profesor_nombres.Text,
                txtbox_profesor_apellidos.Text,
                txtbox_profesor_cédula.Text,
                txtbox_profesor_teléfono.Text,
                txtbox_profesor_gmail.Text,
                txtbox_profesor_contraseña.Text            
               
            );

            if (resultado)
            {
                MessageBox.Show("Profesor registrado con éxito.");
                txtbox_profesor_nombres.Text = "";
                txtbox_profesor_apellidos.Text = "";
                txtbox_profesor_cédula.Text = "";
                txtbox_profesor_teléfono.Text = "";
                txtbox_profesor_gmail.Text = "";
                txtbox_profesor_contraseña.Text = "";
            }
        }

        private void bt_CerrarRegis_profesor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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

namespace Sga
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximizarmenu_Click(object sender, EventArgs e)
        {
            btnMaximizarmenu.Visible = false;
            btnRestaurarM.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurarM_Click(object sender, EventArgs e)
        {
            btnRestaurarM.Visible = false;
            btnMaximizarmenu.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            Asistencia frmAsis = new Asistencia();
            frmAsis.Show();
        }
    }
}

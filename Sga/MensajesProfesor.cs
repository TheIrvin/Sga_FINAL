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
    public partial class MensajesProfesor : Form
    {
        
        public MensajesProfesor()
        {
            InitializeComponent();
        }
       

        private void btnLimpiarsms_Click(object sender, EventArgs e)
        {
            rtbMensajes.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string Mensaje = rtbMensajes.Text;
            MensajesEstudiantes formDestino = new MensajesEstudiantes();
            formDestino.mensaje = Mensaje;
        }
    }
}

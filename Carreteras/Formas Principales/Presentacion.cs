using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreteras
{
    public partial class frmIntroduccion : Form
    {
        public frmIntroduccion()
        {
            InitializeComponent();
        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblInformacion_Click(object sender, EventArgs e)
        {
            mensaje msg = new mensaje();
            msg.ShowDialog();
        }

        private void lblAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de base de datos para el registro de carreras del país.\nVersion 0.0.1","Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;
        private void pbFondo_MouseMove(object sender, MouseEventArgs e)
        {
            //Si Boton izquierdo esta activo
            if (e.Button != MouseButtons.Left)
            {
                //Posicion del boton se mandara a posicion de la ventana respecto a la pantalla
                posicion_x = e.X;
                posicion_y = e.Y;
            }
            else
            {
                Left = Left + (e.X - posicion_x);
                Top = Top + (e.Y - posicion_y);
            }
        }
    }
}

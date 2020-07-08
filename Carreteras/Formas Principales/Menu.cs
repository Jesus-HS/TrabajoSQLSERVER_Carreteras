using Carreteras.Formas_del_Menu;
using System;
using System.Windows.Forms;

namespace Carreteras
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void lblSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
        }

        private void cmdCarretera_Click(object sender, EventArgs e)
        {
            frmCarretera carretera = new frmCarretera();
            carretera.ShowDialog();
        }

        private void cmdComuna_Click(object sender, EventArgs e)
        {
            frmComuna comuna = new frmComuna();
            comuna.ShowDialog();
        }

        private void cmdTramo_Click(object sender, EventArgs e)
        {
            frmTramo tramo = new frmTramo();
            tramo.ShowDialog();
        }
        //Para mover la forma sin borde
        int posicion_x = 0, posicion_y = 0;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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

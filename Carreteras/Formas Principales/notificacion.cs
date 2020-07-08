using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreteras.Formas_Principales
{
    public partial class notificacion : Form
    {
        public notificacion(string mensaje, Color fondo)
        {
            InitializeComponent();
            this.BackColor = fondo;
            this.lblMensaje.Text = mensaje;
        }

        private void notificacion_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = Screen.PrimaryScreen.Bounds.Width - Width -20;
        }
    }
}

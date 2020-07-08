using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreteras.InformeTramo
{
    public partial class Tramo_RV : Form
    {
        public Tramo_RV()
        {
            InitializeComponent();
        }

        private void Tramo_RV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Tramo.TRAMO' Puede moverla o quitarla según sea necesario.
            this.TRAMOTableAdapter.Fill(this.Tramo.TRAMO);

            this.reportViewer1.RefreshReport();
        }
    }
}

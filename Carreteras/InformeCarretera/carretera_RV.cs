using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreteras.InformeCarretera
{
    public partial class carretera_RV : Form
    {
        public carretera_RV()
        {
            InitializeComponent();
        }

        private void carretera_RV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Carretera.CARRETERA' Puede moverla o quitarla según sea necesario.
            this.CARRETERATableAdapter.Fill(this.Carretera.CARRETERA);

            this.reportViewer1.RefreshReport();
        }
    }
}

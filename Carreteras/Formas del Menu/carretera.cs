using Carreteras.Formas_Principales;
using Carreteras.InformeCarretera;
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
    public partial class frmCarretera : Form
    {
        Consultas consulta;
        public frmCarretera()
        {
            InitializeComponent();
            ttMensaje.SetToolTip(pbInsertar, "Insertar datos");
            ttMensaje.SetToolTip(pbBorrar, "Borrar datos");
            ttMensaje.SetToolTip(pbBuscar, "Buscar datos");
            ttMensaje.SetToolTip(pbEditar, "Actualizar datos");

            consulta = new Consultas();

            consulta.Consulta(dataGridView1, "SELECT *FROM carretera");
        }

        private void pbInsertar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("INSERT INTO carretera VALUES(" + txtid.Text+","+txtKm.Text + ","+txtidCategoria.Text + ")");
            consulta.Consulta(dataGridView1, "SELECT *FROM carretera");
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("DELETE FROM carretera WHERE idCarretera='" + txtid.Text + "'");
            consulta.Consulta(dataGridView1, "SELECT *FROM carretera");
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            consulta.Consulta(dataGridView1, "SELECT *FROM carretera WHERE idCarretera='" + txtid.Text + "'");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("UPDATE carretera SET km='" + txtKm.Text + "',idCategoria='" + txtidCategoria.Text + "' WHERE idCarretera = '" + txtid.Text + "'");
            consulta.Consulta(dataGridView1, "SELECT *FROM carretera");
        }

        private void cmdGenerarInforme_Click(object sender, EventArgs e)
        {
            carretera_RV ct = new carretera_RV();
            ct.Show();
        }
    }
}

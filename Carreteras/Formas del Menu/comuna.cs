using Carreteras.Formas_Principales;
using Carreteras.InformeComuna;
using System;
using System.Windows.Forms;

namespace Carreteras
{
    public partial class frmComuna : Form
    {
        Consultas consulta;
        public frmComuna()
        {
            InitializeComponent();
            ttMensaje.SetToolTip(pbInsertar, "Insertar datos");
            ttMensaje.SetToolTip(pbBorrar, "Borrar datos");
            ttMensaje.SetToolTip(pbBuscar, "Buscar datos");
            ttMensaje.SetToolTip(pbEditar, "Actualizar datos");

            consulta = new Consultas();

            consulta.Consulta(dataGridView1, "SELECT *FROM comuna");
        }

        private void pbInsertar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("INSERT INTO comuna VALUES("+txtid.Text + ",'"+txtNombre.Text + "','"+txtUbicacion.Text + "',"+txtidTramo.Text+")");
            consulta.Consulta(dataGridView1, "SELECT *FROM comuna");
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("DELETE FROM comuna WHERE idComuna='" + txtid.Text + "'");
            consulta.Consulta(dataGridView1, "SELECT *FROM comuna");
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            consulta.Consulta(dataGridView1, "SELECT *FROM comuna WHERE idComuna='" + txtid.Text + "'");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("UPDATE comuna SET nombre = '"+txtNombre.Text+"',ubicacion='"+txtUbicacion.Text+"',idTramo='"+txtidTramo.Text+"' WHERE idComuna = '" + txtid.Text + "'");
            consulta.Consulta(dataGridView1, "SELECT *FROM comuna");
        }

        private void cmdGenerarInforme_Click(object sender, EventArgs e)
        {
            Comuna_RV cm = new Comuna_RV();
            cm.Show();
        }
    }
}

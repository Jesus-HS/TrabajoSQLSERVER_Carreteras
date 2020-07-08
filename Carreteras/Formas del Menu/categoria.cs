using Carreteras.Formas_Principales;
using System;
using System.Windows.Forms;

namespace Carreteras.Formas_del_Menu
{
    public partial class frmCategoria : Form
    {
        Consultas consulta;
        public frmCategoria()
        {
            InitializeComponent();
            ttMensaje.SetToolTip(pbInsertar, "Insertar datos");
            ttMensaje.SetToolTip(pbBorrar, "Borrar datos");
            ttMensaje.SetToolTip(pbBuscar, "Buscar datos");
            ttMensaje.SetToolTip(pbEditar, "Actualizar datos");

            consulta = new Consultas();

            consulta.Consulta(dataGridView1, "SELECT *FROM categoria");
        }

        private void pbInsertar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("INSERT INTO categoria VALUES(" + txtid.Text + ",'" + txtNombre.Text + "')");
            consulta.Consulta(dataGridView1, "SELECT *FROM categoria");
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("DELETE FROM categoria WHERE idCategoria='" + txtid.Text + "'");
            consulta.Consulta(dataGridView1, "SELECT *FROM categoria");
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            consulta.Consulta(dataGridView1,"SELECT *FROM categoria WHERE idCategoria='"+txtid.Text+"'");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("UPDATE categoria SET nombre='" + txtNombre.Text + "' WHERE idCategoria = '"+txtid.Text+"'");
            consulta.Consulta(dataGridView1, "SELECT *FROM categoria");
        }

        private void cmdGenerarInforme_Click(object sender, EventArgs e)
        {
            categoria_RV ct = new categoria_RV();
            ct.Show();
        }
    }
}

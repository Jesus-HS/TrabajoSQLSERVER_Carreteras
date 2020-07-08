using Carreteras.Formas_Principales;
using Carreteras.InformeTramo;
using System;
using System.Windows.Forms;

namespace Carreteras
{
    public partial class frmTramo : Form
    {
        //Declaramos un objeto tipo Consultas
        //El fin de este es traer los procesos para la conexion y consultas
        Consultas consulta;
        //Al iniciar la forma todo esto ocurrira
        public frmTramo()
        {
            InitializeComponent();
            //Iniciamos los textos de los tooltip
            ttMensaje.SetToolTip(pbInsertar, "Insertar datos");
            ttMensaje.SetToolTip(pbBorrar, "Borrar datos");
            ttMensaje.SetToolTip(pbBuscar, "Buscar datos");
            ttMensaje.SetToolTip(pbEditar, "Actualizar datos");
            //Realizamos la conexion a la base de datos
            consulta = new Consultas();
            //Mostramos la tabla
            consulta.Consulta(dataGridView1, "SELECT *FROM tramo");
        }
        //Metodo para insertar datos
        private void pbInsertar_Click(object sender, EventArgs e)
        {
            //Insertamos valor
            consulta.Consulta("INSERT INTO tramo VALUES(" + txtid.Text + "," + txtKm.Text + ",'"+txtInicio.Text+"','"+txtFinal.Text+"',"+txtidCarretera.Text+")");
            //Actualizamos data gridview
            consulta.Consulta(dataGridView1, "SELECT *FROM tramo");
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            consulta.Consulta("DELETE FROM tramo WHERE idTramo='" + txtid.Text + "'");
            consulta.Consulta(dataGridView1, "SELECT *FROM tramo");
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            //Realizamos una consulta
            consulta.Consulta(dataGridView1, "SELECT *FROM tramo WHERE idTramo='" + txtid.Text + "'");
        }
        //Metodo para editar tabla
        private void pbEditar_Click(object sender, EventArgs e)
        {
            //Realizamos consulta para la actualizacion de datos
            consulta.Consulta("UPDATE tramo SET km='" + txtKm.Text+"',inicio='"+txtInicio.Text+"',final='"+txtFinal.Text+"',idCarretera='"+txtidCarretera.Text+"' WHERE idTramo = '" + txtid.Text + "'");
            //Realizamos la reimpresion de datos
            consulta.Consulta(dataGridView1, "SELECT *FROM tramo");
        }
        //Genera el informe
        private void cmdGenerarInforme_Click(object sender, EventArgs e)
        {
            Tramo_RV tr = new Tramo_RV();
            tr.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreteras.Formas_Principales
{
    class Consultas
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        notificacion hi;

        /// <summary> 
        /// Realiza una conexion a la tabla
        /// </summary>
        public Consultas()
        {
            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-L0KF26J2\\SQLEXPRESS; Initial Catalog=dbCarreteras; Integrated Security=True");
                cn.Open();
                hi = new notificacion("Conexion exitosa", Color.FromArgb(40, 167, 69));
                hi.Show();
                Task.Delay(2000).Wait();
                hi.Close();
            }
            catch (Exception es)
            {
                hi = new notificacion("Conexión con error", Color.FromArgb(220, 53, 69));
                hi.Show();
                Task.Delay(2000).Wait();
                hi.Close();
            }
        }
        /// <summary> 
        /// Metodo para mostrar o buscar dentro de una tabla, recibe DataGridView para actualizar y una consulta
        /// </summary>
        public void Consulta(DataGridView dgv, string consulta)
        {
            try
            {
                da = new SqlDataAdapter(consulta, cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido mostrar la tabla, código de error: \n" + ex);
            }
        }
        /// <summary> 
        /// Recibe solo 1 parametro, para consulta sobre insertar, borrar o modificar
        /// </summary>
        public void Consulta(string consulta)
        {
            try
            {
                cmd = new SqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro insertar:" + ex);
            }
        }
    }
}

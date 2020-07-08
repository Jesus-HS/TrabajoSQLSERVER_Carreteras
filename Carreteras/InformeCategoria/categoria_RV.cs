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
    public partial class categoria_RV : Form
    {
        public categoria_RV()
        {
            InitializeComponent();
        }

        private void reportviewer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Categoria.CATEGORIA' Puede moverla o quitarla según sea necesario.
            this.CATEGORIATableAdapter.Fill(this.Categoria.CATEGORIA);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

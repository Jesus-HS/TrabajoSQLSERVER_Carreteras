using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreteras.InformeComuna
{
    public partial class Comuna_RV : Form
    {
        public Comuna_RV()
        {
            InitializeComponent();
        }

        private void Comuna_RV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Comuna.COMUNA' Puede moverla o quitarla según sea necesario.
            this.COMUNATableAdapter.Fill(this.Comuna.COMUNA);

            this.reportViewer1.RefreshReport();
        }
    }
}

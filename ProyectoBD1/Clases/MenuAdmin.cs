using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD1.Clases
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void radioArchivo_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void radioPersonal_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void radioInventario_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void radioFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void radioClientes_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }
    }
}

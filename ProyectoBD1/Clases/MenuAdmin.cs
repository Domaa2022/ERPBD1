using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

      

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Personal p1 = new Personal();
            p1.MdiParent = this;
            p1.Show();
           
        }
    }
}

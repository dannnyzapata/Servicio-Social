using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomas
{
    public partial class VisorAlumnos : Form
    {
        public VisorAlumnos(string TablaVer)
        {
            InitializeComponent();
            this.Show();
            Conexion con = new Conexion();

            con.conectar();

            //dgvAlumnos.DataSource = con.ejecutarQuery("SELECT * FROM "+ TablaVer);

            con.ejecutarQuery("SELECT ");
            con.desconectar();

        }

        private void VisorAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}

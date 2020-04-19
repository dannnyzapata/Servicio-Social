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
    public partial class Subir : Form
    {
        string ver;
        string upar;

        public Subir(string TablaVer, string SubirDe)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
            Conexion con = new Conexion();           
            ver = TablaVer;
            lbCurso.Text = TablaVer;
            upar = SubirDe;           
            con.conectar();
            dgvAlumnos.DataSource = con.ejecutarQuery("SELECT Folio, CONCAT(Nombre, ' ', Apellido1, ' ', Apellido2) AS Nombre FROM " + SubirDe + " WHERE Upgrade = 'False'");           
            con.desconectar();          

        }

        private void VisorAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
            (dgvAlumnos.DataSource as DataTable).DefaultView.RowFilter = $"Nombre LIKE '{txtBuscar.Text}%'";
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {                       
            int Folio;
            Folio = Int32.Parse(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
            Pasar Editar = new Pasar(Folio, ver, upar);           
        }
    }
}

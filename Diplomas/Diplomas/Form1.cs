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
    public partial class Datos : Form
    {
        int i = 0;

        Conexion con = new Conexion();
        public Datos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumnosDBDataSet.Registrados' table. You can move, or remove it, as needed.
            this.registradosTableAdapter.Fill(this.alumnosDBDataSet.Registrados);

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            con.conectar();

            i++;
            con.ejecutaTransaccion("insert into Registrados values ('" +
                txtNombre.Text + "','"
                + txtApellido1.Text + "','"
                + txtApellido2.Text + "','"
                 + txtCorreo.Text + "','"
                + dtpFecha.Value.ToString("dd/MM/yyyy") + "')"
                );
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();


            /*foreach (DataGridViewRow row in dgvAlumnos.Rows)
            {
                con.ejecutaTransaccion("insert into Registrados values('NULL','" + row.Cells["Nombre"].Value.ToString() + "','" + row.Cells["Apellido1"].Value.ToString()
                    + "','" + row.Cells["Apellido2"].Value.ToString() + "','" + row.Cells["Correo"].Value.ToString() + "','"
                    + row.Cells["Apellido1"].Value.ToString() + "','" + row.Cells["Fecha"].Value.ToString() + "')");
            }

            */
            con.desconectar();
        }

        private void btDiplomas_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            int pfolio;
            //con.conectar();
            //string folios; 
            //folios = con.ejecutarQuery("select count(*) from Registrados").ToString();
            // MessageBox.Show(folios);

            pfolio = con.nAlumnos();
            //MessageBox.Show(pfolio.ToString());

            con.desconectar();
            Diplomad pDiploma = new Diplomad(pfolio);
            //pDiploma.ShowDialog();
           

        }
    }
}

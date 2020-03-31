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
        
        public static string SetValueParaChecador;
        Conexion con = new Conexion();
        public Datos()
        {
            InitializeComponent();
            dtpFecha.Value = System.DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCursos.SelectedIndex = 0;

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Contains("@"))
            {
                con.conectar();
                con.ejecutaTransaccion("insert into " + cbCursos.SelectedItem.ToString() + " values ('" +
                    txtNombre.Text + "','"
                    + txtApellido1.Text + "','"
                    + txtApellido2.Text + "','"
                     + txtCorreo.Text + "','"
                    + dtpFecha.Value.ToString("dd/MM/yyyy") + "','" + pcbFoto.Image + "','FALSE');"
                    );
                txtApellido1.Clear();
                txtApellido2.Clear();
                txtCorreo.Clear();
                txtNombre.Clear();
                pcbFoto.Image = null;
                MessageBox.Show("Alumno en base de Datos");
                con.desconectar();
            }
            else
            {
                MessageBox.Show("Introdusca un correo valido por favor");
            }



        }

        private void btDiplomas_Click(object sender, EventArgs e)
        {

            Conexion con = new Conexion();

            
            int pfolio, ultimo;
            

            pfolio = con.nAlumnos(cbCursos.SelectedItem.ToString());
            ultimo = con.nUltimo(cbCursos.SelectedItem.ToString());
          

            con.desconectar();

            string check = cbCursos.SelectedItem.ToString();
            SetValueParaChecador = check;

            Checador vChecar = new Checador(pfolio, ultimo, cbCursos.SelectedItem.ToString());
   

        }

        private void btPic_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFile.ShowDialog();
                pcbFoto.Load(this.AbrirFile.FileName);

            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen");
            }
        }

        private void btVerAlu_Click(object sender, EventArgs e)
        {

            VisorAlumnos vAlumnos = new VisorAlumnos(cbCursos.SelectedItem.ToString());
            
        }
    }
}

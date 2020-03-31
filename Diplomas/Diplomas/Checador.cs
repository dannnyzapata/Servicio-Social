using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace Diplomas
{


    public partial class Checador : Form
    {
        Conexion con = new Conexion();
        int conv;
       
        
        
        public Checador(int folio, int ultimo, string curso)
        {
            this.Show();
            InitializeComponent();

            dtpExpedicion.Value = System.DateTime.Now;
            dtpGraduar.Value = System.DateTime.Now;


            for (int i = folio; i <= ultimo; i++)
            {
                if (con.VoF(i,curso) == "True")
                {
                    goto next;
                }

                else
                {                                       
                    cblAlumnos.Items.Add(con.AlumnoFolio(i, curso));                  
                    Lista.Items.Add(con.AlumnoNombre(i,curso));
                }

            next:;
            }
            

        }

        

        private void btDiplomas_Click(object sender, EventArgs e)
        {
            string expedir;
            string graduado;
            string horas;
            

            

            string cursos = Datos.SetValueParaChecador;

            
            

            expedir = dtpExpedicion.Value.Day.ToString() + " de " + dtpExpedicion.Value.ToString("MMMM") + " del " + dtpExpedicion.Value.Year.ToString();
            graduado = dtpGraduar.Value.Day.ToString() + " de " + dtpGraduar.Value.ToString("MMMM") + " del " + dtpGraduar.Value.Year.ToString();
            horas = spHoras.Value.ToString();

            foreach (var Checado in cblAlumnos.CheckedItems)
            {
                conv = Int32.Parse(Checado.ToString());

                switch (cursos)
                {
                    case "Basico":
                        Diplomad pDiploma = new Diplomad(conv, graduado, expedir, horas, cursos);
                        break;
                    case "IntermedioI":
                        IntermedioI pIntermedioI = new IntermedioI(conv, graduado, expedir, horas, cursos);
                        break;
                    case "IntermedioII":
                        IntermedioII pIntermedioII = new IntermedioII(conv, graduado, expedir, horas, cursos);
                        break;
                    case "IntermedioIII":
                        IntermedioIII pIntermedioIII = new IntermedioIII(conv, graduado, expedir, horas, cursos);
                        break;
                    case "IntermedioIV":
                        IntermedioIV pIntermedioIV = new IntermedioIV(conv, graduado, expedir, horas, cursos);
                        break;
                }                       
            }
            this.Close();

        }


        private void Checador_Load(object sender, EventArgs e)
        {

            
            
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            cblAlumnos.TopIndex = vScrollBar1.Value;
            Lista.TopIndex = vScrollBar1.Value;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

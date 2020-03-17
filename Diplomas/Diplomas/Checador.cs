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
        
        
        public Checador(int folio, int ultimo)
        {
            this.Show();
            InitializeComponent();
          

            for (int i = folio; i <= ultimo; i++)
            {
                if (con.VoF(i) == "True")
                {
                    goto next;
                }

                else
                {                                       
                    cblAlumnos.Items.Add(con.LabelFolio(i));                  
                    Lista.Items.Add(con.LabelName(i));
                }

            next:;
            }


        }

        private void btDiplomas_Click(object sender, EventArgs e)
        {
            string expedir;
            string graduado;
            expedir = dtpExpedicion.Value.Day.ToString() + " de " + dtpExpedicion.Value.ToString("MMMM") + " del " + dtpExpedicion.Value.Year.ToString();
            graduado = dtpGraduar.Value.Day.ToString() + " de " + dtpGraduar.Value.ToString("MMMM") + " del " + dtpGraduar.Value.Year.ToString();


            foreach (var Checado in cblAlumnos.CheckedItems)
            {
                conv = Int32.Parse(Checado.ToString());

                
                Diplomad pDiploma = new Diplomad(conv, graduado, expedir);

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

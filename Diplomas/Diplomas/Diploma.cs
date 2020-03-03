using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Diplomas
{
    public partial class Diplomad : Form
    {
        Conexion con = new Conexion();
        public Diplomad(int folio)
        {

            InitializeComponent();

            

            for(int i=1; i<folio; i++)
            {
                lbNombre.Text = con.LabelName(i);
                /*con.conectar();
                lbFolio.Text = con.ejecutarQuery("select Folio FROM Registrados WHERE Folio= " + i).ToString();
                con.desconectar();*/
                lbFolio.Text = con.LabelFolio(i);


                this.Show();
                this.Hide();
                using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(@"Diplomas/" + lbNombre.Text + ".bmp");

                }
            }

           
        }
    }
}

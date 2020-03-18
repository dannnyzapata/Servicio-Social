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
          
        public Diplomad(int checar, string graduado, string expedido, string horas)
        {
            

            InitializeComponent();     
            lbChihu.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            lbDel.BackColor = Color.Transparent;
            lbNombre.Text = con.LabelName(checar);
            lbNombre.BackColor = Color.Transparent;
            lbFolio.Text = con.LabelFolio(checar);
            lbFolio.BackColor = Color.Transparent;
            lbExp.Text = expedido;
            lbExp.BackColor = Color.Transparent;
            lbFinal.Text = graduado;
            lbFinal.BackColor = Color.Transparent;
            lbInicio.Text = con.ObtenerFechaInicio(checar);
            lbInicio.BackColor = Color.Transparent;
            lbHoras.Text = "Con una duración de " + horas + "hrs.";
            lbHoras.BackColor = Color.Transparent;


            this.Show();
            this.Hide();
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"Diplomas/" + lbNombre.Text + ".bmp");

            }
                    /*
            System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();
            string correoenv = con.ObtenerCorreo(i);
            mensaje.To.Add(correoenv);
            mensaje.Subject = "Aquí ponemos el Subject que la instución quiera poner";
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            mensaje.Body = "Aquí ponemos lo que la institución quiera poner";
            mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            mensaje.IsBodyHtml = true;
            mensaje.From = new System.Net.Mail.MailAddress("***");//(CorreoFromAquí)
            string ruta = @"Diplomas/" + lbNombre.Text + ".bmp";
            System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
            mensaje.Attachments.Add(archivo);
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("***", "***");//(CorreoAquí,ContraseñaAquí); Sacar de servidor
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;                  

           try
           {
                cliente.Send(mensaje);

           }
           catch (Exception)
           {
                MessageBox.Show("Error al enviar correo");
           }
                    */
           con.conectar();
           con.ejecutaTransaccion("UPDATE Registrados SET Graduado = 'TRUE' WHERE Folio= " + checar);
           con.desconectar();
         }
                
            
      }


}

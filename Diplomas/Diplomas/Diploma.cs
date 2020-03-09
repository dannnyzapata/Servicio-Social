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
        public Diplomad(int folio, int ultimo)
        {

            InitializeComponent();


            

            for(int i=folio; i<=ultimo; i++)
            {
                if (con.VoF(i) == "True")
                {
                    goto next;
                }

                else 
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
                    /*System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();
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
                    con.ejecutaTransaccion("UPDATE Registrados SET Graduado = 'TRUE' WHERE Folio= " + i);
                    con.desconectar();
                }
                
            next:;
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Net;

namespace Diplomas
{
    public class Conexion
    {
        static string nombserv = Dns.GetHostName();
        static string cadenaConexion = "Data Source= " + nombserv + "\\SQLEXPRESS;Initial Catalog=AlumnosDB;Integrated Security=True";
        SqlConnection conn = new SqlConnection(cadenaConexion);
        public void conectar()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void desconectar()
        {
            conn.Close();
        }
        public DataTable ejecutarQuery(string consulta)
        {
            DataTable resultado = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            adaptador.Fill(resultado);
            return resultado;
        }
        public bool ejecutaTransaccion(string consulta)
        {
            bool bien = true;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                bien = false;
                MessageBox.Show(ex.Message);
            }
            return bien;
        }

        public int nAlumnos()
        {
            {
                string stmt = "SELECT COUNT(*) FROM Registrados";
                int count = 0;

                 
                    using (SqlCommand cmdCount = new SqlCommand(stmt, conn))
                    {
                        conn.Open();
                        count = (int)cmdCount.ExecuteScalar();
                    }
                
                return count;
            }
        }

        public string LabelName(int i)
        {
            string stmt = "select * FROM Registrados WHERE Folio= " + i;
            string count = "1";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Nombre"].ToString() + " " + registro["Apellido1"].ToString() + " " + registro["Apellido2"].ToString();
            }

            conn.Close();
            return count;
        
        }

        public string LabelFolio(int i)
        {
            string stmt = "select * FROM Registrados WHERE Folio= " + i;
            string count = "1";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Folio"].ToString();
            }

            conn.Close();
            return count;



        }
    }
}

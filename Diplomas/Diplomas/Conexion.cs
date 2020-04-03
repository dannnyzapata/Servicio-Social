﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;

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

        public int nAlumnos(string Curso)
        {
            {
                string stmt = "SELECT TOP 1 Folio FROM " + Curso;
                int count = 0;

                 
                    using (SqlCommand cmdCount = new SqlCommand(stmt, conn))
                    {
                        conn.Open();
                        count = (int)cmdCount.ExecuteScalar();
                        conn.Close();
                    }
                
                return count;
            }
        }

        public int nUltimo(string Curso)
        {
            {
                string stmt = "SELECT MAX(Folio) FROM " + Curso;
                int count = 0;


                using (SqlCommand cmdCount = new SqlCommand(stmt, conn))
                {
                    conn.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    conn.Close();
                }

                return count;
            }
        }


        public string AlumnoNombre(int i, string Curso)
        {
            string stmt = "select * FROM "+ Curso +" WHERE Folio= " + i;
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


        public string AlumnoFolio(int i, string Curso)
        {
            string stmt = "select * FROM "+ Curso +" WHERE Folio= " + i;
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

        public string ObtenerFechaInicio(int i, string Curso)
        {
            string getFecha = "SELECT * FROM " + Curso + " WHERE Folio = " + i;
            string FechaInicio = " ";
            string resultado = " ";
            SqlCommand comando = new SqlCommand(getFecha, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                FechaInicio = registro["Fecha"].ToString();
            }
            DateTimePicker FechaAString = new DateTimePicker();
            FechaAString.Value = Convert.ToDateTime(FechaInicio);
            resultado = FechaAString.Value.Day.ToString() + " de " + FechaAString.Value.ToString("MMMM") + " del " + FechaAString.Value.Year.ToString();

            conn.Close();
            return resultado;

        }



        public string ObtenerCorreo(int i, string Curso)
        {
            string correo = "SELECT * FROM "+ Curso + " WHERE Folio = " + i;
            string enviar = " ";
            SqlCommand comando = new SqlCommand(correo, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                enviar = registro["Correo"].ToString();
            }

            conn.Close();
            return enviar;
            
        }

        public string ObtenerUsuario()
        {
            string correo = "SELECT Usuario FROM Correo";
            string enviar = " ";
            SqlCommand comando = new SqlCommand(correo, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                enviar = registro["Usuario"].ToString();
            }

            conn.Close();
            return enviar;

        }


        public string ObtenerContraseña()
        {
            string correo = "SELECT Contraseña FROM Correo";
            string enviar = " ";
            SqlCommand comando = new SqlCommand(correo, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                enviar = registro["Contraseña"].ToString();
            }

            conn.Close();
            return enviar;
        }
        public string VoF(int i,string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio = " + i;
            string count = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Graduado"].ToString();
            }

            conn.Close();
            return count;



        }


        public string NombreBus(int i, string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio= " + i;
            string count = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Nombre"].ToString();
            }

            conn.Close();
            return count;

        }


        public string Apellido1Bus(int i, string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio= " + i;
            string count = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Apellido1"].ToString();
            }

            conn.Close();
            return count;

        }


        public string Apellido2Bus(int i, string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio= " + i;
            string count = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Apellido2"].ToString();
            }

            conn.Close();
            return count;

        }

        public string Imagen(int i, string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio= " + i;
            byte[] img;
            string imagen = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                img = (byte[])registro["Foto"];
                MemoryStream ms = new MemoryStream(img);
                StreamReader reader = new StreamReader(ms);
                imagen = reader.ReadToEnd();
            }
            conn.Close();
            return imagen;

        }

        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCursos.SelectedIndex = 0;

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (txtApellido1.Text.Length>0 && txtApellido2.Text.Length > 0  && txtNombre.Text.Length > 0 && txtCorreo.Text.Length >0 )
            {
                if (txtCorreo.Text.Contains("@"))
                {                            
                    con.InsertarDatos(cbCursos.SelectedItem.ToString(),pcbFoto, txtCorreo.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, dtpFecha.Value.ToString("dd/MM/yyyy"));            
                    txtApellido1.Clear();
                    txtApellido2.Clear();
                    txtCorreo.Clear();
                    txtNombre.Clear();
                    pcbFoto.Image = null;
                    MessageBox.Show("Alumno en base de Datos");                                
                }
                else
                {
                    MessageBox.Show("Introdusca un correo valido por favor");
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor");
            }



        }

        private void btDiplomas_Click(object sender, EventArgs e)
        {

            Conexion con = new Conexion();                     
            con.desconectar();
            string check = cbCursos.SelectedItem.ToString();
            SetValueParaChecador = check;

            Checador vChecar = new Checador(cbCursos.SelectedItem.ToString());
   

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

﻿using System;
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

        private void btDiplomas_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            int pfolio, ultimo;
            

            pfolio = con.nAlumnos();
            ultimo = con.nUltimo();
          

            con.desconectar();
            Checador vChecar = new Checador(pfolio, ultimo);
   

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


    }
}

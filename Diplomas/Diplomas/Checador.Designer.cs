namespace Diplomas
{
    partial class Checador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cblAlumnos = new System.Windows.Forms.CheckedListBox();
            this.dtpGraduar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btDiplomas = new System.Windows.Forms.Button();
            this.alumnosDBDataSet1 = new Diplomas.AlumnosDBDataSet();
            this.Lista = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExpedicion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cblAlumnos
            // 
            this.cblAlumnos.FormattingEnabled = true;
            this.cblAlumnos.Location = new System.Drawing.Point(5, 6);
            this.cblAlumnos.Name = "cblAlumnos";
            this.cblAlumnos.Size = new System.Drawing.Size(353, 259);
            this.cblAlumnos.TabIndex = 0;
            // 
            // dtpGraduar
            // 
            this.dtpGraduar.Location = new System.Drawing.Point(97, 306);
            this.dtpGraduar.Name = "dtpGraduar";
            this.dtpGraduar.Size = new System.Drawing.Size(200, 20);
            this.dtpGraduar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Graduación: ";
            // 
            // btDiplomas
            // 
            this.btDiplomas.Location = new System.Drawing.Point(209, 393);
            this.btDiplomas.Name = "btDiplomas";
            this.btDiplomas.Size = new System.Drawing.Size(113, 23);
            this.btDiplomas.TabIndex = 3;
            this.btDiplomas.Text = "Crear Diplomas";
            this.btDiplomas.UseVisualStyleBackColor = true;
            this.btDiplomas.Click += new System.EventHandler(this.btDiplomas_Click);
            // 
            // alumnosDBDataSet1
            // 
            this.alumnosDBDataSet1.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Lista
            // 
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(90, 9);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(228, 247);
            this.Lista.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lista);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.cblAlumnos);
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 275);
            this.panel1.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(371, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 275);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll_1);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(83, 393);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(113, 23);
            this.btCerrar.TabIndex = 7;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Expedición: ";
            // 
            // dtpExpedicion
            // 
            this.dtpExpedicion.Location = new System.Drawing.Point(97, 355);
            this.dtpExpedicion.Name = "dtpExpedicion";
            this.dtpExpedicion.Size = new System.Drawing.Size(200, 20);
            this.dtpExpedicion.TabIndex = 8;
            // 
            // Checador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpExpedicion);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btDiplomas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpGraduar);
            this.Name = "Checador";
            this.Text = "Checador";
            this.Load += new System.EventHandler(this.Checador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cblAlumnos;
        private System.Windows.Forms.DateTimePicker dtpGraduar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDiplomas;
        private AlumnosDBDataSet alumnosDBDataSet1;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExpedicion;
    }
}
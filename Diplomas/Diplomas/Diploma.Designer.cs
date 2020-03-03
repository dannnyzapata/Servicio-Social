namespace Diplomas
{
    partial class Diplomad
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFolio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(230, 337);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(172, 58);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Prueba";
            // 
            // lbFolio
            // 
            this.lbFolio.AutoSize = true;
            this.lbFolio.Location = new System.Drawing.Point(68, 697);
            this.lbFolio.Name = "lbFolio";
            this.lbFolio.Size = new System.Drawing.Size(29, 13);
            this.lbFolio.TabIndex = 2;
            this.lbFolio.Text = "Folio";
            // 
            // Diplomad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplomas.Properties.Resources.Titulo;
            this.ClientSize = new System.Drawing.Size(941, 729);
            this.Controls.Add(this.lbFolio);
            this.Controls.Add(this.lbNombre);
            this.Name = "Diplomad";
            this.Text = "Diploma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFolio;
        private System.Windows.Forms.Label lbNombre;
    }
}
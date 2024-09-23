namespace Corte1
{
    partial class RegistroEdadesARVAO
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.btnMostrarEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(52, 66);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(119, 29);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(392, 69);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(120, 29);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(52, 159);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(243, 29);
            this.lblFechaNac.TabIndex = 2;
            this.lblFechaNac.Text = "Fecha de nacimiento:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(52, 240);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(96, 29);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(195, 63);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(152, 35);
            this.tbNombres.TabIndex = 4;
            this.tbNombres.TextChanged += new System.EventHandler(this.tbNombres_TextChanged);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(518, 69);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(152, 35);
            this.tbApellidos.TabIndex = 5;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(301, 159);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(352, 35);
            this.dtpFechaNac.TabIndex = 6;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Items.AddRange(new object[] {
            "Managua",
            "",
            "Granada",
            "",
            "León",
            "",
            "San Juan del Sur",
            "",
            "Masaya"});
            this.cmbCiudad.Location = new System.Drawing.Point(168, 240);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(169, 37);
            this.cmbCiudad.TabIndex = 7;
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.Location = new System.Drawing.Point(95, 318);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(200, 70);
            this.btnAgregarDatos.TabIndex = 8;
            this.btnAgregarDatos.Text = "Agregar Datos";
            this.btnAgregarDatos.UseVisualStyleBackColor = true;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // btnMostrarEdad
            // 
            this.btnMostrarEdad.Location = new System.Drawing.Point(346, 318);
            this.btnMostrarEdad.Name = "btnMostrarEdad";
            this.btnMostrarEdad.Size = new System.Drawing.Size(236, 70);
            this.btnMostrarEdad.TabIndex = 9;
            this.btnMostrarEdad.Text = "Ver";
            this.btnMostrarEdad.UseVisualStyleBackColor = true;
            this.btnMostrarEdad.Click += new System.EventHandler(this.btnMostrarEdad_Click);
            // 
            // RegistroEdadesARVAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 418);
            this.Controls.Add(this.btnMostrarEdad);
            this.Controls.Add(this.btnAgregarDatos);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistroEdadesARVAO";
            this.Text = "Registro Edades - ARVAO";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.Button btnMostrarEdad;
    }
}

namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.btnConsultaCiclo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAlumnoEmpresa = new System.Windows.Forms.Button();
            this.btnEliminarAlumnoEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaCiclo
            // 
            this.btnConsultaCiclo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCiclo.Location = new System.Drawing.Point(55, 196);
            this.btnConsultaCiclo.Name = "btnConsultaCiclo";
            this.btnConsultaCiclo.Size = new System.Drawing.Size(176, 57);
            this.btnConsultaCiclo.TabIndex = 0;
            this.btnConsultaCiclo.Text = "&Consultas Por Ciclo";
            this.btnConsultaCiclo.UseVisualStyleBackColor = true;
            this.btnConsultaCiclo.Click += new System.EventHandler(this.btnConsultaCiclo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "FCTS EMPRESA";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(811, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 44);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAlumnoEmpresa
            // 
            this.btnAlumnoEmpresa.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnoEmpresa.Location = new System.Drawing.Point(356, 196);
            this.btnAlumnoEmpresa.Name = "btnAlumnoEmpresa";
            this.btnAlumnoEmpresa.Size = new System.Drawing.Size(176, 57);
            this.btnAlumnoEmpresa.TabIndex = 3;
            this.btnAlumnoEmpresa.Text = "&Añadir Alumno a Empresa";
            this.btnAlumnoEmpresa.UseVisualStyleBackColor = true;
            this.btnAlumnoEmpresa.Click += new System.EventHandler(this.btnAlumnoEmpresa_Click);
            // 
            // btnEliminarAlumnoEmpresa
            // 
            this.btnEliminarAlumnoEmpresa.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumnoEmpresa.Location = new System.Drawing.Point(670, 196);
            this.btnEliminarAlumnoEmpresa.Name = "btnEliminarAlumnoEmpresa";
            this.btnEliminarAlumnoEmpresa.Size = new System.Drawing.Size(176, 57);
            this.btnEliminarAlumnoEmpresa.TabIndex = 4;
            this.btnEliminarAlumnoEmpresa.Text = "&Eliminar Alumno de Empresa";
            this.btnEliminarAlumnoEmpresa.UseVisualStyleBackColor = true;
            this.btnEliminarAlumnoEmpresa.Click += new System.EventHandler(this.btnEliminarAlumnoEmpresa_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 439);
            this.Controls.Add(this.btnEliminarAlumnoEmpresa);
            this.Controls.Add(this.btnAlumnoEmpresa);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultaCiclo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaCiclo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAlumnoEmpresa;
        private System.Windows.Forms.Button btnEliminarAlumnoEmpresa;
    }
}


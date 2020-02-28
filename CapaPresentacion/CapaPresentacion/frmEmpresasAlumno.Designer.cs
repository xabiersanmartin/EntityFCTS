namespace CapaPresentacion
{
    partial class frmEmpresasAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlumnosCiclo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDevolverEmpresaCiclo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTutorInstituto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtTutorEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciclo";
            // 
            // cboCiclo
            // 
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Location = new System.Drawing.Point(211, 160);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(121, 21);
            this.cboCiclo.TabIndex = 1;
            this.cboCiclo.SelectedIndexChanged += new System.EventHandler(this.cboCiclo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alumnos/as del ciclo";
            // 
            // cboAlumnosCiclo
            // 
            this.cboAlumnosCiclo.FormattingEnabled = true;
            this.cboAlumnosCiclo.Location = new System.Drawing.Point(594, 157);
            this.cboAlumnosCiclo.Name = "cboAlumnosCiclo";
            this.cboAlumnosCiclo.Size = new System.Drawing.Size(121, 21);
            this.cboAlumnosCiclo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresas para el ciclo (oredenadas alfabeticamente)";
            // 
            // cboDevolverEmpresaCiclo
            // 
            this.cboDevolverEmpresaCiclo.FormattingEnabled = true;
            this.cboDevolverEmpresaCiclo.Location = new System.Drawing.Point(461, 243);
            this.cboDevolverEmpresaCiclo.Name = "cboDevolverEmpresaCiclo";
            this.cboDevolverEmpresaCiclo.Size = new System.Drawing.Size(254, 21);
            this.cboDevolverEmpresaCiclo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tutor/a del instituto";
            // 
            // cboTutorInstituto
            // 
            this.cboTutorInstituto.FormattingEnabled = true;
            this.cboTutorInstituto.Location = new System.Drawing.Point(278, 320);
            this.cboTutorInstituto.Name = "cboTutorInstituto";
            this.cboTutorInstituto.Size = new System.Drawing.Size(134, 21);
            this.cboTutorInstituto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tutor/a de empresa";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(230, 443);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(143, 59);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "&Asignar empresa";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(460, 443);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(143, 59);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtTutorEmpresa
            // 
            this.txtTutorEmpresa.Location = new System.Drawing.Point(562, 320);
            this.txtTutorEmpresa.Name = "txtTutorEmpresa";
            this.txtTutorEmpresa.Size = new System.Drawing.Size(153, 20);
            this.txtTutorEmpresa.TabIndex = 12;
            this.txtTutorEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutorEmpresa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "AÑADIR ALUMNO A EMPRESA";
            // 
            // frmEmpresasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTutorEmpresa);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTutorInstituto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDevolverEmpresaCiclo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAlumnosCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCiclo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmpresasAlumno";
            this.Text = "Añadir Alumnos a Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpresasAlumno_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpresasAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCiclo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAlumnosCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDevolverEmpresaCiclo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTutorInstituto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtTutorEmpresa;
        private System.Windows.Forms.Label label6;
    }
}
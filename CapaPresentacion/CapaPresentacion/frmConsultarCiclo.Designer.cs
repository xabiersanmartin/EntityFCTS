namespace CapaPresentacion
{
    partial class frmConsultarCiclo
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
            this.lblCiclos = new System.Windows.Forms.Label();
            this.cboCiclos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCIclo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlumnosCiclo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlumnosAsignados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCiclos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEmpresasParaCiclo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAlumosConEmpresa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasParaCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumosConEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCiclos
            // 
            this.lblCiclos.AutoSize = true;
            this.lblCiclos.Location = new System.Drawing.Point(37, 52);
            this.lblCiclos.Name = "lblCiclos";
            this.lblCiclos.Size = new System.Drawing.Size(35, 13);
            this.lblCiclos.TabIndex = 0;
            this.lblCiclos.Text = "Ciclos";
            // 
            // cboCiclos
            // 
            this.cboCiclos.FormattingEnabled = true;
            this.cboCiclos.Location = new System.Drawing.Point(103, 52);
            this.cboCiclos.Name = "cboCiclos";
            this.cboCiclos.Size = new System.Drawing.Size(121, 21);
            this.cboCiclos.TabIndex = 1;
            this.cboCiclos.SelectedIndexChanged += new System.EventHandler(this.cboCiclos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Ciclo: ";
            // 
            // lblNombreCIclo
            // 
            this.lblNombreCIclo.AutoSize = true;
            this.lblNombreCIclo.Location = new System.Drawing.Point(368, 52);
            this.lblNombreCIclo.Name = "lblNombreCIclo";
            this.lblNombreCIclo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreCIclo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alumnos/as del ciclo: ";
            // 
            // lblAlumnosCiclo
            // 
            this.lblAlumnosCiclo.AutoSize = true;
            this.lblAlumnosCiclo.Location = new System.Drawing.Point(663, 52);
            this.lblAlumnosCiclo.Name = "lblAlumnosCiclo";
            this.lblAlumnosCiclo.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnosCiclo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alumnos/as asignados";
            // 
            // lblAlumnosAsignados
            // 
            this.lblAlumnosAsignados.AutoSize = true;
            this.lblAlumnosAsignados.Location = new System.Drawing.Point(900, 52);
            this.lblAlumnosAsignados.Name = "lblAlumnosAsignados";
            this.lblAlumnosAsignados.Size = new System.Drawing.Size(0, 13);
            this.lblAlumnosAsignados.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alumnos/as del ciclo";
            // 
            // dgvCiclos
            // 
            this.dgvCiclos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclos.Location = new System.Drawing.Point(40, 158);
            this.dgvCiclos.Name = "dgvCiclos";
            this.dgvCiclos.Size = new System.Drawing.Size(373, 285);
            this.dgvCiclos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Empresas para el ciclo (ordenadas alfabeticamente)";
            // 
            // dgvEmpresasParaCiclo
            // 
            this.dgvEmpresasParaCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresasParaCiclo.Location = new System.Drawing.Point(527, 158);
            this.dgvEmpresasParaCiclo.Name = "dgvEmpresasParaCiclo";
            this.dgvEmpresasParaCiclo.Size = new System.Drawing.Size(422, 285);
            this.dgvEmpresasParaCiclo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alumnos/as del ciclo con empresa ya asignada";
            // 
            // dgvAlumosConEmpresa
            // 
            this.dgvAlumosConEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumosConEmpresa.Location = new System.Drawing.Point(40, 517);
            this.dgvAlumosConEmpresa.Name = "dgvAlumosConEmpresa";
            this.dgvAlumosConEmpresa.Size = new System.Drawing.Size(373, 187);
            this.dgvAlumosConEmpresa.TabIndex = 13;
            // 
            // frmConsultarCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 764);
            this.Controls.Add(this.dgvAlumosConEmpresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvEmpresasParaCiclo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCiclos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlumnosAsignados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlumnosCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreCIclo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCiclos);
            this.Controls.Add(this.lblCiclos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultarCiclo";
            this.Text = "Consultar Ciclo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultarCiclo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasParaCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumosConEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCiclos;
        private System.Windows.Forms.ComboBox cboCiclos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCIclo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlumnosCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlumnosAsignados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCiclos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEmpresasParaCiclo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAlumosConEmpresa;
    }
}
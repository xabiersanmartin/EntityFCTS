using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmEliminarAlumnoDeEmpresa : Form
    {

        public string mensaje = "";

        public frmEliminarAlumnoDeEmpresa()
        {
            InitializeComponent();
        }

        private void frmEliminarAlumnoDeEmpresa_Load(object sender, EventArgs e)
        {
            List<Ciclo> ListaCiclos = Program.gestor.DevolverCiclos();

            cboCiclos.Items.Clear();
            cboCiclos.Items.AddRange(ListaCiclos.ToArray());
            cboCiclos.DisplayMember = "id";
        }

        private void cboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ciclo newCiclo = new Ciclo();
            newCiclo = cboCiclos.SelectedItem as Ciclo;

            //Cargar el combobox de Alumnos cuando se haya seleccionado el ciclo
            List<Alumno> alumnosCiclo = Program.gestor.DevolverAlumnosPorCiclo(newCiclo.Id, out mensaje);
            cboAlumnosCiclo.Items.Clear();
            cboAlumnosCiclo.Items.AddRange(alumnosCiclo.ToArray());
            cboAlumnosCiclo.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
            }

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres eliminar un alumno que esta asignado a una empresa?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               
            }
        }
    }
}

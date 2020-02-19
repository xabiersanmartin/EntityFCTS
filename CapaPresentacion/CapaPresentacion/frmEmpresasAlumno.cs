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
    public partial class frmEmpresasAlumno : Form
    {

        public string mensaje = "";

        public frmEmpresasAlumno()
        {
            InitializeComponent();
        }

        private void frmEmpresasAlumno_Load(object sender, EventArgs e)
        {
            List<Ciclo> ListaCiclos = Program.gestor.DevolverCiclos();

            cboCiclo.Items.Clear();
            cboCiclo.Items.AddRange(ListaCiclos.ToArray());
            cboCiclo.DisplayMember = "id";
        }

        private void cboCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Creamos un nuevo ciclo, para añadir los valores del combobox a el y podemos enviar los datos a la Capa de Datos.
            Ciclo newCiclo = new Ciclo();
            newCiclo = cboCiclo.SelectedItem as Ciclo;

            //Cargar el combobox de Alumnos cuando se haya seleccionado el ciclo
            List<Alumno> alumnosCiclo = Program.gestor.DevolverAlumnosPorCiclo(newCiclo.Id, out mensaje);
            cboAlumnosCiclo.Items.Clear();
            cboAlumnosCiclo.Items.AddRange(alumnosCiclo.ToArray());
            cboAlumnosCiclo.DisplayMember = "Nombre";

            //Cargar el combobox de empresas cuando se seleccione el ciclo
            List<Empresa> empresasCiclo = Program.gestor.DevolverEmpresasPorCiclo(newCiclo.Id, out mensaje);
            cboDevolverEmpresaCiclo.Items.Clear();
            cboDevolverEmpresaCiclo.Items.AddRange(empresasCiclo.ToArray());
            cboDevolverEmpresaCiclo.DisplayMember = "Nombre";

            List<Profe> listaProfesores = Program.gestor.DevolverProfes();
            cboTutorInstituto.Items.Clear();
            cboTutorInstituto.Items.AddRange(listaProfesores.ToArray());
            cboTutorInstituto.DisplayMember = "Nombre";


        }

        private void txtTutorEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            else
                if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }

            else
                if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.gestor.AnadirAlumnoEmpresa((Empresa)cboDevolverEmpresaCiclo.SelectedItem,(Alumno)cboAlumnosCiclo.SelectedItem ,(Profe)cboTutorInstituto.SelectedItem , txtTutorEmpresa.Text));
        }
    }
}

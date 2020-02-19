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
    public partial class frmConsultarCiclo : Form
    {
        public string mensaje = "";

        public frmConsultarCiclo()
        {
            InitializeComponent();
        }

        private void frmConsultarCiclo_Load(object sender, EventArgs e)
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

            //Quiero poner el nombre del ciclo cogiendolo a traves del combobox, ni puta idea de que hace esto.
            lblNombreCIclo.Text = newCiclo.Nombre;
            lblAlumnosCiclo.Text = newCiclo.Alumnos.Count().ToString();
            lblAlumnosAsignados.Text = Program.gestor.DevolverAlumnosAsignadosPorCiclo(newCiclo.Id, out mensaje).ToString();
            List<Alumno> cicloAlumno = Program.gestor.DevolverAlumnosPorCiclo(newCiclo.Id, out mensaje);

            dgvCiclos.DataSource = (from alum in cicloAlumno
                                    select new { alum.Nombre, alum.Telefono, alum.Aprobado }).ToList();


            List<Empresa> cicloEmpresa = Program.gestor.DevolverEmpresasPorCiclo(newCiclo.Id, out mensaje);

            dgvEmpresasParaCiclo.DataSource = (from empresa in cicloEmpresa
                                               select new { empresa.Nombre, empresa.TelefonoContacto, empresa.OfertasFCTs.Count }).ToList();

            List<Alumno> alumnosAsignados = Program.gestor.DevolverListaAlumnosAsignadosPorCiclo(newCiclo.Id, out mensaje);
            dgvAlumosConEmpresa.DataSource = (from alumno in alumnosAsignados
                                              select new { alumno.Nombre, alumno.NombreEmpresa }).ToList();
        }

    }
}

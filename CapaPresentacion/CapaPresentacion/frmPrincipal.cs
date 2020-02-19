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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaCiclo_Click(object sender, EventArgs e)
        {
            frmConsultarCiclo frm = new frmConsultarCiclo();
            frm.Show();
        }

        private void btnAlumnoEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresasAlumno frmEmp = new frmEmpresasAlumno();
            frmEmp.Show();
        }

        private void btnEliminarAlumnoEmpresa_Click(object sender, EventArgs e)
        {
            frmEliminarAlumnoDeEmpresa frmEliminar = new frmEliminarAlumnoDeEmpresa();
            frmEliminar.Show();
        }
    }
}

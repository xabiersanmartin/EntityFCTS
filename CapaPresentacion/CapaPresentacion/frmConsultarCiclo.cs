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

        public frmConsultarCiclo()
        {
            InitializeComponent();
        }

        private void frmConsultarCiclo_Load(object sender, EventArgs e)
        {

            List<Ciclo> ListaCiclos = Program.gestor.DevolverCiclos();

            cboCiclos.Items.Clear();
            cboCiclos.Items.AddRange(ListaCiclos.ToArray());
            cboCiclos.DisplayMember = "Nombre";
        }
    }
}

using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Acceso
    {
        //Declaramos el acceso a la capa de Datos
        Gestor nuevoAcceso = new Gestor(out string mensaje);

        //Llamamos al metodo de DevolverCiclos.
        public List<Ciclo> DevolverCiclos()
        {
            return nuevoAcceso.DevolverCiclos();
        }

        public List<Alumno> DevolverAlumnosPorCiclo(string idCicLo, out string mensaje)
        {
            return nuevoAcceso.AlumnosPorCiclo(idCicLo, out mensaje);
        }

        public List<Empresa> DevolverEmpresasPorCiclo(string idCiclo, out string mensaje)
        {
            return nuevoAcceso.EmpresasPorCiclo(idCiclo, out mensaje);
        }
    }
}

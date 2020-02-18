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

        public List<Profe> DevolverProfes()
        {
            return nuevoAcceso.DevolverProfes();
        }

        public int DevolverAlumnosAsignadosPorCiclo(string idCiclo, out string mensaje)
        {
            return nuevoAcceso.AlumnosAsignadosPorCiclo(idCiclo, out mensaje);
        }

        public List<Alumno> DevolverAlumnosPorCiclo(string idCiclo, out string mensaje)
        {
            return nuevoAcceso.AlumnosPorCiclo(idCiclo, out mensaje);
        }

        public List<Empresa> DevolverEmpresasPorCiclo(string idCiclo, out string mensaje)
        {
            return nuevoAcceso.EmpresasPorCiclo(idCiclo, out mensaje);
        }
    }
}

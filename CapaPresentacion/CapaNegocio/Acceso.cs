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
        public List<Alumno> DevolverListaAlumnosAsignadosPorCiclo(string idCiclo, out string mensaje)
        {
            return nuevoAcceso.ListaAlumnosAsignadosPorCiclo(idCiclo, out mensaje);
        }
        public List<Alumno> DevolverAlumnosPorCiclo(string idCiclo, out string mensaje)
        {
            return nuevoAcceso.AlumnosPorCiclo(idCiclo, out mensaje);
        }

        public List<Empresa> DevolverEmpresasPorCiclo(string idCiclo, out string mensaje)
        {
            return nuevoAcceso.EmpresasPorCiclo(idCiclo, out mensaje);
        }

        public string AnadirAlumnoEmpresa(Ciclo anadirCiclo, Empresa anadirEmpresa, Alumno anadirAlumno, Profe anadirProfe, string tutorEmpresa)
        {
            return nuevoAcceso.AñadirAlumnoEmpresa(anadirCiclo,anadirEmpresa, anadirAlumno, anadirProfe, tutorEmpresa);
        }

        public string SeleccionarEmpresaAlumno (Alumno seleccionarAlumno)
        {
            return nuevoAcceso.SeleccionarEmpresaAlumno(seleccionarAlumno);
        }

        public string EliminarEmpresaAlumno (int nMatricula)
        {
            return nuevoAcceso.EliminarEmpresaAlumno(nMatricula);
        }
        public Empresa DevolverEmpresa(int nMatricula)
        {
            return nuevoAcceso.DevolverEmpresa(nMatricula);
        }
    }
}

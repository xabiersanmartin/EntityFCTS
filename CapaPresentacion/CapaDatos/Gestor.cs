using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {

        BdFCTsEntities BdFCTsEntities;

        public Gestor(out string mensaje)
        {
            mensaje = "";
            try
            {
                BdFCTsEntities = new BdFCTsEntities();
            }
            catch (Exception)
            {
                mensaje = "No se a podido conectar con la base de datos, contacte con el administrador";
            }
        }

        public List<Ciclo> DevolverCiclos()
        {
            return BdFCTsEntities.Ciclos.ToList();
        }

        public List<Profe> DevolverProfes()
        {
            return BdFCTsEntities.Profes.ToList();
        }

        public List<Alumno> AlumnosPorCiclo(string idCiclo, out string mensaje)
        {
            mensaje = "";
            Ciclo cicloBuscar = new Ciclo(idCiclo);

            Ciclo ciclo = BdFCTsEntities.Ciclos.ToList().Where(com => com.Equals(cicloBuscar)).SingleOrDefault();

            if (ciclo == null)
            {
                mensaje = "No existe el ciclo ";
                return new List<Alumno>();
            }

            List<Alumno> alumnosDelCiclo = ciclo.Alumnos.ToList();
            return alumnosDelCiclo;
        }
        public int AlumnosAsignadosPorCiclo(string idCiclo, out string mensaje)
        {
            mensaje = "";
            Ciclo cicloBuscar = new Ciclo(idCiclo);
            Ciclo ciclo = BdFCTsEntities.Ciclos.ToList().Where(com => com.Equals(cicloBuscar)).SingleOrDefault();
            if (ciclo == null)
            {
                mensaje = "No existe el ciclo ";
                return 0;

            }
            int numAsignados = BdFCTsEntities.FCTs.ToList().Where(alumn => cicloBuscar.Alumnos.Contains(alumn.Alumno)).Count();
            if (numAsignados != 0)
            {
                mensaje = "Este ciclo no tiene alumnos asignados";
                return 0;

            }
            return numAsignados;
        }
        public List<Alumno> ListaAlumnosAsignadosPorCiclo(string idCiclo, out string mensaje)
        {
            mensaje = "";
            Ciclo cicloBuscar = new Ciclo(idCiclo);
            Ciclo ciclo = BdFCTsEntities.Ciclos.ToList().Where(com => com.Equals(cicloBuscar)).SingleOrDefault();
            if (ciclo == null)
            {
                mensaje = "No existe el ciclo ";
                return null;

            }
            
            List<FCT> listaFcts = BdFCTsEntities.FCTs.ToList();
            List<Alumno> listaAlum = ciclo.Alumnos.ToList();
            List<Alumno> listaAlumnoAsignadoEmpresa = (from alum in listaAlum
                                                       where listaFcts.Contains(alum.FCT)
                                                       select new Alumno(alum.Nombre, alum.Empresa)).ToList();
           
            if (listaAlumnoAsignadoEmpresa == null)
            {
                mensaje = "Este ciclo no tiene alumnos asignados";
                return null;

            }
            return listaAlumnoAsignadoEmpresa;
        }

        public List<Empresa> EmpresasPorCiclo(string idCiclo, out string mensaje)
        {
            mensaje = "";
            Ciclo cicloBuscar = new Ciclo(idCiclo);

            Ciclo ciclo = BdFCTsEntities.Ciclos.ToList().Where(com => com.Equals(cicloBuscar)).SingleOrDefault();

            if (ciclo == null)
            {
                mensaje = "No existe el ciclo ";
                return new List<Empresa>();

            }

            List<OfertasFCT> ofertasCiclo = ciclo.OfertasFCTs.ToList();

            List<Empresa> empresaPorciclo = (from emp in ofertasCiclo
                                             where emp.IdCiclo == ciclo.Id
                                             select emp.Empresa).OrderBy(o => o).ToList();

            if (empresaPorciclo == null)
            {
                mensaje = "No hay empresas candidatas con ese Ciclo";
                return null;
            }

            return empresaPorciclo;
        }


        public string AñadirAlumnoEmpresa(Empresa anadirEmpresa, Alumno anadirAlumno, Profe anadirProfe, string tutorEmpresa)
        {
            if (anadirEmpresa == null)
            {
                return "Debes seleccionar una empresa.";
            }

            if (anadirAlumno == null)
            {
                return "Debes seleccionar un alumno";
            }

            if (anadirProfe == null)
            {
                return "Debes escoger un profesor valido";
            }

            if (String.IsNullOrWhiteSpace(tutorEmpresa))
            {
                return "El nombre del tutor de la empresa no puede estar vacio";
            }

            //Creamos una nueva FCT donde vamos a añadirlo
            FCT anadirFct = new FCT(anadirAlumno.NMatricula, anadirEmpresa.Id, anadirProfe.Nombre, tutorEmpresa, anadirAlumno, anadirEmpresa, anadirProfe);

            if (BdFCTsEntities.FCTs.Contains(anadirFct))
            {
                return "Esta Fct ya existe.";
            }

            try
            {
                BdFCTsEntities.FCTs.Add(anadirFct);

                //Control de error por si no se a podido añadir
                int cambios = BdFCTsEntities.SaveChanges();
                if (cambios == 0) return "Error al añadir";
                return "";
            }

            catch (Exception ex)
            {
               return ex.Message;
            }
            

            
            

        }
    }
}

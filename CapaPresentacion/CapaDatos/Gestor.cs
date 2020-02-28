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

            List<Alumno> alumnosDelCiclo = ciclo.Alumnos.OrderBy(o => o.Aprobado==false).ToList();
            
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
            List<FCT> listaFcts = BdFCTsEntities.FCTs.ToList();
            List<Alumno> listaAlum = ciclo.Alumnos.ToList();
            int numAsignados = listaAlum.FindAll(alum => listaFcts.Contains(alum.FCT)).Count();
            if (numAsignados == 0)
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
                                                       select new Alumno(alum.Nombre, alum.FCT.Empresa.Nombre)).ToList();
           
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

            //Necesitamos ordenarlo alfabeticamente
            List<Empresa> empresaPorciclo = (from emp in ofertasCiclo
                                             where emp.IdCiclo == ciclo.Id
                                             select emp.Empresa).OrderBy(o => o.Nombre).ToList();

            if (empresaPorciclo == null)
            {
                mensaje = "No hay empresas candidatas con ese Ciclo";
                return null;
            }

            return empresaPorciclo;
        }


        public string AñadirAlumnoEmpresa(Ciclo anadirCiclo, Empresa anadirEmpresa, Alumno anadirAlumno, Profe anadirProfe, string tutorEmpresa)
        {
            if (anadirCiclo == null)
            {
                return "Debes seleccionar un ciclo";
            }

            if (anadirAlumno == null)
            {
                return "Debes seleccionar un alumno";
            }

            if (anadirEmpresa == null)
            {
                return "Debes seleccionar una empresa.";
            }

            if (anadirProfe == null)
            {
                return "Debes escoger un profesor valido";
            }

            if (String.IsNullOrWhiteSpace(tutorEmpresa))
            {
                return "El nombre del tutor de la empresa no puede estar vacio";
            }

            if (anadirAlumno.Aprobado == false)
            {
                return "El alumno no ha aprobado no puede hacer FCT";
            }

            if (anadirAlumno.FCT != null)
            {
                return "El alumno ya tiene asignada una empresa";
            }

            //ESTA MAL PORQUE HAY QUE REVISAR QUE LA EMPRESA NO PIDA PARA CICLO NO EN GENERAL!
            if (anadirEmpresa.OfertasFCTs == null)
            {
                return "La empresa no ha solicitado alumnos para FCT";
            }

            //ESTO MIRA SI EL ALUMNO PERTENCE AL CICLO?
            Ciclo mirarCiclo = BdFCTsEntities.Ciclos.Find(anadirAlumno.NMatricula);

            if (mirarCiclo == null)
            {
                return "Este alumno no esta en este ciclo";
            }

            //CONTROL ERROR EMPRESA YA TIENEN LA CANTIDAD DE ALUMNOS PEDIDA.
            if (true)
            {

            }

            //Creamos una nueva FCT donde vamos a añadirlo
            FCT anadirFct = new FCT(anadirAlumno.NMatricula, anadirEmpresa.Id, anadirProfe.Nombre, tutorEmpresa, anadirAlumno, anadirEmpresa, anadirProfe);

            if (BdFCTsEntities.FCTs.ToList().Contains(anadirFct))
            {
                return "Esta Fct ya existe.";
            }

            try
            {
                BdFCTsEntities.FCTs.Add(anadirFct);
                anadirAlumno.NombreEmpresa = anadirEmpresa.Nombre;

                //Control de error por si no se a podido añadir
                int cambios = BdFCTsEntities.SaveChanges();
                if (cambios == 0) return "Error al añadir";
                return "Añadido correctamente";
            }

            catch (Exception ex)
            {
               return ex.Message;
            }
            
        }

        public string SeleccionarEmpresaAlumno(Alumno selecAlumno)
        {
            if (selecAlumno == null)
            {
                return "Debes seleccionar un alumno para eliminarlo";
            }

            if (selecAlumno.Aprobado == false)
            {
                return "No puedes retirar a un alumno de una empresa que no ha aprobado.";
            }

            if (selecAlumno.FCT == null)
            {
                return "El alumno no tiene empresa asignada";
            }

            return "";
        }


        public string EliminarEmpresaAlumno(Alumno eliminarAlumno)
        {

            try
            {
                FCT eliminarFct = new FCT(eliminarAlumno);

                //SI HACEMOS ESTO PODEMOS HACER ALGO EN CASCADA PARA QUE BORRE TODA LA FCT? SINO SE BORRARA SOLO EL ALUMNO // ENCIMA PETA
                BdFCTsEntities.FCTs.Remove(eliminarFct);

                //Control de error por si no se a podido añadir
                int cambios = BdFCTsEntities.SaveChanges();
                if (cambios == 0) return "Error al eliminar";
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Eliminado Correctamente";
        }

        
    }
}

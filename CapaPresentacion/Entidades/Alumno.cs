//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno : IEquatable<Alumno>
    {
        public Alumno()
        {
        }

        public Alumno(int nMatricula, string nombre, string telefono, bool aprobado, string idCiclo, Ciclo ciclo, FCT fCT)
        {
            NMatricula = nMatricula;
            Nombre = nombre;
            Telefono = telefono;
            Aprobado = aprobado;
            IdCiclo = idCiclo;
            Ciclo = ciclo;
            FCT = fCT;
        }

        public Alumno(int nMatricula)
        {
            NMatricula = nMatricula;
        }

        public Alumno(string nombre, string nombreEmpresa)
        {
            Nombre = nombre;
            NombreEmpresa = nombreEmpresa;
        }

        public int NMatricula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public bool Aprobado { get; set; }
        public string IdCiclo { get; set; }
        public string NombreEmpresa { get; set; }
        public virtual Ciclo Ciclo { get; set; }
        public virtual FCT FCT { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Alumno);
        }

        public bool Equals(Alumno other)
        {
            return other != null &&
                   NMatricula == other.NMatricula;
        }

        public override int GetHashCode()
        {
            return 1687765875 + NMatricula.GetHashCode();
        }
    }
}

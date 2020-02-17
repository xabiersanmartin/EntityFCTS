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

        public List<Ciclo> DevolverCiclos (out string mensaje)
        {
            mensaje = "";

            if (BdFCTsEntities.Ciclos == null)
            {
                mensaje = "No hay ciclos";
                return null;
            }
            return BdFCTsEntities.Ciclos.ToList();
        }

    }
}

using DataPersonas;
using DataPersonas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioPersonas
{
    public class NegPersonas
    {
        private DatPersonas dat = new DatPersonas();

        public List<persona> Obtener() 
        {
            return dat.Obtener();
        }

        public persona ObtenerPorId(int id)
        {
            return dat.ObtenerPorId(id);
        }

        public void Agregar(persona p)
        {
            this.ValidarNombreRepetido(p);
           dat.Agregar(p);
        }

        public void Editar(persona p)
        {
            dat.Editar(p);
        }

        public void Borrar(persona p)
        {
            dat.Borrar(p);
        }

        public void ValidarNombreRepetido(persona p)
        {
            persona per = dat.ValidarNombreRepetido(p);
            if (per != null) 
            {
                throw new Exception($"El nombre {p.Nombre} ya existe");
            }
        }
    }
}

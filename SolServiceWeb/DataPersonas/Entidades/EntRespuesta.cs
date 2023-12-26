using DataPersonas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersonas.Entidades
{
    public class EntRespuesta
    {
        public List<persona> ListaPersonas { get; set; }
        public persona Personas { get; set; }
        public bool Error { get; set; } 
        public string Mensaje { get; set; }

    }
}

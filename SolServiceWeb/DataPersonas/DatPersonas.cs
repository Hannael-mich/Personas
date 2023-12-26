using DataPersonas.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersonas
{
    public class DatPersonas
    {
        //Generacion23Entities db = new Generacion23Entities();

        public List<persona> Obtener() 
        {
            using (Generacion23Entities db = new Generacion23Entities())
            {
                return db.persona.ToList();
            }
        }

        public persona ObtenerPorId(int id)
        {
            using (Generacion23Entities db = new Generacion23Entities())
            {
                return db.persona.Find(id);
            }
        }

        public void Agregar(persona p) 
        {
            using (Generacion23Entities db = new Generacion23Entities())
            {
                p.FechaAlta = DateTime.Now;
                db.persona.Add(p);
                db.SaveChanges();
                //return db.persona.ToList();
            }
        }

        public void Editar(persona p)
        {
            using (Generacion23Entities db = new Generacion23Entities())
            {
                db.persona.AddOrUpdate(p);
                db.SaveChanges();
                //return db.persona.ToList();
            }
        }

        public void Borrar(persona p)
        {
            using (Generacion23Entities db = new Generacion23Entities())
            {
                persona pDB = db.persona.Find(p.id);
                db.persona.Remove(pDB);
                db.SaveChanges();
            }
        }

        public persona ValidarNombreRepetido(persona p)
        {
            using (Generacion23Entities db = new Generacion23Entities())
            {
                persona pDB = db.persona.Where(x => x.Nombre == p.Nombre).FirstOrDefault();
                return pDB;
            }
        }
    }
}

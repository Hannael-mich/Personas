using DataPersonas.Entidades;
using DataPersonas.Model;
using NegocioPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceWeb.WS
{
    /// <summary>
    /// Descripción breve de WebServicePersonas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePersonas : System.Web.Services.WebService
    {
        NegPersonas neg = new NegPersonas();
        [WebMethod]
        public EntRespuesta Obtener()
        {
            EntRespuesta r = new EntRespuesta();
            try
            {
                r.ListaPersonas = neg.Obtener();
                return r;
            }
            catch (Exception ex)
            {
                r.Error = true;
                r.Mensaje = ex.Message;
                return r;
            }

        }
        [WebMethod]
        public persona ObtenerPorId(int id)
        {
            return neg.ObtenerPorId(id);
        }
        [WebMethod]
        public EntRespuesta Agregar (persona p)
        {
            EntRespuesta r = new EntRespuesta();
            try
            {
                neg.Agregar(p);
                return r;
            }
            catch (Exception ex)
            {
                r.Error = true;
                r.Mensaje = ex.Message;
                return r;
            }
        }
        [WebMethod]
        public void Editar(persona p)
        {
            neg.Editar(p);
        }
        [WebMethod]
        public void Borrar(persona p)
        {
            neg.Borrar(p);
        }

        [WebMethod]
        public EntRespuesta ValidarNombreRepetido(persona p)
        {
            EntRespuesta r = new EntRespuesta();
            try
            {
                neg.ValidarNombreRepetido(p);
                return r;
            }
            catch (Exception ex)
            {
                r.Error = true;
                r.Mensaje = ex.Message;
                return r;
            }
        }
    }
}

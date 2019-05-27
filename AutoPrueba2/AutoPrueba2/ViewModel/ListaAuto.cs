using AutoPrueba2.Data;
using AutoPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPrueba2.ViewModel
{
    public class ListaAuto
    {
        public List<Auto> ObtenerLista()
        {
            using (var db = new Conexionbd())
            {
                return db.Autos.ToList();
            }
        }
    }
}

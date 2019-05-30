using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AutoPrueba2.Data;
using AutoPrueba2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoPrueba2.Controllers
{
    public class VehiculosController : Controller
    {
        private Conexionbd db = new Conexionbd();
        public SqlConnection conectarbd = new SqlConnection();
        public VehiculosController(Conexionbd _db)
        {
            db = _db;
        }

        public IActionResult Eliminar(int id)
        {

            return View(GetAutoId(id));
        }
        public IActionResult Agregar()
        {


            return View();
        }
        public async Task<IActionResult> Add(Auto en)
        {

            var autito = new Auto
            {
                Id = en.Id,
                    
                    Tipo=en.Tipo,
                    
                    Marca=en.Marca,
                    
                    Modelo=en.Modelo,
                    
                    Color=en.Color,
                    
                    Deposito=en.Deposito,
                    
                    MatriculaCaracterUno=en.MatriculaCaracterUno,
                    
                    MatriculaCaracterDos=en.MatriculaCaracterDos,
                    
                    MatriculaCaracterTres=en.MatriculaCaracterTres,
                    
                    Fecha=en.Fecha
            };



            db.Autos.Add(autito);
            await db.SaveChangesAsync();

            return Redirect("/Home/Index");
        }
        public IEnumerable<Auto> Listar()
        {
            var AutosPrueba = db.Autos.ToList();

            return AutosPrueba;
        }
        public async Task<IActionResult> Delete(Auto en)
        {


            en = GetAutoId(en.Id);


            db.Remove(en);
            await db.SaveChangesAsync();

            return Redirect("/Home/Index/");

        }
        public Auto GetAutoId(int id)
        {
            return db.Autos.FirstOrDefault(x => x.Id == id);
        }
        public async Task<IActionResult> Edit(Auto en)
        {

            //throw new Exception("Error");
            db.Autos.Update(en);
            await db.SaveChangesAsync();
            return Redirect("/Home/Index/");

        }
        public Auto GetAutoIdEditar(int id)
        {
            return db.Autos.FirstOrDefault(x => x.Id == id);
        }
        public IActionResult Editar(int id)
        {

            var x = GetAutoIdEditar(id);
            return View(x);
        }
    
    }
}
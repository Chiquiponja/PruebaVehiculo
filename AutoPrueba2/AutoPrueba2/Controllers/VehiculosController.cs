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
            try
            {
                throw new Exception("No se pudo guardar el vehiculo.");
                var autito = new Auto
                {
                    Id = en.Id,

                    Tipo = en.Tipo,

                    Marca = en.Marca,

                    Modelo = en.Modelo,

                    Color = en.Color,

                    Deposito = en.Deposito,

                    MatriculaCaracterUno = en.MatriculaCaracterUno,

                    MatriculaCaracterDos = en.MatriculaCaracterDos,

                    MatriculaCaracterTres = en.MatriculaCaracterTres,

                    Fecha = en.Fecha
                };

                db.Autos.Add(autito);
                await db.SaveChangesAsync();

                return Redirect("/Home/Index");
            }
            catch (Exception ex)
            {

                ViewData["ErrorMessage"] = ex.Message;
                return View("Error");
            }
           



            
        }
        public IEnumerable<Auto> Listar()
        {
            var AutosPrueba = db.Autos.ToList();

            return AutosPrueba;
        }
        public async Task<IActionResult> Delete(Auto en)
        {

            try
            {
                throw new Exception("No se pudo Eliminar el Registro.");
                en = GetAutoId(en.Id);


                db.Remove(en);
                await db.SaveChangesAsync();

                return Redirect("/Home/Index/");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error");
            }
           

        }
        public Auto GetAutoId(int id)
        {
            return db.Autos.FirstOrDefault(x => x.Id == id);
        }
        public async Task<IActionResult> Edit(Auto en)
        {

            try
            {
                throw new Exception("No se pudo Editar el Registro.");
                db.Autos.Update(en);
                await db.SaveChangesAsync();
                return Redirect("/Home/Index/");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Error");
            }
            

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
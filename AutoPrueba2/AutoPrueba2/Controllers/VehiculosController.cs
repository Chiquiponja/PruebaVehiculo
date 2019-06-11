using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AutoPrueba2.Data;
using AutoPrueba2.Models;
using AutoPrueba2.Models.Dtos;
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
            ViewData["Id"] = id;
            var auto = GetAutoId(id);

            if (auto == null)
            {
                ViewData["ErrorMessage"] = ($"El auto con id: {id} no existe en la base de datos");
                return View("Error");
            }
            return View();
        }
        public IActionResult Agregar(int id)
        {
            ViewData["Id"] = id;
            return View(GetAutoId(id));
        }


        public async Task<IActionResult> Add(Auto en)
        {
            try
            {
                //throw new Exception("No se pudo guardar el vehiculo.");
              

                db.Autos.Add(en);
                await db.SaveChangesAsync();

                return Redirect("/Home/Index");
            }
            catch (Exception ex)
            {

                ViewData["ErrorMessage"] = ex.Message;
                return View("Error");
            }
           



            
        }

        public List<AutoDto> Listar()
        {
            List<AutoDto> AutosPrueba = new List<AutoDto>();

            foreach (var item in db.Autos.ToList())
            {
                AutoDto dto = new AutoDto();

                dto.Id = item.Id;
                dto.Tipo = item.Tipo;
                dto.Marca = item.Marca;
                dto.Modelo = item.Modelo;
                dto.Color = item.Color;
                dto.Deposito = item.Deposito;
                dto.MatriculaConcatenada = item.MatriculaCaracterUno + "-" + item.MatriculaCaracterDos + "-" + item.MatriculaCaracterTres;
                dto.MatriculaCaracterUno = item.MatriculaCaracterUno;
                dto.MatriculaCaracterDos = item.MatriculaCaracterDos;
                dto.MatriculaCaracterTres = item.MatriculaCaracterTres;
                dto.Fecha = item.Fecha.ToShortDateString();

                AutosPrueba.Add(dto);
            }
            return AutosPrueba;
        }

        public async Task<IActionResult> Delete(Auto en)
        {

            try
            {
                //throw new Exception("No se pudo Eliminar el Registro.");
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

            var auto = db.Autos.FirstOrDefault(x => x.Id == id);
            return auto;
          }

        public async Task<IActionResult> Edit(Auto en)
        {

            try
            {
                //throw new Exception("No se pudo Editar el Registro.");
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

        public IActionResult Editar(int id)
        {
            ViewData["Id"] = id;

            var auto = GetAutoId(id);

            if (auto == null)
            {
                ViewData["ErrorMessage"]= ($"El auto con id: {id} no existe en la base de datos");
                return View("Error");
            }
            return View();
        }
    
    }
}
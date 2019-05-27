using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AutoPrueba2.Data;
using AutoPrueba2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoPrueba2.Controllers
{
    public class EditarController : Controller
    {
        private Conexionbd db = new Conexionbd();
        public SqlConnection conectarbd = new SqlConnection();
        public EditarController(Conexionbd _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Edit(Auto en)
        {


            db.Autos.Update(en);
            await db.SaveChangesAsync();
            return Redirect("/Home/Privacy/");

        }
        public Auto GetAutoId(int id)
        {
            return db.Autos.FirstOrDefault(x => x.Id == id);
        }
        public IActionResult Index(int id)
        {

            var x = GetAutoId(id);
            return View(x);
        }
    }
}
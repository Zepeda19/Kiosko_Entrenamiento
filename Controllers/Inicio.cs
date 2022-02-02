using Kiosko.Data;
using Kiosko.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Controllers
{
    public class Inicio : Controller
    {
        private readonly ModelosContexto db;
        public Inicio(ModelosContexto db)
        {
            this.db = db;
        }

        // GET: Inicio
        public ActionResult Index()
        {
            ViewBag.Modulos = db.Modulos.FromSqlRaw("SELECT * FROM dbo.Modulos").ToList();
            return View();
        }

        [HttpPost]
        public ActionResult GuardarModulo(Modulos value)
        {
            try
            {
                var modulo = db.Database.ExecuteSqlRaw("INSERT INTO dbo.Modulos(vchTitulo) VALUES('" + value.vchTitulo + "')");
            }
            catch(Exception ex)
            { }

            return RedirectToAction("Index");
        }
    }
}

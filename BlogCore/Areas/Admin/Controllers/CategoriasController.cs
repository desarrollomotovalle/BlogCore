using BlogCore.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriasController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;

        public CategoriasController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Llamadas a las API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data= _contenedorTrabajo .Categoria.GetAll()});
        }

        #endregion

    }
}

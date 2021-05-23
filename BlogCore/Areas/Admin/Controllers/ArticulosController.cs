using BlogCore.AccesoDatos.Data.Repository;
using BlogCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticulosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public ArticulosController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        [HttpGet]
         public IActionResult Index()
         {
            return View();
         }

        [HttpGet]
        public IActionResult Create()
        {
            ArticuloVM articulovm = new ArticuloVM()
            {
                Articulo = new Models.Articulo(),
                ListaCategorias = _contenedorTrabajo.Categoria.GetListaCategorias()
            };

            return View(articulovm);
        }

        #region Llamadas a las API
        [HttpGet]
        public IActionResult GetAll()
        {
            //Agregamos las propiedades de categoria porque hay una foreingKey
            return Json(new { data = _contenedorTrabajo.Articulo.GetAll(includeProperties:"Categoria") });
        }

        #endregion
    }
}

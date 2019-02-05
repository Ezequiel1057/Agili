using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgiliWebMvc.Services;
using Microsoft.AspNetCore.Mvc;
using AgiliWebMvc.Models;

namespace AgiliWebMvc.Controllers
{
    public class RestauranteController : Controller
    {

        private readonly RestaurantesService _restaurantesService;

        public RestauranteController(RestaurantesService restaurantesService)
        {
            _restaurantesService = restaurantesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RestauranteLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RestauranteLogin(string cnpj_rest, string senha_rest)
        {
            if (cnpj_rest == null)
            {
                return NotFound();
            }
            var obj = _restaurantesService.FindByRestaurante(cnpj_rest);

            if (obj == null)
            {
                return NotFound();
            }
            if (obj.senha_rest != senha_rest)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateProdutos()
        {
            return View();
        }

        public IActionResult CreateProduto(ListaProduto produto, string cnpj_rest)
        {
            var objs = _restaurantesService.FindByCnpjRest(cnpj_rest);
            
            _restaurantesService.InsertProduto(produto, objs.id);
            return RedirectToAction(nameof(Index));

        }





    }
}
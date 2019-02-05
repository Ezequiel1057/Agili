using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgiliWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgiliWebMvc.Controllers
{
    public class FuncionariosController : Controller
    {

        private readonly FuncionariosService _funcionariosService;

        public FuncionariosController(FuncionariosService funcionariosService)
        {
            _funcionariosService = funcionariosService;
        }


        public IActionResult Index()
        {
            var list = _funcionariosService.FindAll();
            return View(list);
        }

        public IActionResult FuncionarioLogin()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FuncionarioLogin(string cpf_func, string senha_func)
        {

            if (cpf_func == null)
            {
                return NotFound();
            }
            var obj = _funcionariosService.FindByFuncionario(cpf_func);

            if (obj == null)
            {
                return NotFound();
            }
            if (obj.senha_func != senha_func)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));

        }




    }
}
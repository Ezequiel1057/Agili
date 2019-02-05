using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgiliWebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using AgiliWebMvc.Services;
using AgiliWebMvc.Services.Exception;

namespace AgiliWebMvc.Controllers
{
    public class AdmController : Controller
    {
        public readonly AdmService _admService;

        public AdmController(AdmService admService)
        {
            _admService = admService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFuncionario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFuncionario(Funcionarios funcionarios)
        {
            _admService.insertFuncionario(funcionarios);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateRestaurante()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRestaurante(Restaurantes restaurantes)
        {
            _admService.insertRestaurante(restaurantes);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult FindFuncionarios()
        {
            var list = _admService.FindFuncionarios();
            return View(list);
        }


        public IActionResult FindRestaurantes()
        {
            var list = _admService.FindRestaurantes();
            return View(list);
        }


        public IActionResult DeletarFuncionario(int? id)
        {
            if(id == null)
            {
                return NotFound();

            }
            var obj = _admService.FindByidFuncionario(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarFuncionario(int id)
        {
            _admService.RemoveFuncionario(id);
            return RedirectToAction(nameof(FindFuncionarios));
        }



        public IActionResult DeletarRestaurante(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var obj = _admService.FindByidRestaurante(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarRestaurante(int id)
        {
            _admService.RemoveRestaurante(id);
            return RedirectToAction(nameof(FindRestaurantes));
        }


        
        public IActionResult EditFuncionario(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _admService.FindByidFuncionario(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            Funcionarios funcionarios = new Funcionarios { id = obj.id, cpf_func = obj.cpf_func, nome_func = obj.nome_func, senha_func = obj.senha_func };
            return View(funcionarios);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditFuncionario(int id, Funcionarios funcionarios)
        {
            if (id != funcionarios.id)
            {
                return BadRequest();
            }

            try
            {
                _admService.UpdateFuncionario(funcionarios);
                return RedirectToAction(nameof(FindFuncionarios));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }

        public IActionResult EditRestaurante(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _admService.FindByidRestaurante(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            Restaurantes restaurantes = new Restaurantes { id = obj.id, cnpj_rest = obj.cnpj_rest, nome_rest = obj.nome_rest, endereco_rest = obj.endereco_rest, telefone_rest = obj.telefone_rest, senha_rest = obj.senha_rest };
            return View(restaurantes);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditRestaurante(int id, Restaurantes restaurantes)
        {
            if (id != restaurantes.id)
            {
                return BadRequest();
            }
            try
            {
                _admService.UpdateRestaurante(restaurantes);
                return RedirectToAction(nameof(FindRestaurantes));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }

        }





        public IActionResult AdmLogin()
        {
            return View();

        }


       [HttpPost]
       [ValidateAntiForgeryToken]
        public IActionResult AdmLogin(string cpf_adm, string senha_adm)
        {
            
            if(cpf_adm == null)
            {
                return NotFound();
            }
            var obj = _admService.FindByAdm(cpf_adm);
            if(obj == null)
            {
                return NotFound();
            }
            if (obj.senha_adm != senha_adm)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
            
        }


    }
}
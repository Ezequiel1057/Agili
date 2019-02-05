using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgiliWebMvc.Models;

namespace AgiliWebMvc.Services
{
    public class FuncionariosService
    {

        private readonly AgiliWebMvcContext _context;

        public FuncionariosService (AgiliWebMvcContext context)
        {
            _context = context;
        }

        public List<Funcionarios> FindAll()
        {
            return _context.Funcionarios.ToList();
        }

        public Funcionarios FindByFuncionario(string cpf)
        {
            return _context.Funcionarios.FirstOrDefault(obj => obj.cpf_func == cpf);
            //return _context.Restaurantes.FirstOrDefault(obj => obj.id == id);
        }

    }
}

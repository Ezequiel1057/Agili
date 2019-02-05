using AgiliWebMvc.Models;
using AgiliWebMvc.Services.Exception;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgiliWebMvc.Services
{
    public class AdmService
    {
        private readonly AgiliWebMvcContext _context;


        public AdmService(AgiliWebMvcContext context)
        {
            _context = context;
        }

        public void insertFuncionario(Funcionarios obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void insertRestaurante(Restaurantes obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public IList<Funcionarios> FindFuncionarios()
        {
            return _context.Funcionarios.ToList();
        }

        public IList<Restaurantes> FindRestaurantes()
        {
            return _context.Restaurantes.ToList();
        }

        public Funcionarios FindByidFuncionario(int id)
        {
            return _context.Funcionarios.FirstOrDefault(obj => obj.id == id);
        }

        public void RemoveFuncionario(int id)
        {
            var obj = _context.Funcionarios.Find(id);
            _context.Funcionarios.Remove(obj);
            _context.SaveChanges();
        }

        public Restaurantes FindByidRestaurante(int id)
        {
            return _context.Restaurantes.FirstOrDefault(obj => obj.id == id);
        }

        public void RemoveRestaurante(int id)
        {
            var obj = _context.Restaurantes.Find(id);
            _context.Restaurantes.Remove(obj);
            _context.SaveChanges();
        }

        public void UpdateFuncionario(Funcionarios obj)
        {
            if (!_context.Funcionarios.Any(x => x.id==obj.id))
            {
                throw new NotFoundException("id não encontrado");
               
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }

            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }
        public void UpdateRestaurante(Restaurantes obj)
        {
            if (!_context.Restaurantes.Any(x => x.id==obj.id))
            {
                throw new NotFoundException("id não encontrado");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }









        public Adm FindByAdm(string cpf)
        {
            return _context.Adm.FirstOrDefault(obj => obj.cpf_adm == cpf);
            //return _context.Restaurantes.FirstOrDefault(obj => obj.id == id);
        }



    }
}

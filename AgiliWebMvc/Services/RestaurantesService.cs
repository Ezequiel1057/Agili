using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgiliWebMvc.Models;

namespace AgiliWebMvc.Services
{
    public class RestaurantesService
    {
        private readonly AgiliWebMvcContext _context;

        public RestaurantesService(AgiliWebMvcContext context)
        {
            _context = context;
        }

        public Restaurantes FindByRestaurante(string cnpj)
        {
            return _context.Restaurantes.FirstOrDefault(obj => obj.cnpj_rest == cnpj);
            //return _context.Restaurantes.FirstOrDefault(obj => obj.id == id);
        }

        public Restaurantes FindByCnpjRest(string cnpj_rest)
        {
            return _context.Restaurantes.FirstOrDefault(obj => obj.cnpj_rest == cnpj_rest);
        }

        public void InsertProduto(ListaProduto produto, int id)
        {

            produto.Restaurantesid = id;
            _context.Add(produto);
            _context.SaveChanges();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgiliWebMvc.Models
{
    public class ListaProduto
    {
        public int id { get; set; }
        public string nome_prod { get; set; }
        //public int cod_restaurante { get; set; }
        public double valor_produto { get; set; }
        public Restaurantes  Restaurantes { get; set; }
        public int Restaurantesid { get; set; }


        public ListaProduto()
        {
        }

        public ListaProduto(int id, string nome_prod, double valor_produto, Restaurantes restaurantes)
        {
            this.id = id;
            this.nome_prod = nome_prod;
            this.valor_produto = valor_produto;
            Restaurantes = restaurantes;
        }
    }
}

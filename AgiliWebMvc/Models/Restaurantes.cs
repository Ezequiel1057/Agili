using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgiliWebMvc.Models
{
    public class Restaurantes
    {
        public int id { get; set; }
        public string nome_rest { get; set; }
        public string cnpj_rest { get; set; }
        public string telefone_rest { get; set; }
        public string endereco_rest { get; set; }
        public string senha_rest { get; set; }
        public ICollection<ListaProduto> listaProdutos  { get; set; } = new List<ListaProduto>();

        public Restaurantes()
        {
        }

        public Restaurantes(int id, string nome_rest, string cnpj_rest, string telefone_rest, string endereco_rest, string senha_rest)
        {
            this.id = id;
            this.nome_rest = nome_rest;
            this.cnpj_rest = cnpj_rest;
            this.telefone_rest = telefone_rest;
            this.endereco_rest = endereco_rest;
            this.senha_rest = senha_rest;
        }

        public void AddProduto(ListaProduto lp )
        {
            listaProdutos.Add(lp);
        }

        public void RemoveProduto(ListaProduto lp)
        {
            listaProdutos.Remove(lp);
        }

    }   
}

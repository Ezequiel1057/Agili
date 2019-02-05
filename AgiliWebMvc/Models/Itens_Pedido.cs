using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgiliWebMvc.Models
{
    public class Itens_Pedido
    {
        public int id { get; set; }
        public int qtd_itensPedido { get; set; }
        public Pedido Pedidos { get; set; }
        public ListaProduto listaProdutos { get; set; }
        //public ICollection<ListaProduto> listaProdutos { get; set; } = new List<ListaProduto>();



        public Itens_Pedido()
        {
        }

        public Itens_Pedido(int id, int qtd_itensPedido, Pedido pedidos, ListaProduto listaProdutos)
        {
            this.id = id;
            this.qtd_itensPedido = qtd_itensPedido;
            Pedidos = pedidos;
            this.listaProdutos = listaProdutos;
        }
    }
}

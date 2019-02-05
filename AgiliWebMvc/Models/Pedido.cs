using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgiliWebMvc.Models
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime data_pedido { get; set; }
        public int quantidadeTotal_pedidos { get; set; }
        public double valorTotal_pedidos { get; set; }
        public ICollection<Itens_Pedido> Itens { get; set; } = new List<Itens_Pedido>();
        public Funcionarios Funcionarios { get; set; }

        public Pedido()
        {

        }

        public Pedido(int id, DateTime data_pedido, int quantidadeTotal_pedidos, double valorTotal_pedidos, Funcionarios funcionarios)
        {
            this.id = id;
            this.data_pedido = data_pedido;
            this.quantidadeTotal_pedidos = quantidadeTotal_pedidos;
            this.valorTotal_pedidos = valorTotal_pedidos;
            Funcionarios = funcionarios;
        }



    }
}

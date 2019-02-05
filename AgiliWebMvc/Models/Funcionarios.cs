using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgiliWebMvc.Models
{
    public class Funcionarios
    {
        public int id { get; set; }
        public string nome_func { get; set; }
        public string cpf_func { get; set; }
        public string senha_func { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
        


        public Funcionarios()
        {

        }

        public Funcionarios(int id, string nome_func, string cpf_func, string senha_func)
        {
            this.id = id;
            this.nome_func = nome_func;
            this.cpf_func = cpf_func;
            this.senha_func = senha_func;
        }

        public void AddPedidos(Pedido pedido)
        {
            Pedidos.Add(pedido);

        }

        public void RemovePedidos(Pedido pedido)
        {
            Pedidos.Remove(pedido);

        }

    }
}

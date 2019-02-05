using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgiliWebMvc.Models;

namespace AgiliWebMvc.Data
{
    public class SeedingService
    {
        private AgiliWebMvcContext _context;

        public SeedingService(AgiliWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Adm.Any())
            {
                return; // DB já populado
            }


            //Adm adm1 = new Adm(1, "admAgili", "438.376.428-28", "123456789");

            Adm adm1 = new Adm {  nome_adm = "Adm Agili", cpf_adm = "43978567898", senha_adm = "123456789" };

            Funcionarios func1 = new Funcionarios {nome_func = "Gustavo Sousa", cpf_func = "356.789.482-95", senha_func = "123456789" };

            Restaurantes rest1 = new Restaurantes {  nome_rest = "Madero", cnpj_rest = "26.522.498/0001-46", endereco_rest = "Avenida Paulista", telefone_rest = "998564278", senha_rest = "123456789"};

            ListaProduto prod1 = new ListaProduto { nome_prod = "cola-cola", Restaurantes = rest1, valor_produto = 2.00 };

            Pedido ped1 = new Pedido {  data_pedido = new DateTime(2018, 01, 30), Funcionarios = func1, quantidadeTotal_pedidos = 1, valorTotal_pedidos = 2.00 };

            Itens_Pedido itens1 = new Itens_Pedido {  qtd_itensPedido = 1, Pedidos = ped1, listaProdutos = prod1 };

            _context.Adm.AddRange(adm1);

            _context.Funcionarios.AddRange(func1);

            _context.Restaurantes.AddRange(rest1);

            _context.ListaProduto.AddRange(prod1);

            _context.Pedidos.AddRange(ped1);

            _context.Itens_Pedidos.AddRange(itens1);

            _context.SaveChanges();


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgiliWebMvc.Models
{
    public class AgiliWebMvcContext : DbContext
    {
        public AgiliWebMvcContext (DbContextOptions<AgiliWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<AgiliWebMvc.Models.ListaProduto> ListaProduto { get; set; }
        public DbSet<AgiliWebMvc.Models.Funcionarios> Funcionarios  { get; set; }
        public DbSet<AgiliWebMvc.Models.Adm> Adm { get; set; }
        public DbSet<AgiliWebMvc.Models.Itens_Pedido> Itens_Pedidos  { get; set; }
        public DbSet<AgiliWebMvc.Models.Restaurantes> Restaurantes { get; set; }
        public DbSet<AgiliWebMvc.Models.Pedido> Pedidos { get; set; }



    }
}

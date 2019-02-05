using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgiliWebMvc.Models
{
    public class Adm
    {
        public int id { get; set; }
        //public int cod_adm { get; set; }
        public string nome_adm { get; set; }
        public string cpf_adm { get; set; }
        public string senha_adm { get; set; }
        public ICollection<Funcionarios> Func { get; set; } = new List<Funcionarios>();
        public ICollection<Restaurantes> Restaurantes { get; set; } = new List<Restaurantes>();

        public Adm()
        {
        }

        public Adm(int id, string nome_adm, string cpf_adm, string senha_adm)
        {
            this.id = id;
            this.nome_adm = nome_adm;
            this.cpf_adm = cpf_adm;
            this.senha_adm = senha_adm;
        }


        public void AddFunc(Funcionarios funcionarios)
        {
            Func.Add(funcionarios);
        }

        public void RemoveFunc(Funcionarios funcionarios)
        {
            Func.Remove(funcionarios);
        }


        public void AddRestaurante(Restaurantes restaurantes)
        {
            Restaurantes.Add(restaurantes);
        }

        public void RemoveRestaurante(Restaurantes restaurantes)
        {
            Restaurantes.Remove(restaurantes);
        }
    }
}

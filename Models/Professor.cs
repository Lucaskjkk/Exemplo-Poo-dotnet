using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"olá, me chamo {Nome}, tenho {Idade} e meu salário é de {Salario}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Properties
{
    class Jogo
    {
        public string nome;
        public string classificacao;

        public void Rodando()
        {
            Console.WriteLine($"Rodando o jogo {nome}");
            Console.ReadLine();
        }
    }
}

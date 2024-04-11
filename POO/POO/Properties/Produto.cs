using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Properties
{
    class Produto
    {
        //Produto para e-commerce de celulares
        public string nome;
        public string marca;
        public string modelo;
        public char sn;//Serial number
        public string cor;


        public void Ligar()
        {
            Console.WriteLine("Ligando para algum contato");
            Console.ReadLine();
        }
        public void Instalar()
        {
            Console.WriteLine("Instalando APPS");
            Console.ReadLine();
        }

    }
}

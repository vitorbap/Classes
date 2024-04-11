using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Pedido
    {
        public string comida;
        public string bebida;

        public void Lançar()
        {
            Console.WriteLine($"Lançando pedido de {comida} e {bebida}");
            Console.ReadLine();
        }
    }
}

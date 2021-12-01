using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedidos = Pedido.Buscar();

            foreach(var pedido in pedidos)
            {
                Console.WriteLine("=== Pedido ===");
                Console.WriteLine("Cliente: " + pedido.Cliente.Nome);
                foreach(var produto in pedido.Produtos)
                {
                    Console.WriteLine("Produto: " + produto.Nome);
                    Console.WriteLine("Fornecedor do Produto: " + produto.Fornecedor.Nome);
                }
            }


            Console.WriteLine("Hello world");
        }
    }
}

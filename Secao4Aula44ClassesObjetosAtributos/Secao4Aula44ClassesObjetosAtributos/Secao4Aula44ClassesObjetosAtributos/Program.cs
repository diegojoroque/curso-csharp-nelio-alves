using System;
using System.Globalization;

namespace Secao4Aula44ClassesObjetosAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Problema:
                   Fazer um programa para ler os dados de um produto em estoque (nome,preço e quantidade no estoque). Em seguida:
                    * Mostrar os dados do produto (nome, preço, quantidade no estoque,valor total no estoque)
                    * Realizar uma entrada no estoque e mostrar novamente os dados do produto
                    * Realizar uma saída no estoque e mostrar novamente os dados do produto
            */

            Produto product = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            product.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            product.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            product.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + product);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            product.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + product);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            product.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + product);
        }
    }
}

using System;

namespace Produtos_Estoques
{
    class Program
    {
        static void Main(string[] args)
        {       
            

            Console.WriteLine("Informe os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine().ToString();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            
            /*O método p.AdicionarProdutos é capaz de receber um valor de entrada da variavel qte é 
            armazenar o valor dessa variável na variavel de parâmetro int quantidade e efetuar a operação*/
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}

using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n): ");
            string resp = Console.ReadLine();

            if (resp == "s" || resp == "S")
            {
                Console.Write("Digite o valor do déposito inicial: ");
                double depInicial = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                conta = new ContaBancaria(numero, titular, depInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);                
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double saque = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

        }
    }
}

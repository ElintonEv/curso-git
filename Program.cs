using System;
using System.Globalization;


namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria p;
            Console.Write("Entre o número da conta: ");
             int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
             string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char Alternativa = char.Parse(Console.ReadLine());
            if (Alternativa == 's' || Alternativa == 'S')
            {
                Console.Write("Entre um valor para depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new ContaBancaria(numero, titular, valor);
            }
            else {
                p = new ContaBancaria(numero, titular);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.ValorDeposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.ValorSaque(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);
        }
    }
}

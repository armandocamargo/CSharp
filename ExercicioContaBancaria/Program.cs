using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá deposito inicial (S/N)? ");
            char haveraDeposito = char.Parse(Console.ReadLine());

            if (haveraDeposito == 'S' || haveraDeposito == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, titularConta, depositoInicial);
            }
            else
            {

                conta = new ContaBancaria(numeroConta, titularConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para Saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}

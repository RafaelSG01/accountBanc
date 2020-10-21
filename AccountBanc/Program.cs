using AccountBanc.Entities;
using AccountBanc.Entities.Exceptions;
using System;
using System.Globalization;

namespace AccountBanc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta:!");
                Console.Write("Número da conta: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Titular da conta: ");
                string name = Console.ReadLine();
                Console.Write("Saldo Inicial: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.Write("Entre com o valor de saque: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, withdrawLimit);
                account.Withdraw(withdraw);

                Console.WriteLine("Novo saldo: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExeption e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

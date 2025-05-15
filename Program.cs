using System;
using System.Globalization;


namespace ValorBancario {
    class Program {

        static void Main(string[] args) {

            Banco conta;

            Console.Write("Digite o número da sua conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Terá depósito incial?: (S/N): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Banco(numero, titular, depositoInicial);

            }
            else {
                conta = new Banco(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);



        }
    }
}

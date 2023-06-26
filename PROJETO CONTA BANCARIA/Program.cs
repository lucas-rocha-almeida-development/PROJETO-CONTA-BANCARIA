using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_CONTA_BANCARIA {
    internal class Program {


        static void Main(string[] args) {
            ContaBancaria conta;
            Console.Write("Entre com  o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Enre com titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (S/N) ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                //caso tenha saldo inicial, iremos executar essa condição
                Console.Write("Entre com deposito INICIAL: ");
                double DepositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero,titular,DepositoInicial);

            }
            //caso não tenha, irei utilizar o construtor com apenas 2 argumentos (numero,titular)
            else {
                conta = new ContaBancaria(numero, titular);
                //ira entrar um saldo zerado ( devido int, ja iniciar com zero)
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine("------------------------\n----------------------");
            Console.Write("Entre um valor para DEPOSITO: ");
            double quantia = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.Write("Dados da conta Atualizados: ");
            Console.WriteLine(conta);
            //abaixo entrar com quantia de saque
            Console.WriteLine("------------------------\n----------------------");
            Console.Write("Entre um valor para SAQUE: ");
             quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.Write("Dados da conta Atualizados: ");
            Console.WriteLine(conta);
            Console.ReadKey();
        }
    }
}

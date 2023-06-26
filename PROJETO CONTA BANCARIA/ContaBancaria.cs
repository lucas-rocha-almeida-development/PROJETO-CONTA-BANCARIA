using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_CONTA_BANCARIA {
    internal class ContaBancaria {
        public int Numero { get; private set; }
        public string Titular { get; private set; }

        public double Saldo { get; private set; }

        //1º Contrutor
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        //2º Construtor
        public ContaBancaria (int numero,string titular,double depositoinicial) : this (numero, titular) {

            Deposito(depositoinicial);
        }
        //3º Metodos (calculos)
        public void Deposito (double quantia) {
            Saldo += quantia;
        }
        public void Saque (double quantia) {
            //irei descontar sempre a quantia certa
            // mais 5 reais de taxa para cada saque.
            Saldo -= quantia + 5.00 ;
        }

        //tostring com override concat
        public override string ToString() {
            return "Conta: " + Numero
                + ", Titular: " 
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

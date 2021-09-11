using System;
using System.Globalization;

namespace Exercício_de_fixação
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Deposito { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            Deposito = 0;
        }
        public ContaBancaria(int numero, string titular, double deposito) {
            Numero = numero;
            Titular = titular;
            Deposito = deposito;       
        } 

        public void ValorDeposito(double valor) {
            Deposito += valor;
        }
        public void ValorSaque(double valor)
        {
            Deposito -= valor + 5.0;
        }
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Deposito.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

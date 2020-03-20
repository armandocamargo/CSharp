using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular)
        {
            Saldo = saldo;
        }

        public ContaBancaria()
        {

        }

        public double Deposito(double deposito)
        {
            return Saldo = Saldo + deposito;
        }

        public double Saque(double saque)
        {
            return saque > 0.0 ? (Saldo = Saldo - saque - 5) : (Saldo = Saldo);
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

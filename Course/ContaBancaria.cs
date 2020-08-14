using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome},  Saldo $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void SetSaldo(double saldo)
        {
            Saldo = Saldo + saldo;
        }
    }
}

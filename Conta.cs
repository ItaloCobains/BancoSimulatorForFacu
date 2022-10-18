using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class Conta
    {
        private Pessoa Titular;
        private string Nconta;
        private string Nagencia;
        private double Saldo;

        public Conta(Pessoa titular, string nconta, string nagencia, double saldo)
        {
            Titular = titular;
            Nconta = nconta;
            Nagencia = nagencia;
            Saldo = saldo;
        }
    }
}


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
        private float Saldo;

        public Conta(Pessoa titular, string nconta, string nagencia, float saldo)
        {
            Titular = titular;
            Nconta = nconta;
            Nagencia = nagencia;
            Saldo = saldo;
        }

        public bool Sacar(float value)
        {
            if (this.Saldo < value)
            {
                return false;
            }
            if (value < 0 )
            {
                return false;
            }
            this.Saldo -= value;
            return true;
        }

        public bool Depositar(float value)
        {
            if (value < 0)
            {
                return false;
            }
            this.Saldo += value;
            return true;
        }

        public bool Transferir(string agencia, string conta, float value)
        {
            if (this.Saldo < value)
            {
                return false;
            }
            if (value < 0)
            {
                return false;
            }
            this.Saldo -= value;
            return true;
        }

        public float saldo()
        {
            return Saldo;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class Pessoa
    {
        // Variaveis para a class Pessoa
        private string nome;
        private string sobrenome;
        private int idade;
        private string cpf;
        private int rg;

        public Pessoa(string nome, string sobrenome, int idade, string cpf, int rg)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.cpf = cpf;
            this.rg = rg;
        }

        //Get para nome
        public string getNome()
        {
            return nome;
        }

        //Set para nome
        public void setNome(string n)
        {
            nome = n;
        }

        //Get para nomesobre
        public string getSobrenome()
        {
            return sobrenome;
        }

        //Set para nomesobre
        public void setSobrenome(string n)
        {
            sobrenome = n;
        }

        //get idade
        public int getIdade()
        {
            return idade;
        }

        //set idade
        public void setIdade(int i)
        {
            if(i < 0)
            {
                Console.WriteLine("A idade não pode ser um valor negativo. Valor não setado.");
            } else
            {
                this.idade = i;
            }
        }

        // get CPF
        public string getCpf()
        {
            return cpf;
        }

        // set cpf
        public void setCpf(string c)
        {
            cpf = c;
        }

        // get rg
        public int getRg()
        {
            return rg;
        }

        // set rg
        public void setRg(int c)
        {
            rg = c;
        }

     
    }
}

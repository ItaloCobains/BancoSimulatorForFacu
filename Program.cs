using banco;
using System;
using System.Globalization;

class Banco
{
    Conta ContaMain;
    Pessoa PessoaContaMain;

    public void GerarContaMain()
    {
        PessoaContaMain = new Pessoa("User", "1", 18, "123.123.123-98", 234234);
        ContaMain = new Conta(PessoaContaMain, "09923-2", "2345", 400);
    }

    public void MenuInicial()
    {
        
        string opcao = "";
        float q;



        while (opcao != "0")
        {
            Console.WriteLine("==================== BEM VINDO AO BANCO ===================");
            Console.WriteLine("0 - Sair.");
            Console.WriteLine("1 - Sacar.");
            Console.WriteLine("2 - Depositar.");
            Console.WriteLine("3 - Transferir.");
            Console.WriteLine("4 - Ver Saldo.");
            Console.WriteLine("Informe a opção desejada: ");
            opcao = Console.ReadLine();

            string quantia;
            switch (opcao)
            {
                case "0":
                    return;
                case "1":
                    Console.WriteLine("Quando quer sacar ?");
                    quantia = Console.ReadLine();
                    q = float.Parse(quantia);
                    ContaMain.Sacar(q);
                    break;
                case "2":
                    Console.WriteLine("Quanto quer depositar ?");
                    quantia = Console.ReadLine();
                    q = float.Parse(quantia);
                    ContaMain.Depositar(q);
                    break;
                case "3":
                    Console.WriteLine("Digite a agencia: ");
                    string agencia = Console.ReadLine();
                    Console.WriteLine("Digite a conta: ");
                    string conta = Console.ReadLine();
                    Console.WriteLine("Quanto quer transferir ?");
                    quantia = Console.ReadLine();
                    q = float.Parse(quantia);
                    ContaMain.Transferir(agencia, conta, q);
                    break;
                case "4":
                    float result = ContaMain.saldo();
                    Console.WriteLine($"{result}");
                    break;
            }
        }
    }
    

    public static void Main()
    {
        Banco banco = new();
        banco.GerarContaMain();
        banco.MenuInicial();
    }
}

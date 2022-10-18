using banco;
using System;

class Banco
{
    public void MenuInicial()
    {
        string opcao = "";

        while (opcao != "0")
        {
            Console.WriteLine("==================== BEM VINDO AO BANCO ===================");
            Console.WriteLine("0 - Sair.");
            Console.WriteLine("1 - Criar conta.");
            Console.WriteLine("2 - Depositar.");
            Console.WriteLine("3 - Sacar.");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            opcao = Console.ReadLine();

            switch(opcao)
            {
                case "0":
                    return;
                case "1":
                    Conta
            }
        }
    }
    

    public static void Main(string[] args)
    {
        Banco banco = new Banco();  

        banco.MenuInicial();
    }
}

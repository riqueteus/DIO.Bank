using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpçaoUsuario();

           while (opcaoUsuario.ToUpper() != "X")
           {
               switch (opcaoUsuario)
               {
                   case "1":
                      //ListarContas();
                      break;
                   case "2":
                      //NovaConta();
                      break;
                    case "3":
                      //Tranferencia();
                      break;
                    case "4":
                      //Saque();
                      break;
                    case "5":
                      //Deposito();
                      break;
                    case "C":
                      Console.Clear();
                      break;
                    
                    default:
                      throw new ArgumentOutOfRangeException();
               }
               
               opcaoUsuario = ObterOpçaoUsuario();
           }

           Console.WriteLine("Obrigado por utilizar nossos serviços.");
           Console.ReadLine();
        }

        private static string ObterOpçaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu Dispor!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar Contas");
            Console.WriteLine("2- Nova Conta");
            Console.WriteLine("3- Transferência");
            Console.WriteLine("4- Saque");
            Console.WriteLine("5- Depósito");
            Console.WriteLine("C- Limpar");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}

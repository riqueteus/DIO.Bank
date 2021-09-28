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
                      ListarContas();
                      break;
                   case "2":
                      NovaConta();
                      break;
                    case "3":
                      Tranferencia();
                      break;
                    case "4":
                      Saque();
                      break;
                    case "5":
                      Deposito();
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

        private static void Tranferencia()
        {
            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Deposito()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Saque()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
            for (int i = 0; i <listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);

            }
        }

        private static void NovaConta()
        {
            Console.WriteLine("Inserir nova conta");
            Console.Write("DIgite 1 para Conta Física ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu Nome: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite a sua cidade: ");
            string entradaCidade = Console.ReadLine();

            Console.Write("Digite seu saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta) entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome,
                                        cidade: entradaCidade);
                
            listContas.Add(novaConta);

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

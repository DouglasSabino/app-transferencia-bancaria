using System;
using System.Collections.Generic;
namespace DIO.bank
{
    class Program
    {

        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "x"){

                switch (opcaoUsuario){

                    case "1":
                        ListarContas();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;

                    case "2":
                       InserirConta();
                       opcaoUsuario = ObterOpcaoUsuario();
                        break;

                    case "3":
                        Transferir();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;

                    case "4":
                        Sacar();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;

                    case "5":
                        Depositar();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;

                    case "C":
                        Console.Clear();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;

                    case "X":

                        break;

                    default:
                      
                        break;        

                }


            }
        }

        private static void Transferir()
        {
            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta Destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = Double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Write("Digite o numero da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);

            
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if(listContas.Count == 0 ){

                Console.WriteLine("Nenhuma conta cadastrada.");
                return;

            }

            for(int i = 0; i < listContas.Count; i++){

                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);

            }
        }

        private static void InserirConta()
        {
            Console.Write("Digite 1 para Conta Fisica ou 2 para juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            
            Console.Write("Digite o Credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta (tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            listContas.Add(novaConta);                           


        }

        private static string ObterOpcaoUsuario(){

            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Trnasferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}

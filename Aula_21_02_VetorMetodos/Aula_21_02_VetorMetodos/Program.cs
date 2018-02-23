using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21_02_VetorMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            // fechando tests do git
        }

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Cadastre 50 alunos \n\n" +
            "o que vc deseha fazer: \n\n" +
            "1 - cadastrar aluno. \n\n" +
            "2 - listar alunos cadastrados. \n\n" +
            "3 - sair do programa. \n\n" +
            "Digite o numero desejado: ");

            int opcao = Int32.Parse(Console.ReadLine());

            int tamanhoVetor = 2;
            int[] codigoAluno = new int[tamanhoVetor];
            string[] nome = new string[tamanhoVetor];
            int[] idade = new int[tamanhoVetor];
            char[] sexo = new char[tamanhoVetor];

            switch (opcao)
            {
                case 1:
                    cadastro(ref codigoAluno, ref nome, ref idade, ref sexo);
                    break;
                case 2:
                    listar(ref codigoAluno, ref nome, ref idade, ref sexo);
                    break;
                case 3:
                    fechar();
                    break;
                default:
                    aviso();
                    break;
            }
            Console.ReadKey();
        }


        public static void cadastro(ref int[] codigoAluno, ref string[] nome, ref int[] idade, ref char[] sexo)
        {
            int opcao;

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Digite o codigo do aluno");
                codigoAluno[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("====================================");
                Console.WriteLine("Digite o seu nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("====================================");
                Console.WriteLine("Digite sua idade: ");
                idade[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("====================================");
                Console.WriteLine("Digite o seu sexo: ");
                sexo[i] = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("====================================");

                Console.WriteLine("\n\nDeseja cadastrar novamente (1-SIM / 2-NÃO)");
                opcao = Int32.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    continue;
                }
                else if (opcao == 2)
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("opcao errada");
                }
            }
        }

        public static void listar(ref int[] codigoAluno, ref string[] nome, ref int[] idade, ref char[] sexo)
        {

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Nome: ");
                Console.WriteLine(nome[i]);
                Console.WriteLine("Idade:");
                Console.WriteLine(idade[i]);
            }
            Console.ReadKey();
            Console.Clear();
            menu();
        }



        public static void fechar()
        {
            // comando utilizado para fechar o programa direto
            Console.WriteLine("programa finalizado, até mais!!!!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void aviso()
        {
            Console.Clear();
            Console.WriteLine("\n\n <!!--Esta opção não foi encontrada, favor digitar opçao existente !!! --!!>" +
                "pressione ENTER para voltar ao menu");
            Console.ReadKey();
            menu();
        }
    }
}

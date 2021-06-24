using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;    // variavel constante (nomenclatura: tudo maiúsculo separado por underline)
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int MEDIA_ALUNOS = 3;
        public const int MOSTRAR_MENSAGEM = 4;

        public static void Opcoes()
        {
            while (true)   //looping infinito com as opções do menu, até que o usuário digite o valor para sair do programa.
            {
                string mensagem = "\nOlá usuário, bem vindo ao programa, escolha uma das opções abaixo:" +
                    "\n\n  0 - Sair do Programa" +
                    "\n  1 - Ler arquivos" +
                    "\n  2 - Tabuada" +
                    "\n  3 - Media dos alunos" +
                    "\n  4 - Mostrar mensagem" +
                    "\n\n  Qual opção deseja:";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());  //lê o valor digitado pelo usuário


                if (SAIDA_PROGRAMA == valor)    //compara o valor digitado se é igual ao parâmetro da variavel constante SAIDA_PROGRAMA
                {
                    break;    //se o valor digitado pelo usuário for o mesmo da variavel SAIDA_PROGRAMA, pausa a execução e sai do programa, caso contrario, o programa volta ao looping e pede para o usuário digitar outro número.
                }

                else if (LER_ARQUIVOS == valor)    //compara o valor digitado se é igual ao parâmetro da variavel constante SAIDA_PROGRAMA
                {
                    Arquivo.Ler(1); //Chama a função LerArquivo iniciando do parâmetro 1.
                }

                else if (TABUADA == valor)    //compara o valor digitado se é igual ao parâmetro da variavel constante SAIDA_PROGRAMA
                {
                    Console.WriteLine("\nTabuada de qual número você deseja vizualizar? ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);  //chama a função tabuada.
                }

                else if (MEDIA_ALUNOS == valor)   //compara o valor digitado se é igual ao parâmetro da variavel constante SAIDA_PROGRAMA
                {
                    Media.Aluno();  //chama a função Aluno que esta dentro da classe Media.
                }

                else if (MOSTRAR_MENSAGEM == valor)   //compara o valor digitado se é igual ao parâmetro da variavel constante SAIDA_PROGRAMA
                {
                    Mensagem.Mostrar();   //chama a função MostrarMensagemNaTela.
                }

                else
                {
                    Console.WriteLine("\nOpção inválida, digite uma opção disponível no menu!");
                    Console.WriteLine("=====================================================");
                }
            }
        }
    }
}

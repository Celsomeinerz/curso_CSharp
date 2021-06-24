using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("\nDigite o nome do aluno:\n ");   //pede para o usuário digitar o nome do aluno
            string nome = Console.ReadLine();    //lê o nome do aluno digitado pelo usuário
            int qtdNotas = 3;    //variavel com a quantidade de notas a serem lidas
            Console.WriteLine("\nDigite as " + qtdNotas + " notas do aluno " + nome + "\n");
            List<int> notas = new List<int>();    //abre uma lista contendo as notas

            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)   //looping iterando cada nota digitada
            {
                Console.WriteLine("  Digite a nota numero " + i + "\n");  //Pede ao usuário que digite as notas 
                int nota = int.Parse(Console.ReadLine());   //Lê as notas digitadas pelo usuário
                totalNotas += nota;   //total de notas recebe o valor dele mesmo + nota
                notas.Add(nota);   //adc o valor de nota para a lista notas            
            }

            int media = totalNotas / notas.Count;     //calcula a media somando o valor total de notas e dividindo pelo contador(qtd de notas) dentro da lista notas
            Console.WriteLine("\nA media do aluno " + nome + " é: " + media);
            Console.WriteLine("\nSuas notas são:\n");

            foreach (int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n\n");   //para cada nota dentro da lista notas imprime na tela a mensagem
            }

            if (media < 7)
            {
                Console.WriteLine("Que pena, sua média foi " + media + " e você esta Reprovado!");
            }

            else
            {
                Console.WriteLine("Parabéns, sua média foi " + media + " e você esta Aprovado!");
            }
        }
    }
}

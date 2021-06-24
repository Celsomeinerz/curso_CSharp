using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Diretorio
{
    class Arquivo 
    {
        private static string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];   //Função retornando o valor caminho_arquivos que esta no App.config   
        }

        public static void Ler(int numeroArquivo)  //função privada chamada LerArquivo com parâmetro numeroArquivo definido como inteiro 
        {
            string arquivoComCaminho = CaminhoArquivo() + "arq" + numeroArquivo + ".txt";  //variável chamando a função CaminhoArquivo e passando o caminho do arquivo
            Console.WriteLine("========== Lendo arquivo ===========\n" + arquivoComCaminho + "\n====================================");
            if (File.Exists(arquivoComCaminho))          //if testando se o arquivo existe no caminho definido na variável arquivoComCaminho
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))       // Abrindo e lendo o arquivo se for existente.
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)      //Lendo cada linha do arquivo
                    {
                        Console.WriteLine(linha);    //mostrando na tela cada linha do arquivo
                    }
                    Console.WriteLine("\n");
                }
            }
            string arquivoComCaminho2 = CaminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";   //incrementa +1 ao nome do arquivo (arq1.txt -> arq2.txt)
            if (File.Exists(arquivoComCaminho2))    //testa se existe algum arquivo posterior para ser aberto(arq2.txt)
            {
                Arquivo.Ler(numeroArquivo + 1);    //Caso exista o arquivo 2, chama a função LerArquivo novamente com a incrementação.
            }
        }
    }
}

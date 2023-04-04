using System;
using System.Globalization;

namespace CsE17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 3
            int cod = 0;
            int a = 0, g = 0, d = 0;
            //ENQUANTO COD FOR DIFERENTE DE 4 EXECUTA O CODIGO - CASO SEJA 4 ELE ENCERRA
            while (cod != 4)
            {
                Console.Clear();
                Console.WriteLine("INFORME O COMBUSTÍVEL DE SUA PREFERÊNCIA:\n\n");
                Console.WriteLine("1        ÁLCOOL");
                Console.WriteLine("2        GASOLINA");
                Console.WriteLine("3        DISEL");
                Console.WriteLine("4        SAIR");
                cod = int.Parse(Console.ReadLine());
                //LIMITAÇÕES PARA O COD - SE FOR MENOR/IGUAL A ZERO OU MAIOR QUE QUATRO O COD É INVÁLIDO E PEDE NOVAMENTE
                while (cod <= 0 || cod > 4)
                {
                    Console.WriteLine("\nCódigo Inválido!\n");
                    cod = int.Parse(Console.ReadLine());
                }
                //ATRIBUI PARA A VARIÁVEL O TANTO DE VEZES QUE O TIPO FOI SELECIONADO
                if (cod == 1)
                {
                    Console.Clear();
                    Console.WriteLine("ÁLCOOL\n\nOBRIGADO.");
                    a++;
                    Console.ReadKey();
                }
                else if (cod == 2)
                {
                    Console.Clear();
                    Console.WriteLine("GASOLINA\n\nOBRIGADO.");
                    g++;
                    Console.ReadKey();
                }
                else if (cod == 3)
                {
                    Console.Clear();
                    Console.WriteLine("DISEL\n\nOBRIGADO.");
                    d++;
                    Console.ReadKey();
                }
            }
            //RETORNO DOS DADOS
            Console.Clear();
            Console.WriteLine("MUITO OBRIGADO\n");
            Console.WriteLine($"ALCOOL: {a}");
            Console.WriteLine($"GASOLINA: {g}");
            Console.WriteLine($"DISEL: {d}");
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}

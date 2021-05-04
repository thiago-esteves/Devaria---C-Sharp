using System;

namespace estruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            if (argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar palavras no argumento");
                return;
            }

            //for 
            for (var indice = 0; indice < argumentos.Length; indice++)
            {
                Console.WriteLine($"Estrutura for, indice e valor:{indice},{argumentos[indice]}");
            }
            // while
            var argumentosLidos = 0;
            while (argumentosLidos < argumentos.Length)
            {
                Console.WriteLine($"Estrutura while,argumentosLidos e valor lido:{argumentosLidos},{argumentos[argumentosLidos]}");
                argumentosLidos++;
            }
            // do while
            var loopEfetuados = 0;
            do
            {
                console.WriteLine($"Estrutura do while, loop infinito:{}")
            } while (true);

        }

    }
}
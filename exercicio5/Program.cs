using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva seu texto: ");
            string texto = Console.ReadLine();
            int numVogais = 0;

            foreach(char letra in texto)
            {
                if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    numVogais++;
                }
            }

            Console.WriteLine($"Existem {numVogais} vogais nesse texto.");
        }
    }
}

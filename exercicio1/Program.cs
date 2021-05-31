using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de andares do prédio: ");
            int andares = int.Parse(Console.ReadLine());
            int alturaPerAndar = 3;

            Console.WriteLine($"A altura do prédio é igual: {alturaPerAndar * andares} metros");
        }
    }
}

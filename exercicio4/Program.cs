using System;
using System.Linq;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 5 números: ");
            string nums = Console.ReadLine();

            var numsOrdenados = nums.OrderByDescending(p => Char.GetNumericValue(p));
            foreach(var item in numsOrdenados)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

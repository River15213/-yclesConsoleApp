using System.Numerics;

namespace MinimumNumberSequencesConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности: ");
            int inputMax = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            for (int i = 1; i < inputMax + 1; i++)
            {
                Console.WriteLine($"Введите {i} число: ");
                int inputUser = int.Parse(Console.ReadLine());

                if (inputUser < minNumber)
                {
                    minNumber = inputUser;
                }
            }
            Console.WriteLine($"Минимальное число {minNumber}");

        }
    }
}

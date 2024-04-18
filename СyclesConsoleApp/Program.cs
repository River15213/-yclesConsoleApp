namespace СyclesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int inputUser = int.Parse(Console.ReadLine());

            if (inputUser % 2 == 0) 
            {
                Console.WriteLine($"число {inputUser} => четное ");
            }
            else 
            {
                Console.WriteLine($"число {inputUser} => не четное ");
            }
        }
    }
}

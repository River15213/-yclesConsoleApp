namespace SimpleNumberConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int inputUser = int.Parse(Console.ReadLine());

            bool flag = true;
            int i = 2;

            while (i < inputUser)
            { 
                if (inputUser % i == 0)
                {
                    flag = false;
                    break;
                }
                i++;
            }

            Console.WriteLine();

            if (flag)
            {
                Console.WriteLine($"Число {inputUser} простое");
            }
            else
            {
                Console.WriteLine($"Число {inputUser} не простое");
            }
        }
    }
}

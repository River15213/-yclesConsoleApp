namespace GuessNumberConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальный диапазон");
            int maxRange = int.Parse(Console.ReadLine());

            Random random = new Random();

            int randomNumber = random.Next(0, maxRange);
            int i = 1;
            while (true)
            {
                Console.WriteLine($"Угадайте число от 0 до {maxRange}: ");
                string inputUser = Console.ReadLine();

                if (int.TryParse(inputUser, out int numberUser))
                {
                    if (numberUser > randomNumber)
                    {
                        Console.WriteLine($"Число {inputUser} меньше загаданого.");
                    }
                    else if (numberUser < randomNumber)
                    {
                        Console.WriteLine($"Число {inputUser} больше загаданого.");

                    }
                    else
                    {
                        Console.WriteLine($"Ура!! Вы угадали мое число {randomNumber} за {i} попыток");
                        break;
                    }
                }
                else if (inputUser == "")
                {
                    Console.WriteLine($"Вы не угадали число {randomNumber}");
                    break;
                }
                i++;
            }
        }
    }
}

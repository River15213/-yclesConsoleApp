namespace GameTwentyOneConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomMapNumber = rnd.Next(2,22);

            Console.WriteLine("Здравствуйте, сколько у вас карт в руке?");
            int inputMapQuantityUser = int.Parse(Console.ReadLine());
            int sumMap = 0;
            for (int i = 1; i < inputMapQuantityUser + 1; i++)
            {
                Console.WriteLine($"Введите значение {i} карты: ");
                var numberMapUser = Console.ReadLine();

                if(int.TryParse(numberMapUser, out int mapValue))
                {
                    sumMap += mapValue;
                }

                switch (numberMapUser)
                {
                    case "J":
                    case "K":
                    case "T":
                    case "Q":
                        sumMap += 10;
                        break;
                    

                }
            }
            if (sumMap > randomMapNumber && sumMap < 21)
            {
                Console.WriteLine($"Результат компьютера {randomMapNumber}");
                Console.WriteLine($"Ура!!! Вы выйграли ваш результат {sumMap}");
            }
            else
            {
                Console.WriteLine($"Результат компьютера {randomMapNumber}");
                Console.WriteLine($"Вы проиграли ваш результат {sumMap}");
            }
            
        }
    }
}

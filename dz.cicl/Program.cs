using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string playAgain;
            do
            {
                int secretNumber = random.Next(1, 101); 
                const int maxAttempts = 7;
                int attempts = 0;
                bool isGuessed = false;

                Console.WriteLine("--- Игра --- \"Угадай число\" ---");
                Console.WriteLine($"Я загадал число от 1 до 100. У вас {maxAttempts} попыток.");

                while (attempts < maxAttempts)
                {
                    attempts++;
                    Console.WriteLine($"Попытка {attempts} из {maxAttempts}. Введите ваше число:");
                    int userGuess = int.Parse(Console.ReadLine());

                    if (userGuess == secretNumber)
                    {
                        Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} с {attempts}-й попытки!");
                        isGuessed = true;
                        break;
                    }
                    else if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                }

                if (!isGuessed)
                {
                    Console.WriteLine($"К сожалению, попытки закончились. Было загадано число {secretNumber}.");
                }

                Console.WriteLine("Хотите сыграть ещё раз? (да/yes — да, любой другой ввод — выход):");
                playAgain = Console.ReadLine();
            }
            while (playAgain == "да" || playAgain == "yes");

            Console.WriteLine("Спасибо за игру! Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
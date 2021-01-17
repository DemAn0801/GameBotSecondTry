using System;

namespace GameBotSecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            // Присваиваем боту имя и запускаем приветствие
            BotOptions botOptions = new BotOptions();
            botOptions.NameOfBot = "Пэдро";
            botOptions.Greetings();

            GameProvider gameProvider = new GameProvider();
            //задаем параметры генерации случайного числа
            gameProvider.FirstValueForRandom = 1;
            gameProvider.SecondValueForRandom = 10;
            // запускаем игру
            gameProvider.TestOfAttempt();
            Console.ReadKey();
        }
    }
}

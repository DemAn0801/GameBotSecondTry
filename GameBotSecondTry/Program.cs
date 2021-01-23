using System;

namespace GameBotSecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter1 = 0;
            for (; ; )
            {
                counter1++;
            // Присваиваем боту имя и запускаем приветствие
            BotOptions botOptions = new BotOptions();
            botOptions.NameOfBot = "Пэдро";
            botOptions.Greetings();

            GameProvider gameProvider = new GameProvider();
            //задаем параметры генерации случайного числа
            gameProvider.FirstValueForRandom = botOptions.SelectFirstValueForRandomInterval();
            gameProvider.SecondValueForRandom = botOptions.SelectSecondValueForRandomInterval();
            // запускаем игру
            gameProvider.TestOfAttempt();
            Console.ReadKey();
            }
        }
    }
}

using System;

namespace GameBotSecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            BotOptions botOptions = new BotOptions();
            botOptions.NameOfBot = "Пэдро";
            botOptions.Greetings();

            GameProvider gameProvider = new GameProvider();
            gameProvider.FirstValueForRandom = 1;
            gameProvider.SecondValueForRandom = 10;
            gameProvider.TestOfAttempt();
            Console.ReadKey();
        }
    }
}

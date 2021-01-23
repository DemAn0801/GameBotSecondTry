using System;

namespace GameBotSecondTry
{
    class GameProvider
    { 
        //переменные для выбора диапозона случайных чисел
        private int firstValueForRandom;
        public int FirstValueForRandom
        {
            get { return firstValueForRandom; }
            set { firstValueForRandom = value; }
        }
        private int secondValueForRandom;
        public int SecondValueForRandom
        {
            get { return secondValueForRandom; }
            set { secondValueForRandom = value; }
        }
             // проверка совпадения введенного числа и случайно сгенерированного
        public void TestOfAttempt()
        {
            Random randomNumder = new Random();
            int rnd = randomNumder.Next(FirstValueForRandom, SecondValueForRandom);
            int count = 0;
            for (; ; )
            {
            Console.WriteLine($"Сделай попытку угадать задуманное число: {rnd}");
                count++;
            string firstAttempt = Console.ReadLine();
            int FirstAttempt = Convert.ToInt32(firstAttempt);
            if (FirstAttempt < rnd)
            {
            Console.WriteLine($"Загаданное число больше : {rnd}");
            }
            else if (FirstAttempt > rnd)
             {
            Console.WriteLine($"Загаданное число меньше: {rnd}");
            }
            else
            {
                Console.WriteLine("Угадал!");
                ReapeatGame();
            }
            }
        }
            // запрос на повтор игры в случае совпадения
            public void ReapeatGame()
        {
            Console.WriteLine("Хочешь повторить игру: Да/Нет?");
            string askOfReapeat=Console.ReadLine();
            switch (askOfReapeat)
            {
                case "Да":
                    TestOfAttempt();
                    break;
                case "Нет":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("неверный ввод");
                    ReapeatGame();
                    break;
            }
        }
    }
}

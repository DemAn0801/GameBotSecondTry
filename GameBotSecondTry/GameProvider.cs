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
        // генерация случайного числа
        public int  GenerationRandomNumber()
        {
            Random randomNumder = new Random();
            int rnd = randomNumder.Next(FirstValueForRandom, SecondValueForRandom);
            return rnd;
        }
             // проверка совпадения введенного числа и случайно сгенерированного
        public void TestOfAttempt()
        {
            Console.WriteLine($"Сделай попытку угадать задуманное число: {GenerationRandomNumber()}");
            
            string firstAttempt = Console.ReadLine();
            int FirstAttempt = Convert.ToInt32(firstAttempt);
            if (FirstAttempt == GenerationRandomNumber())
            {
            Console.WriteLine("Угадал!");
            ReapeatGame();
            }
            else
            {
            Console.WriteLine($"Не угадал, попробуй еще: {GenerationRandomNumber()}");
                TestOfAttempt();
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
            }
        }
    }
}

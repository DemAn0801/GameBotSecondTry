using System;

namespace GameBotSecondTry
{
    class BotOptions
    {
        private string name;
        public string NameOfBot
        {
            get { return name; }
            set { name = value; }
        }
        public void Greetings()
        {
            Console.WriteLine($"Привет, меня зовут {NameOfBot}!Начинаем игру! угадай число!");
        }
        public int SelectFirstValueForRandomInterval()
        {
            Console.WriteLine("Выбери диапазон чисел для случайной генерации \n Первое число:");
            string inputFirstValue = Console.ReadLine();
            int InputFirstValue = Convert.ToInt32(inputFirstValue);
            return InputFirstValue;
        }
        public int SelectSecondValueForRandomInterval()
        {
            Console.WriteLine("Выбери диапазон чисел для случайной генерации \n Второе число:");
            string inputSecondValue = Console.ReadLine();
            int InputSecondValue = Convert.ToInt32(inputSecondValue);
            return InputSecondValue;
        }
    }
}

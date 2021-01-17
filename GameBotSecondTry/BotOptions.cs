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
            Console.WriteLine($"Привет, меня зовут {NameOfBot}!Начинаем игру! угадай число от 1 до 10.");

        }
    }
}

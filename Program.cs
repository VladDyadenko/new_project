using System;

namespace project
{
    class Program
    {
        static void Main()
        { // ООП
            Robot bot = new Robot();

            // тепер можемо записувати щось та отримувати дані
            bot.Weigth = -5;
            Console.Write(bot.Weigth);

            bot.Widgth = 10;
            Console.Write(bot.Widgth);


        }



    }

}

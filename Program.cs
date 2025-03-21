using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main()
        { // ООП
            Robot bot = new("Bot");
            Killer killer = new("Killer", 3, new byte[] { 0, 0, 0 }, 10);


            // створюємо масив обєктів
            // Robot[] robots = new Robot[]{
            //     bot, killer, new Robot()
            // };
            // або так створимо

            Killer killer1 = null;

            List<Robot> robots = new List<Robot>();
            // added objects
            robots.Add(bot);
            robots.Add(killer);
            robots.Add(new Robot("Alex"));

            /* робота з as. МИ можемо створити Killer killer1 = null і при переборі колекції
            привести killer1 до значення Killer */
            foreach (Robot el in robots)
            {
                if (el.Name == "Killer")
                {
                    killer1 = el as Killer;
                    killer1.Lazer();
                }
                // is дозволяє перевірити, чи відноситься якесь значення до якогось типу

                Console.WriteLine(el is Killer);

            }



        }

    }
}
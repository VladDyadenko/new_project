using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main()
        { // ООП
            Bot bot = new("Bob", 10, new byte[] { 0, 1, 0 });

            bot.Moving(20f);

            Killer killer = new("Killer", 5, new byte[] { 0, 0, 0 }, 10);
            killer.Moving(30f);


        }



    }

}

using System;

namespace project
{
    class Program
    {
        static void Main()
        { // ООП

            Robot bot = new Robot("Bot", 3, new byte[] { 0, 0, 0 });

            Robot killer = new Robot("Killer", 5, new byte[] { 0, 1, 0 });

            Robot robot = new Robot();
            Robot robot_alex = new Robot("Alex");

            Robot.Print();
        }



    }

}

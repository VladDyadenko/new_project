using System;

namespace project;

class Bot : Robot
{
    public Bot() { }


    public Bot(string name, short weigth, byte[] coordinates) : base(name, weigth, coordinates) { }

    public override void Moving(float speed)
    {
        Console.WriteLine("Bot is moving: " + speed);
    }

}
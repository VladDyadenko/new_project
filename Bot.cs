using System;

namespace project;

// Додаємо інтерфейс до потрібного класу
// Далі додаємо в клас все, що є в інтерфейсі
class Bot : Robot, IRun
{
    public float SpeedRun { get; set; }

    public Bot() { }


    public Bot(string name, short weigth, byte[] coordinates) : base(name, weigth, coordinates) { }

    public void RobotRun()
    {
        System.Console.WriteLine("Bot is Runing: " + SpeedRun);
    }

    public override void Moving(float speed)
    {
        Console.WriteLine("Bot is moving: " + speed);
    }

}
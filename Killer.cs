using System;

namespace project;

// наслідування за використанням :
class Killer : Robot, IFly
{
    public Killer() { }


    // коли ми створюємо новий клас на основі існуючого, можемо додати йому потрібні нові поля (типу Damage)
    // а інши поля, якщо вони потрібні вибрати з головного класу. В нашому випадку там було три конструктора
    // ми вибрали з потрібними полями з Robot і через : base () - додали в наш новий клас.
    public Killer(string name, short weigth, byte[] coordinates, int damage, TypeRobot type)
    : base(name, weigth, coordinates, type)
    {
        this.Damage = damage;

    }
    public int Damage
    {
        get; private set;
    }


    /* Щоб додати функціонал в спадкоємці, викликаємо метод через ключеве слово override*/
    /* Якщо прибрати тут base.printValues() - то те що було в методі, не буде виконуватися */
    public override void printValues()
    {
        base.printValues();
        Console.WriteLine("Damage: " + Damage);
    }

    public void Lazer()
    {
        Console.Write("Laser is shooting");
    }

    public override void Moving(float speed)
    {
        Console.WriteLine("Killer is Jumping: " + speed);
    }

    public void RobotFly(int maxHeigth) { }

}
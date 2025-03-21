using System;

namespace project;

// наслідування за використанням :
class Killer : Robot
{
    public Killer() { }


    // коли ми створюємо новий клас на основі існуючого, можемо додати йому потрібні нові поля (типу Damage)
    // а інши поля, якщо вони потрібні вибрати з головного класу. В нашому випадку там було три конструктора
    // ми вибрали з потрібними полями з Robot і через : base () - додали в наш новий клас.
    public Killer(string name, short weigth, byte[] coordinates, int damage) : base(name, weigth, coordinates)
    {
        this.Damage = damage;

    }
    public int Damage
    {
        get; private set;
    }

    public void Lazer()
    {
        Console.Write("Laser is shooting");
    }

}
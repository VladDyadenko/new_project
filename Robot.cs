using System;

namespace project;

abstract class Robot
{
    //protected дає можливість використовувати поля та методи тільки в головному та спадкоємцях
    protected string name;
    protected short weigth;
    protected byte[] coordinates;

    public string Name
    {
        get
        {
            return name;
        }
        private set { }
    }

    // акцесори
    // неявно прописуємо методи
    // якщо всановити приватність, то акцесор неможна буде використати за межами класу
    public int Widgth { get; set; }
    // явно вказуємо і можемо щось тут робити
    public short Weigth
    {
        get
        {
            Console.WriteLine("Result: ");
            return this.weigth;
        }
        set
        {
            if (value < 1) weigth = 0;
            else
                this.weigth = value;
        }
    }

    // static належить до всього класу, воно визивається через Robot.count
    //звернутися через bot.count ore killer.count, тобто через екземпляр, не можливо
    public static int count = 0;

    // Можна створити скільки завгодно конструкторів
    // таким чином будуть різні варіанти створення екземплярів
    public Robot()
    {
        count++;
    }

    public Robot(string _name)
    {
        name = _name;
        count++;
    }

    public Robot(string _name, short _weigth, byte[] _coordinates)
    {
        this.setValues(_name, _weigth, _coordinates);
        // this.printValues();
        count++;

    }

    /* Створюємо абстрактний метод. Він потрібен, якщо ми розуміємо, що щось треба буде робити
    в спадкоємцях, але точно не знаєте як. Тоді прописуємо цей метод і у всіх спадкоємцях
    буде світитись помилк-нагадування, що його потрібно прописати в них */
    public abstract void Moving(float speed);

    public void setValues(string name, short weigth, byte[] coordinates)
    {
        this.name = name;
        this.weigth = weigth;
        this.coordinates = coordinates;
    }

    // ключове слово virtual дозволяє додавати функціонал в спадкоємцях
    public virtual void printValues()
    {
        Console.WriteLine(this.name + ", weigth: " + this.weigth + ", coordinates: ");
        foreach (byte el in this.coordinates)

            Console.Write(el + " - ");
        Console.WriteLine("");

    }

    public static void Print()
    {
        // в статичних методах this не може бути використано, бо ці методи 
        // відносяться до всього класу
        Console.WriteLine("Count: " + count);
    }


}
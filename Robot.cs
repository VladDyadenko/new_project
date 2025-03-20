using System;

namespace project;

class Robot
{
    private string name;
    private short weigth;
    private byte[] coordinates;

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
        this.printValues();
        count++;

    }

    public void setValues(string name, short weigth, byte[] coordinates)
    {
        this.name = name;
        this.weigth = weigth;
        this.coordinates = coordinates;
    }
    public void printValues()
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
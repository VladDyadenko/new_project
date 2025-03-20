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
        setValues(_name, _weigth, _coordinates);
        printValues();
        count++;

    }

    public void setValues(string _name, short _weigth, byte[] _coordinates)
    {
        name = _name;
        weigth = _weigth;
        coordinates = _coordinates;
    }
    public void printValues()
    {
        Console.WriteLine(name + ", weigth: " + weigth + ", coordinates: ");
        foreach (byte el in coordinates)

            Console.Write(el + " - ");
        Console.WriteLine("");

    }

    public static void Print()
    {
        Console.WriteLine("Count: " + count);
    }


}
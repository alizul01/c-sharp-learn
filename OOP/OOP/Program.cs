using OOP;
using System;

class Program
{
    public static void Main(String[] args)
    {
        Human human = new("Ali", 20);
        Car car = new Car("Red", "Avanza");

        List<String> list = new List<string>();

        list.Add("Ali");

        // print all list
        list.ForEach(Console.WriteLine);

        Console.WriteLine(human.age);
        Console.WriteLine(car.color);
    }

    public static void DisplayElements<T>(T[] array)
    {
        foreach (T element in array)
        {
            Console.WriteLine(element);
        }
    }
}
namespace App;

using System;
using App.Space;

class Program
{
    static void Main(string[] args)
    {
        int numberOfAstres = 5;
        Universe universe = new Universe();
        for (int i = 0; i < numberOfAstres; i++)
        {
            universe.AddAstre(Galaxy.CreateRandom());
        }
        Console.WriteLine(universe.ToString());
    }

    static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    static void WhatIsYourName()
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
}




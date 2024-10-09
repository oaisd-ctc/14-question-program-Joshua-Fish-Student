using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();
        Console.WriteLine("What is your hair color?");
        string hairColor = Console.ReadLine();
        Console.WriteLine("What is your shoe size?");
        int shoeSize = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your favorite color?");
        string favColor = Console.ReadLine();
        Console.WriteLine("What is your favorite tv show or movie?");
        string favTVOrMovie = Console.ReadLine();
        Console.WriteLine("What is your favorite teacher?");
        string favTeach = Console.ReadLine();
        Console.WriteLine("What is your favorite class?");
        string favClass = Console.ReadLine();
        Console.WriteLine("What is your favorite holiday?");
        string favHoliday = Console.ReadLine();
        Console.WriteLine("What is your favorite season?");
        string favSeason = Console.ReadLine();
        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine();
        Console.WriteLine("How many siblings do you have?");
        int numSiblings = int.Parse(Console.ReadLine());
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + ". " + name + "'s hair color is " + hairColor + ". " + name + "'s shoe size is " + shoeSize + ". " + name + "'s favorite color is " + favColor + ". " + name + "'s favorite tv show or movie is " + favTVOrMovie + ". " + name + "'s favorite teacher is " + favTeach + ". " + name + "'s favorite class is " + favClass + ". " + name + "'s favorite holiday is " + favHoliday + ". " + name + "'s favorite season is " + favSeason + ". " + name + "'s dream job is " + dreamJob + ". " + name + " will be " + (age + 5) + " in 5 years. " + name + " has " + numSiblings + " siblings.");
    }
}

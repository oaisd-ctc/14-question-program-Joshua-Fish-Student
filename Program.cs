using System;


public class Program
{
    public static string name;
    public static string age;
    public static string eyeColor;
    public static string hairColor;
    public static string shoeSize;
    public static string favoriteColor;
    public static string favoriteTVorMovie;
    public static string favoriteTeacher;
    public static string favoriteClass;
    public static string favoriteHoliday;
    public static string favoriteSeason;
    public static string dreamJob;
    public static string numberOfSiblings;
    public static int ageIn5Years;
    public static void AskName(){
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }
    public static void AskAge(){
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();
    }
    public static void AskEyeColor(){
        Console.WriteLine("What is your eye color?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor(){
        Console.WriteLine("What is your hair color?");
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize(){
        Console.WriteLine("What is your shoe size?");
        shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor(){
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow(){
        Console.WriteLine("What is your favorite tv show or movie?");
        favoriteTVorMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher(){
        Console.WriteLine("What is your favorite teacher?");
        favoriteTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass(){
        Console.WriteLine("What is your favorite class?");
        favoriteClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday(){
        Console.WriteLine("What is your favorite holiday?");
        favoriteHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason(){
        Console.WriteLine("What is your favorite season?");
        favoriteSeason = Console.ReadLine();
    }
    public static void AskDreamJob(){
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years(string age){
        ageIn5Years = int.Parse(age) + 5;
    }
    public static void AskNumberOfSiblings(){
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine();
    }
    public static void DisplaySummaryMessage(){
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + ". " + name + "'s hair color is " + hairColor + ". " + name + "'s shoe size is " + shoeSize + ". " + name + "'s favorite color is " + favoriteColor + ". " + name + "'s favorite tv show or movie is " + favoriteTVorMovie + ". " + name + "'s favorite teacher is " + favoriteTeacher + ". " + name + "'s favorite class is " + favoriteClass + ". " + name + "'s favorite holiday is " + favoriteHoliday + ". " + name + "'s favorite season is " + favoriteSeason + ". " + name + "'s dream job is " + dreamJob + ". " + name + " will be " + ageIn5Years + " in 5 years. " + name + " has " + numberOfSiblings + " siblings.");
    }
    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        AskNumberOfSiblings();
        CalculateAgeIn5Years(age);
        DisplaySummaryMessage();
    }
}

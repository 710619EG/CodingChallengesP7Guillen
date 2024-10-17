using System;
using System.Runtime.CompilerServices;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pick a number, any number!");
        var input4 = Console.ReadLine();
        int numberToAddTo = int.Parse(input4);
        numberToAddTo = PlusOne(numberToAddTo);
        Console.WriteLine($"Your new number is  {numberToAddTo}");
        Console.WriteLine("What is the voltage of the circuit?");
        var input5 = Console.ReadLine();
        int numberToUse5 = int.Parse(input5);
        Console.WriteLine("And the current?");
        var input6 = Console.ReadLine();
        int numberToUse6 = int.Parse(input6);
        Console.WriteLine("The Circuit Power is " + MultiplyTwoInts(numberToUse5, numberToUse6));
        Console.WriteLine("How many years have you lived?");
        var input7 = Console.ReadLine();
        int numberToUse7 = int.Parse(input7);
        Console.WriteLine("Cool, that means you have lived for " + CalAgeInDays(numberToUse7));
        Console.WriteLine("Now let's calculate the area");
        Console.WriteLine("What is the base measurment of the triangle?");
        var input8 = Console.ReadLine();
        float numberToUse8 = float.Parse(input8);
        Console.WriteLine("And the height measurment");
        var input9 = Console.ReadLine();
        float numberToUse9 = float.Parse(input9);
        Console.WriteLine("The area of the triangle is " + CalTriArea(numberToUse8, numberToUse9));
        Console.WriteLine("Give me a number");
        var input10 = Console.ReadLine();
        int numberToUse10 = int.Parse(input10);
        Console.WriteLine($"Your number is less than or equal to 0." + LessThanOrEqualToZero(numberToUse10));
    }
    public static int PlusOne(int numberToAddTo)
    {
        return numberToAddTo + 1;
    }
    public static int MultiplyTwoInts(int numberToUse5, int numberToUse6)
    {
        return (numberToUse5 * numberToUse6);
    }
    public static int CalAgeInDays(int numberToUse7)
    {
        return numberToUse7 * 365;
    }
    public static float CalTriArea(float numberToUse8, float numberToUse9)
    {
        return (numberToUse8 * numberToUse9) / 2;
    }
    public static bool LessThanOrEqualToZero(int numberToUse10)
    {
        return numberToUse10 <= 0;
    }
}
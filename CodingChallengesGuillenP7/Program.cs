﻿using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Ellis's Coding Challanges Project! Type which challange you wish to run.\nAvailable challenges:");
        Console.WriteLine("Challenge 1\nChallenge 2\nChallenge 3\nChallenge 4\nChallenge 5\nChallenge 6\nChallenge 7\nChallenge 8\nChallenge 9\nChallenge 10\nChallenge 11\nChallenge 12\nChallenge 13");
        Console.WriteLine("");
        string selected = Console.ReadLine();
        string[] acceptedChallenge1Inputs = {"challenge 1", "chall 1", "chalenge 1", "chal 1", "challenge1", "chall1", "chalenge1", "chal1"};
        switch (selected)
        {
            case "Challenge 1":
                Challenge1();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 2":
                Challenge2();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 3":
                Challenge3();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 4":
                Challenge4();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 5":
                Challenge5();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 6":
                Challenge6();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 7":
                Challenge7();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 8":
                Challenge8();
                Console.WriteLine("\nEnd of program");
                break;
            case "":
                Console.WriteLine("No input detected! Restart the program to retry.");
                Console.WriteLine("\nEnd of program");
                break;
            default:
                Console.WriteLine("Invalid string detected. You either made a typo or you input the name of a challenge/function/method that does not exist.");
                Console.WriteLine("\nEnd of program");
                break;
        }

    }
    public static void Challenge1()
    {
        Console.WriteLine("Give me the 2 numbers to add. \nFirst number:");
        var input1 = Console.ReadLine();
        Console.WriteLine("Second number:");
        var input2 = Console.ReadLine();
        int num1 = int.Parse(input1);
        int num2 = int.Parse(input2);
        Console.WriteLine("Your numbers have a combined value of " + Sum(num1, num2));
        static int Sum(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
    public static void Challenge2()
    {
        Console.WriteLine("Give me the amount of minutes, I will tell you how long it is in seconds.");
        var input3 = Console.ReadLine();
        int numToUse3 = int.Parse(input3);
        Console.WriteLine(input3 + $" minutes is {Convert2Sec(numToUse3)} seconds");
        static int Convert2Sec(int numToUse3)
        {
           return numToUse3 * 60;
        }
    }
    public static void Challenge3()
    {
        Console.WriteLine("Pick a number, any number!");
        var input4 = Console.ReadLine();
        int numberToAddTo = int.Parse(input4);
        numberToAddTo = PlusOne(numberToAddTo);
        Console.WriteLine($"Your new number is  {numberToAddTo}");
        static int PlusOne(int numberToAddTo)
        {
            return numberToAddTo + 1;
        }
    }
    public static void Challenge4()
    {
        Console.WriteLine("What is the voltage of the circuit?");
        var input5 = Console.ReadLine();
        int numberToUse5 = int.Parse(input5);
        Console.WriteLine("And the current?");
        var input6 = Console.ReadLine();
        int numberToUse6 = int.Parse(input6);
        Console.WriteLine("The Circuit Power is " + CircutPower(numberToUse5, numberToUse6));
        static int CircutPower(int numberToUse5, int numberToUse6)
        {
            return (numberToUse5 * numberToUse6);
        }
    }
    public static void Challenge5()
    {
        Console.WriteLine("How many years have you lived?");
        var input7 = Console.ReadLine();
        int numberToUse7 = int.Parse(input7);
        Console.WriteLine("Cool, that means you have lived for " + CalYearsToDays(numberToUse7) + " days");
        static int CalYearsToDays(int numberToUse7)
        {
            return numberToUse7 * 365;
        }
    }
    public static void Challenge6()
    {
        Console.WriteLine("Now let's calculate the area of a right triangle");
        Console.WriteLine("What is the base measurment of the triangle?");
        var input8 = Console.ReadLine();
        float numberToUse8 = float.Parse(input8);
        Console.WriteLine("And the height measurment");
        var input9 = Console.ReadLine();
        float numberToUse9 = float.Parse(input9);
        Console.WriteLine("The area of the triangle is " + CalTriArea(numberToUse8, numberToUse9));
        static float CalTriArea(float numberToUse8, float numberToUse9)
        {
            return (numberToUse8 * numberToUse9) / 2;
        }
    }
    public static void Challenge7()
    {
        Console.WriteLine("Give me a number");
        var input10 = Console.ReadLine();
        int numberToUse10 = int.Parse(input10);
        Console.WriteLine($"Your number is less than or equal to 0. That statement is " + LessThanOrEqualToZero(numberToUse10));
        static bool LessThanOrEqualToZero(int numberToUse10)
        {
        return numberToUse10 <= 0;
        }
    }
    public static void Challenge8()
    {
        Console.WriteLine("");
    }
}
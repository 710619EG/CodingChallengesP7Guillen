using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Challenges
{
    public static void Main(string[] args)
    {
    restart:
        Console.WriteLine("\nWelcome to Ellis's Coding Challanges Project! Type which challange you wish to run.\nAvailable challenges:");
        Console.WriteLine("Challenge 1\nChallenge 2\nChallenge 3\nChallenge 4\nChallenge 5\nChallenge 6\nChallenge 7\nChallenge 8\nChallenge 9   (incomplete)\nChallenge 10  (incomplete)\nChallenge 11  (incomplete)\nChallenge 12  (incomplete)\nChallenge 13  (incomplete)\nChallenge 14  (incomplete)\nChallenge 15  (not available)\nChallenge 16  (not available)\nChallenge 17  (not available)\nChallenge 18\nChallenge 19  (not available)\nChallenge 20  (not available)\nChallenge 21\nChallenge 21\nChallenge 23\nChallenge 24\nChallenge 25");
        Console.WriteLine("");
    bonus:
        string challenge = Console.ReadLine();

        string[] acceptedChallenge1Inputs = { "challenge 1", "chall 1", "chalenge 1", "chal 1", "challenge1", "chall1", "chalenge1", "chal1" };

        void SpellCheck()
        {

            foreach (string i in acceptedChallenge1Inputs)
            {

                if (challenge == i)
                {
                    challenge = "Challenge 1";
                }
            }
        }
        SpellCheck();

        switch (challenge)
        {
            case "Challenge 1":
                Challenge1();
                goto restart;
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
            case "Challenge 9":
                Challenge9();

                goto restart;
            case "Challenge 10":
                Challenge10();

                goto restart;
            case "Challenge 11":
                Challenge11();

                goto restart;
            case "Challenge 12":
                Challenge13();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 13":
                Challenge14();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 14":
                Challenge15();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 18":
                Challenge18();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 21":
                Challenge21();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 22":
                Challenge22();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 23":
                Challenge23();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 24":
                Challenge24();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 25":
                Challenge25();
                Console.WriteLine("\nEnd of program");
                break;
            case "Challenge 26":
                Challenge26();
                Console.WriteLine("\nEnd of program");
                goto restart;
            case "BONUS Challenge 1":
                BONUS_Challenge1();
                Console.WriteLine("\nEnd of program");
                break;
            case "BONUS":
                Console.WriteLine("\nBONUS Challenge 1");
                goto bonus;
            case "EXIT":
                Console.WriteLine("Are you sure you want to end the program?");
                string endOrNoEnd = Console.ReadLine();
                switch (endOrNoEnd)
                {
                    case "Yes":
                        break;
                    case "No":
                        goto restart;
                }
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
        Console.WriteLine("Input a number");
        var input1 = Console.ReadLine();
        int intToUse1 = int.Parse(input1);
        Console.WriteLine("Input another number");
        var input2 = Console.ReadLine();
        int intToUse2 = int.Parse(input2);
        static bool LessThan100(int intToUse1, int intToUse2)
        {
            if ((intToUse1 + intToUse2) < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        Console.WriteLine("Sum is less than 100: " + LessThan100(intToUse1, intToUse2));
    }
    public static void Challenge9()
    {
        Console.WriteLine("Work in progress!");

    }
    public static void Challenge10()
    {
        Console.WriteLine("Doesn't exist");
    }
    public static void Challenge11()
    {
        Console.WriteLine();
    }
    public static void Challenge12()
    {
        Console.WriteLine();
    }
    public static void Challenge13()
    {
        Console.WriteLine();
    }
    public static void Challenge14()
    {
        Console.WriteLine();
    }
    public static void Challenge15()
    {
        Console.WriteLine();
    }
    public static void Challenge18()
    {
        Console.WriteLine("What is you name?");
        string userName = Console.ReadLine();
        static string HelloName(string userName)
        {
            return "Hello " + userName;
        }
        Console.WriteLine(HelloName(userName));
    }
    public static void Challenge21()
    {
        Console.WriteLine("Input a number (1-12)");
    redo:
        var input21a = Console.ReadLine();
        int number21a = int.Parse(input21a);
        if (number21a < 1)
        {
            Console.WriteLine("Invalid, try again");
            goto redo;
        }
        else if (number21a > 12)
        {
            Console.WriteLine("Invalid, try again");
            goto redo;
        }
        else
        {
            switch (number21a)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:

                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }
        }
    }

    public static void Challenge22()
    {
        Console.WriteLine("How many elements are in your array of numbers?");
        string lengthNum = Console.ReadLine();
        int length = int.Parse(lengthNum);
        int[] numbers = new int[length];
        Console.WriteLine("Now input the value of each element");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Element " + (i + 1) + ": ");
            var valueInput = Console.ReadLine();
            int value = int.Parse(valueInput);
            numbers[i] = value;
        } 

        Console.WriteLine("\n Here are the minimum and maximum numbers\n");
        Console.WriteLine("Min: " + numbers.Min());
        Console.WriteLine("Max: " + numbers.Max());

    }

    public static void BONUS_Challenge1()
    {
        Console.WriteLine("How many elements are in your array of numbers?");
        string lengthNum = Console.ReadLine();
        int length = int.Parse(lengthNum);
        int[] numbers = new int[length];
        Console.WriteLine("Now input the value of each element");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Element " + (i + 1) + " ");
            var valueInput = Console.ReadLine();
            int value = int.Parse(valueInput);
            numbers[i] = value;
        }
        Console.WriteLine("\nNow to sort the elements from least to greatest value");
        Array.Sort(numbers);
        foreach (int i in numbers)
        {
            Console.Write(i +", ");
        }
        Console.WriteLine("\n");
    }
    public static void Challenge23()
    {
        Console.WriteLine("How many numbers are in your array?");
        string lengthNum = Console.ReadLine();
        int length = int.Parse(lengthNum);
        int[] numbers = new int[length];
        Console.WriteLine("Now input the numbers.");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element " + (i + 1) + " ");
            var valueInput = Console.ReadLine();
            int value = int.Parse(valueInput);
            numbers[i] = value;
        }
        Console.WriteLine("\nTime to find the sum of the absolute value.\n");
        int sum = 0;
        foreach (int i in numbers)
        {
            int add = Math.Abs(i);
            sum += add;
        }
        Console.WriteLine(sum);


    }
    public static void Challenge24()
    {
        Console.WriteLine("Calculating exponents:\n\n");
        Console.WriteLine("Input the base:");
        var baseInput = Console.ReadLine();
        float baseNumber = float.Parse(baseInput);
        Console.WriteLine("Input the exponent:");
        var expoInput = Console.ReadLine();
        float expoNumber = float.Parse(expoInput);
        float result = (float)Math.Pow(baseNumber, expoNumber);
        Console.WriteLine(result);
    }
    public static void Challenge25()
    {
        Console.WriteLine("How many elements are in your array of numbers?");
        string lengthNum = Console.ReadLine();
        int length = int.Parse(lengthNum);
        int[] numbers = new int[length];
        Console.WriteLine("Now input the value of each element");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Element " + (i + 1) + " ");
            var valueInput = Console.ReadLine();
            int value = int.Parse(valueInput);
            numbers[i] = value;
        }
        Console.WriteLine("\nNow to multiply all of the values in this array by the amount of values in the given array");
        foreach (int i in numbers)
        {
            Console.Write((i * length) + ", ");
        }
        Console.WriteLine("\n");
    }

    public static void Challenge26()
    {
        Console.WriteLine("Today we are finding the hamming distance between two strings");
        Console.Write("String 1: ");
        string[] one = Console.ReadLine();
        Console.Write("String 2: ");
        string[] two = Console.ReadLine();
        int a = 0;
        int b = 0;
        var hammingDistance = 0;
        if (one.Length == two.Length)
        {
            for (int i = 0; i < one.Length; i++, a = b = b + 1)
            {

                if (one[a] == two[b])
                {
                    hammingDistance = hammingDistance + 1;
                }
              
            }
           
        }        
        Console.WriteLine(hammingDistance);
    }

}
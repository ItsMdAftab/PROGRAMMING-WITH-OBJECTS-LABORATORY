/* #1.1 distance calculator 
 using System;
class Program
{
    static void Main()
    {
        double speed, time, distance;

        Console.Write("Enter speed (in meters per second): ");
        speed = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (in seconds): ");
        time = Convert.ToDouble(Console.ReadLine());

        distance = speed * time;

        Console.WriteLine("Distance traveled: " + distance + " meters");
    }
}
*/
/*
 * 1.2 Finding CubeRoot
using System;
class Program
{
    static void Main()
    {
        double number, cubroot;
        Console.WriteLine("Enter The Number : ");
         number =Convert.ToDouble( Console.ReadLine());
         cubroot=Math.Cbrt(number);
        Console.WriteLine($"The cube root of {number} is : {cubroot}");
    }
}
*/
/*
 * 1.4 random number genrator 
 * 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of random numbers to generate:");
        int count=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the minimum value of the range: ");
        int minvalue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the maximum value");
        int maxvalue = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        Console.WriteLine("Generated random numbers:");
        for (int i=0; i < count; i++)
        {
            int randomNumber = random.Next(minvalue, maxvalue + 1);
             Console.WriteLine(randomNumber);
        }
    }
}
*/
/*
 * #1.5 nullable
using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;
        bool? nullableBool = null;
        if (nullableInt== null){
            Console.WriteLine("nullableInt is null");
        }
        else
        {
            Console.WriteLine($"nullableInt has a value:{nullableInt}");

        }
        if (nullableDouble.HasValue)
        {
            Console.WriteLine($"nullableDoulbe has a value {nullableDouble}");
        }
        else
        {
            Console.WriteLine("nullable Double is null ");
        }
        bool nullornot = nullableBool ?? false{

        }
        if (nullableBool.HasValue)
        {
            Console.WriteLine($"nullableBool has a value: {nullableBool}");

        }
        else
        {
            Console.WriteLine("nullableBool is null");
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        int num1 = 12; // Example value
        int num2 = 25; // Example value

        Console.WriteLine("\nBitwise Operations:");
        Console.WriteLine($"{num1} & {num2} = {BitwiseAND(num1, num2)}"); // AND
        Console.WriteLine($"{num1} | {num2} = {BitwiseOR(num1, num2)}"); // OR
        Console.WriteLine($"{num1} ^ {num2} = {BitwiseXOR(num1, num2)}"); // XOR

        Console.WriteLine($"~{num1} = {BitwiseNOT(num1)}"); // NOT for first number
        Console.WriteLine($"~{num2} = {BitwiseNOT(num2)}"); // NOT for second number

        Console.WriteLine($"{num1} << 1 = {LeftShift(num1, 1)}"); // Left shift num1 by 1
        Console.WriteLine($"{num2} << 1 = {LeftShift(num2, 1)}"); // Left shift num2 by 1

        Console.WriteLine($"{num1} >> 1 = {RightShift(num1, 1)}"); // Right shift num1 by 1
        Console.WriteLine($"{num2} >> 1 = {RightShift(num2, 1)}"); // Right shift num2 by 1
    }

    static int BitwiseAND(int a, int b) => a & b;
    static int BitwiseOR(int a, int b) => a | b;
    static int BitwiseXOR(int a, int b) => a ^ b;
    static int BitwiseNOT(int a) => ~a;
    static int LeftShift(int a, int b) => a << b;
    static int RightShift(int a, int b) => a >> b;
}
*/
using System;
class Program
{
    static void Main()
    {
        double result1 = Math.Pow(double.PositiveInfinity, 2);
        Console.WriteLine($"Number1:{result1}");

        double result2 = Math.Pow(double.NegativeInfinity, 2);
        Console.WriteLine($"Number2:{result2}");

        double result3 = Math.Pow(double.MinValue, 0);
        Console.WriteLine($"Number3: {result3}");

        double result4 = Math.Pow(double.NaN, 2);
        Console.WriteLine($"Number4:{result4}");

        double result5 = Math.Pow(0, 0);
        Console.WriteLine($"Number 5 : {result5}");

        double result6 =Math.Pow(10, -1);
        Console.WriteLine($"Number 6 : {result6}");

        double result7 = Math.Pow(1, double.MaxValue);
        Console.WriteLine($"Number7: {result7}");



    }
}




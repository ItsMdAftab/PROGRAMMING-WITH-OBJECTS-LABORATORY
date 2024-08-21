/* #1. distance calculator 
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



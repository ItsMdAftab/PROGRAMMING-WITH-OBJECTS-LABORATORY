/*1.1 Arrow Pattern
using System;
using System.Collections.Generic;
//using System.Collections.Generic; brings in helpful tools for managing groups of items, like lists.
//It makes your code shorter and easier to write by letting you use things like List<string> directly.
//In your arrow example, it helps store all the parts of the arrow in an easy-to-use list.
class ArrowPattern
{
    public static List<string>Arrow(int num)//Return Type: List<string> is the type of value that the method will return. In this case, the method returns a list of strings. Each string in the list will represent one line of the arrow pattern.
    {
        List<string> pattern = new List<string>();
        for (int i =1; i <=num; i++)
        {
            pattern.Add(new string('>', i));
        }
        for (int i = num; i>0; i--)
        {
            pattern.Add(new string('>', i));
        }
        return pattern;
    }
    public static void Main()
    {
        Console.WriteLine("Enter the Num value : ");
        int n = int.Parse(Console.ReadLine());
        List<string> result3 = Arrow(n);
        Console.WriteLine("Arrow"+"("+n+")");
        foreach (var line in result3) 
        {
            Console.WriteLine(line);
        }
        
        


    }
}
*/
/*
 2.2 Workint9t017
class Workin9to5
{
    public static string OverTime(double start, double end, double hourlyRate, double overtimeMultiplier)
    {
        double regularStart = 9.0;
        double regularEnd = 17.0;

        double regularHours = 0;
        double overtimeHours = 0;

        if (start < regularEnd)
        {
            double endRegular = Math.Min(end, regularEnd);
            if (endRegular > start)
            {
                regularHours = endRegular - start;
            }
        }

        if (end > regularEnd)
        {
            overtimeHours = end - regularEnd;
        }

        double regularEarnings = regularHours * hourlyRate;
        double overtimeEarnings = overtimeHours * hourlyRate * overtimeMultiplier;

        double totalEarnings = regularEarnings + overtimeEarnings;
        return $"${totalEarnings:F2}";
    }

    public static void Main()
    {
        Console.Write("Enter start time: ");
        double start = double.Parse(Console.ReadLine());
        Console.Write("Enter end time: ");
        double end = double.Parse(Console.ReadLine());

        if (start >= end)
        {
            Console.WriteLine("End time must be after start time.");
            return;
        }

        Console.Write("Enter hourly rate: ");
        double hourlyRate = double.Parse(Console.ReadLine());
        Console.Write("Enter overtime multiplier: ");
        double overtimeMultiplier = double.Parse(Console.ReadLine());

        Console.WriteLine(OverTime(start, end, hourlyRate, overtimeMultiplier));



    }
       
    }
*/


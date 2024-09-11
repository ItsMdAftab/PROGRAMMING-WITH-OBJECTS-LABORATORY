using System;
using System.Data.SqlTypes;
class Program
{
    public static void Main() 
    {
        string s1 = Console.ReadLine();
        string [] s2 = s1.Split(' ');
        int n = s2.Length; 
        for(int i = 0; i < n; i++)
        {
            if (s2[i] == "Nemo")
            {
                Console.WriteLine($"I found Nemo at {i + 1}");
            }
            
           

        }

    }
}

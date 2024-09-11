using System;
class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        String[] s1 = s.Split(',');
        int x = 0;
        int y = 0;
        foreach (string s2 in s1)
        {
            String[] s3 = s2.Split(' ');
            string part = s3[0];
            int value=int.Parse(s3[1]);
            
            
            switch (part.ToLower())
            {
                case "right":
                    x += value;
                    break;
                case "left":
                    x -= value;
                    break;
                case "up":
                    y += value;
                    break;
                case "down":
                    y -= value;
                    break;

            }

        }
        Console.WriteLine($"Final coordinates:({x},{y})");


    }




}

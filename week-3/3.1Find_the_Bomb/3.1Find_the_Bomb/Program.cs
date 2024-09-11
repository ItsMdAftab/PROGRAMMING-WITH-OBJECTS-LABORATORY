using System; 
class Program 
{
    public static void Main()
    {
        Console.WriteLine("Enter the String : ");
        string s1 = Console.ReadLine();
        string k = bomb(s1);
        Console.WriteLine(k); 

    }
    static string bomb(String s)
    {
        if (s.ToLower().Contains("bomb"))
        {
            return "Duck!!!";

            
        }
        else
        {
            return "There is no bomb , relax.";
        }

    }
}

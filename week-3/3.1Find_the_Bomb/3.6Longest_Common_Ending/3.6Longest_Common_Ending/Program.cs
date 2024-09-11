using System; 
class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        String[] s1 = s.ToLower().Split(',');
        string part=s1[0];
        string part1=s1[1];
        int minlength=Math.Min(part.Length, part1.Length);
        string commonending = "";
        for (int i = 1; i <=minlength; i++)
        {
            if (part[part.Length - i] == part1[part1.Length-i])
            {
                commonending += part[part.Length-i];
            }
            else
            {
                break;
            }

        }
        Console.WriteLine(commonending);
    }
}
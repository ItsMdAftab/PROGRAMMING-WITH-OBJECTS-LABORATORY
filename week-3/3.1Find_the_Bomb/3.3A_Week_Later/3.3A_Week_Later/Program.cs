using System; 
class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        String[] s1 = s.Split('/');
        int n = int.Parse(s1[0]);
        Console.WriteLine($"{n + 7}/{s1[1]}/{s1[2]}");
    }
}
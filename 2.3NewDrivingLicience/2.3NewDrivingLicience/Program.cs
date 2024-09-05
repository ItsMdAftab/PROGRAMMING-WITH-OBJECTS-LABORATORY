using System;

public class Program
{
    public static int License(string me, int agents, string others)
    {
        string[] names = others.Split(' ');
        string[] allNames = new string[names.Length + 1];
        Array.Copy(names, allNames, names.Length);
        allNames[names.Length] = me;
        Array.Sort(allNames);

        int position = Array.IndexOf(allNames, me);

        int peopleBeforeMe = position;


        int groupNumber = (peopleBeforeMe / agents) + 1;
        int timeToProcess = groupNumber * 20;

        return timeToProcess;
    }

    public static void Main()
    {
        Console.WriteLine(License("Eric", 2, "Adam Caroline Rebecca Frank"));
        Console.WriteLine(License("Aaron", 3, "Jane Max Olivia Sam"));
    }
}

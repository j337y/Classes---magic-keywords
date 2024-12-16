
using System;

internal class Program
{
    static void Main(string[] args)
    {
        PodKlasa podklasa = new PodKlasa();

        Console.WriteLine(podklasa.GetString());

        Console.ReadKey();
    }
}

public class PodKlasa : NadKlasa
{
    public string GetString()
    {
        return this.String;
    }
}

public class NadKlasa
{
    protected string String = "Ja sam zasticeni string!";
}



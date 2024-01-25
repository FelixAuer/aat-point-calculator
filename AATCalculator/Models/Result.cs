namespace AATCalculator.Models;

public class Result
{
    public const string DNF = "DNF";

    public string Name { get; set; }
    public string PdgaNumber { get; set; }
    public int Place { get; set; }
    public string Total { get; set; }

    public int Points { get; set; }

    public void Print()
    {
        Console.WriteLine(Place + " " + Name + " " + Total + " Points: " + Points);
    }
}
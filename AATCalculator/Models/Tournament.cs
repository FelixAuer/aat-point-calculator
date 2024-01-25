using AATCalculator.Calculators;

namespace AATCalculator.Models;

public class Tournament
{
    public string Name { get; set; }
    public List<Division> Divisions { get; set; }

    public void Print()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine(Name);
        Console.WriteLine("-------------------");
        foreach (var division in Divisions)
        {
            division.Print();
        }
    }

    public void CalculatePoints(IPointCalculator pointCalculator)
    {
        foreach (var division in Divisions)
        {
            division.CalculatePoints(pointCalculator);
        }
    }
}
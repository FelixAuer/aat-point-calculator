using AATCalculator.Calculators;

namespace AATCalculator.Models;

public class Division
{
    public string Name { get; set; }
    public List<Result> Results { get; set; }

    public void Print()
    {
        Console.WriteLine(Name);
        foreach (var placement in Results)
        {
            placement.Print();
        }
    }

    public void CalculatePoints(IPointCalculator pointCalculator)
    {
        foreach (var result in Results)
        {
            if (result.Total == Result.DNF)
            {
                result.Points = 0;
                return;
            }

            result.Points = pointCalculator.CalculatePoints(result, this);
        }
    }
}
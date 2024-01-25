using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class BeatenPlayersCalculator : IPointCalculator
{
    public int CalculatePoints(Result result, Division division)
    {
        return division.Results.Count - (result.Place - 1);
    }
}
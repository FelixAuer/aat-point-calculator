using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class Top10PlusCalculator : IPointCalculator
{
    private readonly IPointCalculator otherCalculator;

    public Top10PlusCalculator(IPointCalculator otherCalculator)
    {
        this.otherCalculator = otherCalculator;
    }

    public int CalculatePoints(Result result, Division division)
    {
        var points = otherCalculator.CalculatePoints(result, division);
        if (result.Place <= 10)
        {
            points += 50 - (result.Place - 1) * 5;
        }

        return points;
    }
}
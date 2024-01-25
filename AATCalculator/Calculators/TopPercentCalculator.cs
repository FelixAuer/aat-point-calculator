using System.Diagnostics;
using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class TopPercentCalculator : IPointCalculator
{
    private readonly float _topPercentage;

    public TopPercentCalculator(float topPercentage)
    {
        _topPercentage = topPercentage;
    }

    public int CalculatePoints(Result result, Division division)
    {
        if (division.Results.Count == 1)
        {
            return 50;
        }

        var maxPlaceEarning = division.Results.Count * _topPercentage;
        if (result.Place > Math.Ceiling(maxPlaceEarning))
        {
            return 0;
        }

        return (int)(50 * (1 - (result.Place - 1) / maxPlaceEarning));
    }
}
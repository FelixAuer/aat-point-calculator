using System.Diagnostics;
using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class TopPercentCalculator : IPointCalculator
{
    private readonly float _topPercentage;
    private readonly int _points;

    public TopPercentCalculator(float topPercentage, int points)
    {
        _topPercentage = topPercentage;
        _points = points;
    }

    public int CalculatePoints(Result result, Division division)
    {
        if (division.Results.Count == 1)
        {
            return _points;
        }

        var maxPlaceEarning = division.Results.Count * _topPercentage;
        if (result.Place > Math.Ceiling(maxPlaceEarning))
        {
            return 0;
        }

        return (int)(_points * (1 - (result.Place - 1) / maxPlaceEarning));
    }
}
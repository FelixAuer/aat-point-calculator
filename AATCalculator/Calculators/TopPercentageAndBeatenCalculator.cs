using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class TopPercentageAndBeatenCalculator : IPointCalculator
{
    private readonly BeatenPlayersCalculator _beatenPlayersCalculator = new();
    private readonly TopPercentCalculator _topPercentCalculator = new(0.5f);

    public int CalculatePoints(Result result, Division division)
    {
        return (int)Math.Floor(_topPercentCalculator.CalculatePoints(result, division) +
                               0.5f * _beatenPlayersCalculator.CalculatePoints(result, division));
    }
}
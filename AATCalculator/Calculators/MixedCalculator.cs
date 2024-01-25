using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class MixedCalculator : IPointCalculator
{
    private readonly BeatenPlayersCalculator _beatenPlayersCalculator = new();
    private readonly TopPercentCalculator _topPercentCalculator = new(0.5f);
    private readonly TopPlacesCalculator _topPlacesCalculator = new(new[] { 20, 10, 5 });

    public int CalculatePoints(Result result, Division division)
    {
        return (int)Math.Floor(_topPercentCalculator.CalculatePoints(result, division) +
                               0.5f * _beatenPlayersCalculator.CalculatePoints(result, division) +
                               _topPlacesCalculator.CalculatePoints(result, division));
    }
}
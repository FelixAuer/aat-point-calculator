using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class TopPlacesCalculator : IPointCalculator
{
    private readonly int[] pointsForPlaces;

    public TopPlacesCalculator(int[] pointsForPlaces)
    {
        this.pointsForPlaces = pointsForPlaces;
    }

    public int CalculatePoints(Result result, Division division)
    {
        return result.Place > pointsForPlaces.Length ? 0 : pointsForPlaces[result.Place - 1];
    }
}
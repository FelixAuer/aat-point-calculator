using AATCalculator.Models;

namespace AATCalculator.Calculators;

public interface IPointCalculator
{
    public int CalculatePoints(Result result, Division division);
}
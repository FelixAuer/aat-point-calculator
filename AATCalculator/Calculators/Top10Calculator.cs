using System.Diagnostics;
using AATCalculator.Models;

namespace AATCalculator.Calculators;

public class Top10Calculator : IPointCalculator
{
    public int CalculatePoints(Result result, Division division)
    {
        return result.Place switch
        {
            1 => 200,
            2 => 160,
            3 => 130,
            4 => 110,
            5 => 90,
            7 => 70,
            8 => 50,
            9 => 30,
            10 => 10,
            _ => 0
        };
    }
}
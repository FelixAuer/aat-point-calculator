using AATCalculator.Models;

namespace AATCalculator.Aggregation;

public class PointAggregator
{
    private readonly Dictionary<string, int> _points = new();

    public void AddResult(Tournament tournament)
    {
        foreach (var division in tournament.Divisions)
        {
            foreach (var result in division.Results)
            {
                AddResult(result);
            }
        }
    }

    private void AddResult(Result result)
    {
        var identifier = result.Name;
        _points.TryAdd(identifier, 0);
        _points[identifier] += result.Points;
    }

    public void Print()
    {
        Console.WriteLine("-*-*-*-*-*-*-*-*-");
        Console.WriteLine("AAT 2023 Results");
        Console.WriteLine("-*-*-*-*-*-*-*-*-");
        var top = _points.OrderByDescending(kv => kv.Value)
            .Take(15)
            .Select(kv => kv.Key)
            .ToList();

        var place = 1;
        foreach (var key in top)
        {
            Console.WriteLine($"{place++}: {key}, Points: {_points[key]}");
        }
    }
}
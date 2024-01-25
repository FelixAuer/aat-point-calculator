using AATCalculator.Aggregation;
using AATCalculator.Calculators;
using AATCalculator.Models;
using Newtonsoft.Json;

var folderPath = @"C:\Users\Felix\Code\AATCalculator\results";
var jsonFiles = Directory.GetFiles(folderPath, "*.json");
var pointAggregator = new PointAggregator();

foreach (var jsonFilePath in jsonFiles)
{
    var jsonContent = File.ReadAllText(jsonFilePath);
    var tournament = JsonConvert.DeserializeObject<Tournament>(jsonContent);
    tournament.CalculatePoints(new MixedCalculator());
    pointAggregator.AddResult(tournament);
    tournament.Print();
    Console.WriteLine();
    Console.WriteLine();
}


pointAggregator.Print();
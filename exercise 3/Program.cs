var tags = new []{"api", "API", "ui", "Api", "db", "UI"};
var unique = new HashSet<string>(tags,StringComparer.OrdinalIgnoreCase);

Console.WriteLine(unique.Count);
Console.WriteLine(string.Join(", ", unique));
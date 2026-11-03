using Tickets;

namespace Datas;
static class SampleData
{
    public static List<Ticket> Tickets() => new()
    {
        new("Write README", "Asha", "Done"),
        new("Add unit tests", "Asha", "InProgress"),
        new("Review PR", "Ravi", "ToDo"),
        new("Set up Docker", "Ravi", "ToDo"),
        new("Fix login bug", "Meera", "InProgress"),
    };

    public static void Run()
    {
        var tickets = SampleData.Tickets();
        var byOwner = tickets
        .GroupBy(t => t.Owner)
        .ToDictionary(g => g.Key, g => g.ToList());
        foreach (var (owner, items) in byOwner)
        {
            Console.WriteLine($"{owner}: {items.Count}");
            foreach (var item in items)
            Console.WriteLine($" {item.Title}");
        }
        // Stretch: unique owners in alphabetical order
        var owners = tickets.Select(t => t.Owner).Distinct().OrderBy(o => o);


    }
}
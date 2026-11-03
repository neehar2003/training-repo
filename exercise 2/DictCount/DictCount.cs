using Models;

namespace DictCount;

public static class DictCount
{
    public static void Run()
    {
        var tickets = new List<Ticket>
        {
        new("Write README", "Asha", "Done"),
        new("Add unit tests", "Asha", "InProgress"),
        new("Review PR", "Ravi", "ToDo"),
        new("Set up Docker", "Ravi", "ToDo"),
        new("Fix login bug", "Meera", "InProgress"),
        }; 

        Dictionary<string, int> counts = new Dictionary<string, int>();
        foreach(var ticket in tickets)
        {
            if(counts.TryGetValue(ticket.State, out int currentCount))
            {
                counts[ticket.State] = currentCount + 1;
            }
            else
            {
                counts[ticket.State] = 1;
            }
        }

        foreach(var entry in counts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
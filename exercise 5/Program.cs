var tickets = new List<Ticket>
{
 new("Write README", "Asha", "Done"),
 new("Add unit tests", "Asha", "InProgress"),
 new("Review PR", "Ravi", "ToDo"),
 new("Set up Docker", "Ravi", "ToDo"),
 new("Fix login bug", "Meera", "InProgress"),
};

tickets.RemoveAll(t => t.State == "Done");


Console.WriteLine($"Tickets remaining: {tickets.Count}");


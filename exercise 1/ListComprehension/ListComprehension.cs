namespace ListComprehension;

public static class Tasks
{
    public static void Run()
    {
        var title = new List<string>
            {
                
            "Write README",
            "Add unit tests",
            "Review PR",
            "Set up docker",
            "Fix login bug"

            };

            Console.WriteLine(string.Join(", ", title));

            title.Add("Deploy to test");

            Console.WriteLine(string.Join(", ", title));

            title.Remove("Review PR");

            Console.WriteLine(string.Join(", ", title));

            title.Sort();

            Console.WriteLine(string.Join(", ", title));

            var first = title.Find(t => t.Contains("test",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(first);

        }
}
//User does 2 jobs
//holds user data & registers the user , also sends emails
//if anything changes in email service, we have to edit User
public class User
{
    public string Name { get; set; }
    public void Register()
    {
        Console.WriteLine($"{Name} registered");
    }
    public void SendWelcomeEmail()
    {
        Console.WriteLine($"Email sent to {Name}");
    }
}
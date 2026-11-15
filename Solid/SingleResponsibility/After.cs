//User only deals with the user
public class User
{
    public string Name { get; set; }

    public void Register()
    {
        Console.WriteLine($"{Name} registered");
    }
}

//EmailService only deals with emails
//if email changes, only make changes in EmailService
public class EmailService
{
    public void SendWelcomeEmail(User user)
    {
        Console.WriteLine($"Email sent to {user.Name}");
    }
}


//SRP - a class should have only 1 reason to change
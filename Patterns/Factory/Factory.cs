// Factory pattern
// Problem: if we want to send a notification (email, sms, whatsapp),
// we would have to write new EmailNotification() / new SmsNotification() everywhere in the code.
// Factory does this in one place.
// we just ask for the type we want and it gives us the object.

interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent" + message);
    }
}

class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("SMS sent" + message);
    }
}

class WhatsAppNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("WhatsApp sent" + message);
    }
}


// gives back the right notification object based on the type
class NotificationFactory
{
    public static INotification Create(string type)
    {
        if (type == "email")
        {
            return new EmailNotification();
        }
        else if (type == "sms")
        {
            return new SmsNotification();
        }
        else if (type == "whatsapp")
        {
            return new WhatsAppNotification();
        }
        else
        {
            throw new Exception("notification type unknown");
        }
    }
}


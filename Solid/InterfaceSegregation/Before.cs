//IWorker forces every worker to Work and Eat
//Robot doesnt eat, but it has to write the method anyway
public interface IWorker
{
    void Work();
    void Eat();
}

public class Human : IWorker
{
    public void Work()
    {
        Console.WriteLine("Human works");
    }

    public void Eat()
    {
        Console.WriteLine("Human eats");
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot works");
    }

    public void Eat()
    {
        throw new Exception("Robot can't eat");
    }
}

//Robot has to implement Eat() just because interface forces it.
//its a method it dont need , it can only throw an error
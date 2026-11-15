//split the big interface into small ones
//Human needs both eat and work, robot only needs work
//no class has a method it doesnt need
public interface IWork
{
    void Work();
}

public interface IEat
{
    void Eat();
}

//Human needs both
public class Human : IWork, IEat
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

//Robot only needs Work
public class Robot : IWork
{
    public void Work()
    {
        Console.WriteLine("Robot works");
    }
}


//ISP - no client should be forced to depend on methods it does not use.
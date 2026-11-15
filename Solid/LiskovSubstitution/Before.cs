//IBird says every bird can fly
//Penguin can't fly, so it breaks that
public interface IBird
{
    void Fly();
}

public class Crow : IBird
{
    public void Fly()
    {
        Console.WriteLine("Crow flies");
    }
}

public class Penguin : IBird
{
    public void Fly()
    {
        throw new Exception("Penguin dont fly");
    }
}

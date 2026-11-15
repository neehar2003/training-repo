//only flying birds can fly
public interface IFlyingBird
{
    void Fly();
}

public class Crow : IFlyingBird
{
    public void Fly()
    {
        Console.WriteLine("Crow flies");
    }
}

//Penguin is a bird but dont get to fly
public class Penguin
{
    public void Walk()
    {
        Console.WriteLine("Penguin walks");
    }
}


//LSP - derived types must be completely substitutable for their base types.
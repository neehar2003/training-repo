//every shape must have GetArea
public interface IShape
{
    int GetArea();
}

//each shape has its own class
public class Square : IShape
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

//to add a new shape, just add a new class
//no need to change the existing ones

//OCP - s/w entities like classes,modules, functions etc should be open for extension, but closed for modification.
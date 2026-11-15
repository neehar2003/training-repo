//to add a new shape,
//for eg triangle, we have to open GetArea() and add another else if.
//for every new shape we have to edit code that already works
public class Shape
{
    public string Type { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        if (Type == "Square")
        {
            return Width * Width;
        }
        else if (Type == "Rectangle")
        {
            return Width * Height;
        }

        return 0;
    }
}

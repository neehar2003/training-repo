//Student (high level) depends directly on Pen (low level)
//Student has decided for itself that it always uses a pen
//to write with a Pencil, we have to edit Student
public class Pen
{
    public void Write()
    {
        Console.WriteLine("Writing with pen");
    }
}

public class Student
{
    public void Study()
    {
        Pen pen = new Pen();
        pen.Write();
    }
}

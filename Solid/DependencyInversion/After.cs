//high level class should not depend on low level class
//both should depend on an interface
//anything that can write has a Write()
public interface IWriter
{
    void Write();
}

public class Pen : IWriter
{
    public void Write()
    {
        Console.WriteLine("Writing with pen");
    }
}

public class Pencil : IWriter
{
    public void Write()
    {
        Console.WriteLine("Writing with pencil");
    }
}

public class Student
{
    public void Study(IWriter writer)
    {
        writer.Write();
    }
}

//Before, Student depends on Pen, high level class depends on a tool
//After, Student , Pen both point at the interface IWriter
//It asks for IWriter, doesnt care whether its a pen or pencil


//DIP - High level modules should not depend on low level modules,
//Both should depend on abstractions.
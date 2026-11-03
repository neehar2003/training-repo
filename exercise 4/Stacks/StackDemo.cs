namespace Stacks;

public class StackDemo
{
    public static void Run()
    {
        var stack = new Stack<string>();
        stack.Push("create");
        stack.Push("edit");
        stack.Push("delete");
        Console.WriteLine(stack.Pop()); 
        Console.WriteLine(stack.Peek()); 
        Console.WriteLine(stack.Count); 
    }
}
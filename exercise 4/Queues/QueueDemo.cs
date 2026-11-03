namespace Queues;
 public class QueueDemo

{
    public static void Run()
    {
        var queue = new Queue<string>();
        queue.Enqueue("first");
        queue.Enqueue("second");
        queue.Enqueue("third");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }   
    }
}
using Lab_1;


class Program
{
    static void Main()
    {
        int n = 100000;

       
        var myQueue = new MyQueue<int>();
        var watch = System.Diagnostics.Stopwatch.StartNew();

        for (int i = 0; i < n; i++)
            myQueue.Enqueue(i);

        for (int i = 0; i < n / 2; i++)
            myQueue.Dequeue();

        bool contains = myQueue.Contains(n - 1);
        watch.Stop();
        Console.WriteLine($"MyQueue time: {watch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Contains last element: {contains}");

        
        var stdQueue = new Queue<int>();
        watch = System.Diagnostics.Stopwatch.StartNew();

        for (int i = 0; i < n; i++)
            stdQueue.Enqueue(i);

        for (int i = 0; i < n / 2; i++)
            stdQueue.Dequeue();

        contains = stdQueue.Contains(n - 1);
        watch.Stop();
        Console.WriteLine($"Standard Queue time: {watch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Contains last element: {contains}");
    }
}
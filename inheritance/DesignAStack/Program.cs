namespace DesignAStack;

class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack();
        int ini = 1;
        int max = 5;
        for (int i = ini; i <= max; i++)
            stack.Push(i);
        //stack.Clear(); just to test the exception InvalidOperation
        for (int i = ini; i < max; i++)
            Console.WriteLine(stack.Pop());
        Console.ReadLine();
    }
}


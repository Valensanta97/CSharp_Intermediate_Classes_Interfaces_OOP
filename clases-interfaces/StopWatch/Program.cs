namespace clases_interfaces.StopWatch.StopWatch;

class Program
{
    static void Main(string[] args)
    {
        var stopWatch = new Stopwatch();
        string? option;
        Console.WriteLine("Please enter the word start to start the stopwatch");
        do
        {
            option = Console.ReadLine();
            switch (option)
            {
                case "start":
                    stopWatch.Start();
                    Console.WriteLine("Please enter the word stop to stop the stopwatch");
                    break;
                case "stop":
                    stopWatch.Stop();
                    Console.WriteLine("Please enter the word result to get the result");
                    break;
            }

        } while (option is not "result"); {
            Console.WriteLine("Result: {0}", stopWatch.Duration);
        }
        
    }
}
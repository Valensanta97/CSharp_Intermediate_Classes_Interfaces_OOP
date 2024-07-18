namespace clases_interfaces;

public class Stopwatch
{ 
    public TimeSpan Duration { get; private set; } 
    private DateTime _initialTime;
    private int _validTimes = 1;

   public void Stop()
   { 
       Duration = DateTime.Now - _initialTime;
   }
   
   public void Start()
   {
       if (_validTimes == 0)
       {
           throw new InvalidOperationException("The stopwatch has an limit times to start");
       }

       _validTimes--;
       _initialTime = DateTime.Now;
   }
   
}
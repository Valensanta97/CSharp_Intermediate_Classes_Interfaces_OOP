
namespace DesignAStack;

public class Stack
{
    private readonly List<object> _list = new();
    
   /**
    *  We use the “object” type here so we can store any objects inside the stack.
    *  We should not store null references in the stack.
    */
   public void Push(object obj)
   {
       if (obj == null)
       {
           throw new InvalidOperationException("The object must be different to Null");
       }
       _list.Add(obj); //added to the end of the list (on top of the stack)
   }
   /**
    * Make sure to take into
    * account the scenario that we call the Pop() method on an empty stack. In this case, this method
    * should throw an InvalidOperationException.
    */
   public object Pop()
   {
       if (_list.Count == 0)
       {
           throw new InvalidOperationException("The object must be different to Null");
       }

       int index = _list.Count - 1;
       var toReturn = _list[index];
       _list.RemoveAt(_list.Count - 1);

       return toReturn;
   }

   public void Clear()
   {
      _list.Clear();
   }
}
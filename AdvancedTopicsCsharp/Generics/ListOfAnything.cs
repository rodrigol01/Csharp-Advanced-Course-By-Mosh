namespace Generics;

public class ListOfAnything
{
    //we can create a generic code, productively
    //but nothing performative. See below 
    
    public List<object> Values { get; set; }

    public void Add(object value)
    {
        Values.Add(value);
    }

    public object this[int index] => throw new NotImplementedException();
    
    //see that I'm using objects to pass strings and integers
    //this is nothing performative (although it's not productive at all)
}
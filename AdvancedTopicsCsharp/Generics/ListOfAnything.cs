namespace Generics;

public class ListOfAnything
{
    //this first code is a limited code and unproductively
    //this class is just limited to type int, if I want to
    //add other types I will need create other classes...
    
    public List<int> Values { get; set; }

    public void Add(int value)
    {
        Values.Add(value);
    }

    public int this[int index] => throw new NotImplementedException();
}
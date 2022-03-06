namespace Generics;

public class ListOfAnything<T>
{
    //we can create a generic code, productive, performative and we can reuse them.

    public List<T> Values { get; set; }

    public void Add(T value)
    {
        Values.Add(value);
    }

    public T this[int index] => throw new NotImplementedException();
}
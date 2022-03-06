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

public class GenericDictionary<Tkey, TValue> where Tkey : notnull
{
    //now, we can play with generic classes from .NET
    //like Dictionary
    public Dictionary<Tkey, TValue> Values { get; set; }

    public void Add(Tkey key, TValue value)
    {
        Values.Add(key, value);
    }
}
namespace Generics;

//example of class with constraint of value types
public class Nullable <T> where T : struct
{
    private object _value;

    public Nullable()
    {
    }
    
    public Nullable(T value)
    {
        _value = value;
    }

    public bool HasValue
    {
        get => _value != null;
    }

    public T GetValueOfDefault()
    {
        if (HasValue)
            return (T) _value;
        
        return default;
    }
}
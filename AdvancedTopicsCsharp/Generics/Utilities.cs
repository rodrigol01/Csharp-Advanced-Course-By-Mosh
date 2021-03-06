public class Utilities<T> where T : IComparable, new()
{
    //but now, we will transform the class in generic.
    
    //5 types of constraints:
    //where T : IComparable 
    //where T : Product (class Product and his children's) 
    //where T : struct
    //where T : class
    //where T : new()

    //not generic
    public int Max (int a, int b) =>
         a > b ? a : b;
    
    //generic with the constraint to IComparable
    public T MaxGeneric(T a, T b) =>
        a.CompareTo(b) > 0 ? a : b;

    public void DoSomething(T value)
    {
        //we need of constraint new() to instantiate this obj.
        var obj = new T();
    }
}
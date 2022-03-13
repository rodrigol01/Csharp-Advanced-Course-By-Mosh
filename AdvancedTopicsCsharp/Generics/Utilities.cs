public class Utilities<T> where T : IComparable
{
    //but now, we will transform the class in generic.
    
    //not generic
    public int Max (int a, int b) =>
         a > b ? a : b;
    
    //generic with the constraint to IComparable
    public T MaxGeneric(T a, T b) =>
        a.CompareTo(b) > 0 ? a : b;
}
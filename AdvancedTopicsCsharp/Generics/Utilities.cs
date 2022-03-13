public class Utilities
{
    //the class isn't generic but the MaxGeneric is generic
    //it's not a problem
    
    //not generic
    public int Max (int a, int b) =>
         a > b ? a : b;
    
    //generic with the constraint to IComparable
    public T MaxGeneric <T>(T a, T b) where T : IComparable =>
        a.CompareTo(b) > 0 ? a : b;
}
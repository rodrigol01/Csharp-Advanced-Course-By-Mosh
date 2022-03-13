namespace Generics;

//create a generic class with constraint of class
public class DiscountCakculator<TProduct> where TProduct : Product
{
    public float CalculateDiscount(TProduct product)
    {
        return product.Price;
    }
}

public class Product
{
    public string Title { get; set; }
    public float Price { get; set; }
}
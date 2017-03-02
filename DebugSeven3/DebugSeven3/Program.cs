// Program gets a quanity ordered from user
// then determines price and discount based on quantity
// price per item before discounts is $6.00
// order 15 or more, get a 20% discount
// order 10 to 14 - get a 14% discount
// order 5 to 9, get a 10% discount
using System;
using static System.Console;
class DebugSeven3
{
    static void Main()
    {
        var quantity = GetQuantity();
        Console.WriteLine(quantity);
        var price = CalculatePrice(quantity);
        WriteLine("Final price for {0} items is {1}.",
          quantity, price.ToString("c"));
    }

    static int GetQuantity()
    {
        Write("Enter number of items >> ");
        var quan = Convert.ToInt32(ReadLine());
        return quan;
    }

    private static double CalculatePrice(int quantityOrdered)
    {
        double PRICE_PER_ITEM = 6.00;
        double price = 0;
        double discount = 0;
        int[] quanLimits = { 0, 5, 10, 15};
        double[] limits = { 0, 0.10, 0.14, 0.20};
        for (int x = limits.Length - 1; x >= 0; --x)
        {
            if (quantityOrdered >= quanLimits[x])
            {
                discount = limits[x];
                break;
            }
        }
            
        price = quantityOrdered * PRICE_PER_ITEM;
        price = price - price * discount;
        return price;
    }
}

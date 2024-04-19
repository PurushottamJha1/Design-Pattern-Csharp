using DesignPattern;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the price: $");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter the type of card (Membership/Employee/None): ");
        string cardType = Console.ReadLine().ToLower();

        Customer customer = new Customer();

        switch (cardType)
        {
            case "membership":
                customer.SetDiscountStrategy(new LowDiscountStrategy());
                break;
            case "employee":
                customer.SetDiscountStrategy(new HighDiscountStrategy());
                break;
            case "none":
                customer.SetDiscountStrategy(new NoDiscountStrategy());
                break;
            default:
                Console.WriteLine("Invalid card type! Defaulting to No Discount.");
                break;
        }

        double discountedPrice = customer.GetDiscountedPrice(price);

        Console.WriteLine("Discounted Price: $" + discountedPrice);
    }
}
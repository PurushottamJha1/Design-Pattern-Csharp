using System;


namespace DesignPattern
{
    
    internal class HighDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount * 0.8;
        }
    }
}

using System;


namespace DesignPattern
{
    internal class LowDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount * 0.9;
        }
    }
}

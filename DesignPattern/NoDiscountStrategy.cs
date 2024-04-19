using System;


namespace DesignPattern
{
   
    internal class NoDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount;
        }
    }
}

using System;

namespace DesignPattern
{
    internal interface IDiscountStrategy
    {
        double ApplyDiscount(double amount);
    }
}

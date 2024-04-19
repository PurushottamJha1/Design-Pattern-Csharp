using System;

namespace DesignPattern
{
    internal class Customer
    {

        private IDiscountStrategy _discountStrategy;

        public Customer()
        {
            _discountStrategy = new NoDiscountStrategy();
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double GetDiscountedPrice(double amount)
        {
            return _discountStrategy.ApplyDiscount(amount);
        }
    }
}



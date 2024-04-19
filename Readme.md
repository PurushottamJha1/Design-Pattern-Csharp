# Shopping Mall Discount System

## Overview

Welcome to the Shopping Mall Discount System! This project demonstrates the implementation of a discount system using the Strategy design pattern in C#. The system calculates discounts for customers based on their membership or employment status.

## How It Works

The Shopping Mall Discount System utilizes the Strategy design pattern to calculate discounts for customers based on their membership or employment status. Here's how it works:

1. **Price Input**: The system prompts the user to input the price of the items.
2. **Card Type Input**: Next, the user is asked to specify their card type: Membership, Employee, or None.
3. **Discount Strategy Selection**: Based on the card type provided by the user, the system selects the appropriate discount strategy:
   - Membership card: Applies a low discount (10% off).
   - Employee card: Applies a high discount (20% off).
   - No card: Applies no discount.
4. **Discount Calculation**: The selected discount strategy calculates the discounted price based on the input price and applies the corresponding discount.
5. **Display Result**: Finally, the system displays the discounted price to the user.



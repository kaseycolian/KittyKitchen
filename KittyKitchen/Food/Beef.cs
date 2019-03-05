using System;
using KittyKitchen.Food;

namespace KittyKitchen
{
    public class Beef : IFoodTypes
    {
        public int Food()
        {
            Console.WriteLine("Thanks for feeding us the beef!");
            return FoodConstants.BeefFoodAmount;
        }
    }
}

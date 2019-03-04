using System;

namespace KittyKitchen
{
    public class Treats : IFoodTypes
    {
        public int Food()
        {
            Console.WriteLine("Thanks for the treats! We'll always have more, please.");
            return 35;
        }
    }
}

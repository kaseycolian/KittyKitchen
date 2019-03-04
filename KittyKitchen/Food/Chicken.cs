using System;

namespace KittyKitchen
{
    public class Chicken : IFoodTypes
    {
        public int Food()
        {
            Console.WriteLine("Thanks for feeding us chicken!");
            return 25;
        }
    }
}

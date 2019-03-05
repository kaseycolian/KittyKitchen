using System;
using KittyKitchen.Toys;

namespace KittyKitchen
{
    public class FluffyBall : IToys
    {
        public int Play()
        {
            Console.WriteLine("We love fluffy balls!");

            return ToysConstants.FluffyBallPlayPower;
        }
    }
}

using System;


namespace KittyKitchen
{
    public class FluffyBall : IToys
    {
        public int Play()
        {
            Console.WriteLine("We love fluffy balls!");

            return 25;
        }
    }
}

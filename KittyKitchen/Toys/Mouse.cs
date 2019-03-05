using KittyKitchen.Toys;

namespace KittyKitchen
{
    public class Mouse : IToys
    {
        public int Play()
        {
            return ToysConstants.MousePlayPower;
        }
    }
}

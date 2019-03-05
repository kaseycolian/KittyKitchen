using KittyKitchen.Toys;

namespace KittyKitchen
{
    public class LaserPointer : IToys
    {
        public int Play()
        {
            return ToysConstants.LaserPointerPlayPower;
        }
    }
}

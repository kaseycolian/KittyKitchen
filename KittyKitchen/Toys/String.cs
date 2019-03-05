using KittyKitchen.Toys;

namespace KittyKitchen
{
    public class String : IToys
    {
        public int Play()
        {
            return ToysConstants.StringPlayPower;
        }
    }
}

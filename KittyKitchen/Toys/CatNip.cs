using KittyKitchen.Toys;

namespace KittyKitchen
{
    public class CatNip : IToys
    {
        public int Play()
        {
            return ToysConstants.CatNipPlayPower;
        }
    }
}

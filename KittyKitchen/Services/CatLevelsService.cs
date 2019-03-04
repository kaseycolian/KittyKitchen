using System.Collections.Generic;


namespace KittyKitchen
{
    public class CatLevelsService
    {
        public List<Cat> catsOutOfBounds = new List<Cat>();
        

        public bool CheckOverBoundsSingleCat(Cat cat)
        {
            if (cat.HappyLevel <= 0 || cat.HungerLevel > 600 || catsOutOfBounds.Contains(cat)) 
            {

                if (!catsOutOfBounds.Contains(cat)) {
                    catsOutOfBounds.Add(cat);
                }

                System.Console.WriteLine(cat.Name + " is broken and is hiding from you.  Pick another cat.");
                return true;
            }
            return false;
        }

        public void CheckOverBoundsAllCats(List<Cat> cats)
        {
            foreach(var cat in cats)
            {
                if (cat.HappyLevel <= 0 || cat.HungerLevel > 600) {

                    catsOutOfBounds.Add(cat);
                    System.Console.WriteLine(cat.Name + " is broken and is hiding from you. You won't be able to select them again.");
                }
            }
        }
    }
}

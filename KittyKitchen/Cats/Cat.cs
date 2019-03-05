using System;
using System.Collections.Generic;

namespace KittyKitchen
{
    public abstract class Cat
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Color { get; set; }
        public int HungerLevel { get; set; }
        public int HappyLevel { get; set; }

        private static Random rnd = new Random();


        public abstract void Pet();

        public int IncreaseHappy(int amount)
        {
            return HappyLevel += amount;
        }

        public int ReduceHunger(int amount)
        {
            return HungerLevel -= amount;
        }

        public int IncreaseHunger(int amount)
        {
            return HungerLevel += amount;
        }

        public static List<Cat> MakeRandomSadness(List<Cat> cats, Cat catToExclude)
        {
            foreach (var cat in cats)
            {
                if (cat.Name != catToExclude.Name) {
                    cat.HappyLevel -= rnd.Next(0, 35);
                    Console.WriteLine(cat.Name + " happy level is now: " + cat.HappyLevel);
                }
            }
            return cats;
        }

     }
}

using System;

namespace KittyKitchen
{
    public class CrankyCat : Cat
    {
        public CrankyCat (string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
            HungerLevel = 300;
            HappyLevel = 200;
        }

        public override void Pet()
        {
            HappyLevel -= 15;
            Console.WriteLine("Back up hooman, no pettins!");
        }

        public override string ToString()
        {
            return Name +  "  is a " + Age + " year old " + Color + " cranky cat. \r\nHunger Level: " + HungerLevel + "\r\nHappyLevel: " + HappyLevel + "\r\n" ;
        }

    }
}

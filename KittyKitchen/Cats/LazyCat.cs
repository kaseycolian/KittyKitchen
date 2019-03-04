using System;

namespace KittyKitchen
{

    public class LazyCat : Cat
    {
        public LazyCat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
            HungerLevel = 400;
            HappyLevel = 500;
        }

        public override void Pet()
        {
            HappyLevel += 15;
            Console.WriteLine("I sleeeeepy. But thank you for petting me, hooman.");
        }

        public override string ToString()
        {
            return Name + "  is a " + Age + " year old " + Color + " lazy cat. \r\nHunger Level: " + HungerLevel + "\r\nHappyLevel: " + HappyLevel + "\r\n";
        }


    }
}

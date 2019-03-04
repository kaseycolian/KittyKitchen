using System;

namespace KittyKitchen
{
    public class FloofCat : Cat
    {

        public FloofCat(string name, int age, string color) 
        {
            Name = name;
            Age = age;
            Color = color;
            HungerLevel = 500;
            HappyLevel = 400;
        }

        public override void Pet()
        {
            HappyLevel += 20;
            Console.WriteLine("My floofy self wants all the pettin!'");
        }

        public override string ToString()
        {
            return Name + "  is a " + Age + " year old " + Color + " floofy cat. \r\nHunger Level: " + HungerLevel + "\r\nHappyLevel: " + HappyLevel + "\r\n";
        }


    }
}

using System;


namespace KittyKitchen
{
    public class NumberValidator
    {
        public bool isParsable(string entry)
        {
            var i = 0;
            return Int32.TryParse(entry, out i);
        }

        public static bool isBeyondMenuRange(string response, int higher)
        {
            return (int.Parse(response) <= 0 || int.Parse(response) > higher);
        }
    }
}

using System.Collections.Generic;


namespace KittyKitchen
{
    public class Playroom
    {
        private IList<IToys> _toys { get; set; }

        public Playroom()
        {
            _toys = new List<IToys>();
        }

        public IList<IToys> GetToysList()
        {
            return _toys;
        }

        public int PlayWithToys()
        {
            var amount = 0;

            foreach(var toy in _toys)
            {
               amount += toy.Play();
            }

            System.Console.WriteLine("Thanks for the toys!!!!");
            return amount;
        }
        
        public void AddToys(IToys toy)
        {
            _toys.Add(toy);
        }

        public void ClearToys()
        {
            _toys.Clear();
        }
    }
}

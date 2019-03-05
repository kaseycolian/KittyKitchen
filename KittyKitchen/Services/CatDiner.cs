using System.Collections.Generic;

namespace KittyKitchen
{
    public class CatDiner 
    {
        private IList<IFoodTypes> _foodTypes;

        public CatDiner()
        {
            _foodTypes = new List<IFoodTypes>();
        }

        public IList<IFoodTypes> GetFoodTypeList()
        {
            return _foodTypes;
        }

        public int DinnerTime()
        {
            var amount = 0;

            foreach (var food in _foodTypes)
            {
                amount += food.Food();
            }
            return amount;
        }

        public void AddFood(IFoodTypes food)
        {
            _foodTypes.Add(food);
        }

        public void ClearDiner()
        {
            _foodTypes.Clear();
        }
    }
}

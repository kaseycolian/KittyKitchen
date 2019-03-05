using KittyKitchen.Food;
 using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KittyKitchen.UnitsTests
{
    [TestClass]
    public class CatDinerTests
    {
        private CatDiner mockCatDiner = new CatDiner();

        [TestMethod]
        public void AddFood_AddingMultipleTypesOfFood_ShouldBeAddedToFoodTypesList()
        {
            mockCatDiner.AddFood(new Beef());
            mockCatDiner.AddFood(new Chicken());
            mockCatDiner.AddFood(new Treats());

            Assert.IsTrue(mockCatDiner.GetFoodTypeList().Count == 3);
        }

        [TestMethod]
        public void ClearDiner_CallingOnAListWithSize3_ShouldMakeListCount0()
        {
            mockCatDiner.AddFood(new Beef());
            mockCatDiner.AddFood(new Chicken());
            mockCatDiner.AddFood(new Treats());

            mockCatDiner.ClearDiner();

            Assert.IsTrue(mockCatDiner.GetFoodTypeList().Count == 0);
        }

        [TestMethod]

        public void DinnerTime_IListOfEachFoodType_ShouldReturnSumOfEachFoodAmountFromEachType()
        {
            var testAmount = FoodConstants.BeefFoodAmount +
                FoodConstants.ChickenFoodAmount +
                FoodConstants.TreatsFoodAmount;

            mockCatDiner.AddFood(new Beef());
            mockCatDiner.AddFood(new Chicken());
            mockCatDiner.AddFood(new Treats());

            var actualAmount = mockCatDiner.DinnerTime();

            Assert.AreEqual(testAmount, actualAmount);
        }
    }
}

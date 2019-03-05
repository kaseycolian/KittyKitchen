using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KittyKitchen.UnitsTests
{
    [TestClass]
    public class CrankyCatTests

    {
        private int testAmount = 46;

        [TestMethod]
        public void Pet_PetCalledOnOneCrankyCat_HappyShouldDecreaseBy15()
        {
            var testCat1 = new CrankyCat("Tank", 42, "Purple");
            var startHappy = testCat1.HappyLevel;

            testCat1.Pet();

            var afterHappy = startHappy - 15;

            Assert.AreEqual(afterHappy, testCat1.HappyLevel);
        }

        [TestMethod]
        public void IncreaseHappy_CalledWith46AsAmount_HappyShouldIncrease()
        {
            var testCat = new CrankyCat("Chubs", 2, "Marshmellow");
            var startHappy = testCat.HappyLevel;


            testCat.IncreaseHappy(testAmount);

            var afterHappy = startHappy + testAmount;

            Assert.AreEqual(afterHappy, testCat.HappyLevel);
        } 

        [TestMethod]
        public void ReduceHunger_CalledWith46AsAmount_HungerShouldDecrease()
        {
            var testCat = new CrankyCat("Chairman", 42, "rainbow");

            var startHunger = testCat.HungerLevel;
            var afterHunger = startHunger - testAmount;

            testCat.ReduceHunger(testAmount);

            Assert.AreEqual(afterHunger, testCat.HungerLevel);

        }

        [TestMethod]
        public void IncreaseHunger_CalledWith46AsAmount_HungerShouldIncrease()
        {
            var testCat = new CrankyCat("Dozer", 2, "glitter");

            var startHunger = testCat.HungerLevel;
            var afterHunger = startHunger + testAmount;

            testCat.IncreaseHunger(testAmount);

            Assert.AreEqual(afterHunger, testCat.HungerLevel);
        }

        [TestMethod]
        public void MakeRandomSadness_CalledOnAListOfCats_OneHappyLevelSameOtherHappyLevelDecreases()
        {
            List<Cat> cats = new List<Cat> {
                new CrankyCat("Mister Anderson", 42, "sparkles"),
                new CrankyCat("Nirvana", 2, "pink")
            };

            var excludedCatStartHappy = cats[0].HappyLevel;
            var includedCatStartHappy = cats[1].HappyLevel;

            Cat.MakeRandomSadness(cats, cats[0]);

            Assert.AreEqual(excludedCatStartHappy, cats[0].HappyLevel);
            Assert.AreNotEqual(includedCatStartHappy, cats[1].HappyLevel);

        }

    } 
}

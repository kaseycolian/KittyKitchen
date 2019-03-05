using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace KittyKitchen.UnitsTests
{
    [TestClass]
    public class CatLevelsServiceTests
    {
        private CatLevelsService mockCatLevelService = new CatLevelsService();

        private List<Cat> cats = new List<Cat>() {
            new CrankyCat("Wario", 46, "yellow"),
            new CrankyCat("Shy Guy", 2, "white")
        };

        private Cat happyTestCat = new CrankyCat("Sonic", 46, "blue");
        private Cat hungerTestCat = new CrankyCat("Mario", 2, "red");

        [TestMethod]
        public void CheckOverBoundSingleCat_CatUnderHappyBarrier_ShouldAddCatToCatsOutOfBoundListAndReturnTrue()
        {
            happyTestCat.HappyLevel = 0;

            Assert.IsTrue(mockCatLevelService.CheckOverBoundsSingleCat(happyTestCat));

            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Contains(happyTestCat));

        }
        [TestMethod]
        public void CheckOverBoundSingleCat_CatOverHappyBarrier_ShouldNotAddCatToCatsOutOfBoundsListAndReturnFalse()
        {
            happyTestCat.HappyLevel = 46;

            Assert.IsFalse(mockCatLevelService.CheckOverBoundsSingleCat(happyTestCat));
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Count == 0);
            Assert.IsFalse(mockCatLevelService.catsOutOfBounds.Contains(happyTestCat));

        }
        [TestMethod]
        public void CheckOverBoundSingleCat_CatOverHungerBarrier_ShouldAddCatTocatOutOfBoundsListAndReturnTrue()
        {
            hungerTestCat.HungerLevel = 4200;

            Assert.IsTrue(mockCatLevelService.CheckOverBoundsSingleCat(hungerTestCat));
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Contains(hungerTestCat));

        }

        [TestMethod]
        public void CheckOverBoundSingleCat_CatUnderHungerBarrier_ShouldNotAddCatTocatOutOfBoundsListAndReturnFalse()
        {
            hungerTestCat.HungerLevel = 200;

            Assert.IsFalse(mockCatLevelService.CheckOverBoundsSingleCat(hungerTestCat));
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Count == 0);
            Assert.IsFalse(mockCatLevelService.catsOutOfBounds.Contains(hungerTestCat));

        }

        [TestMethod]
        public void CheckOverBoundSingleCat_CatAlreadyInList_ShouldNotReAddCatTocatOutOfBoundsListAndReturnTrue()
        {
            cats.Add(happyTestCat);
            happyTestCat.HappyLevel = 0;

            Assert.IsTrue(mockCatLevelService.CheckOverBoundsSingleCat(happyTestCat));
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Count == 1);

        }

        [TestMethod]
        public void CheckOverBoundsAllCats_OneCatUnderHappyBarrier_ShouldAddThatCatToCatsOutOfBoundsList()
        {
            cats[0].HappyLevel = 0;
            mockCatLevelService.CheckOverBoundsAllCats(cats);
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Contains(cats[0]));

        }

        [TestMethod]
        public void CheckOverBoundsAllCats_OneCatOverHappyBarrier_ShouldNotAddThatCatToCatsOutOfBoundsList()
        {
            cats[1].HappyLevel = 300;
            mockCatLevelService.CheckOverBoundsAllCats(cats);
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Count == 0);
            Assert.IsFalse(mockCatLevelService.catsOutOfBounds.Contains(cats[1]));
        }

        [TestMethod]
        public void CheckOverBoundsAllCats_OneCatOverHungerBarrier_ShouldAddThatCatToCatsOutOfBoundsList()
        {
            cats[0].HungerLevel = 4200;
            mockCatLevelService.CheckOverBoundsAllCats(cats);
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Contains(cats[0]));
        }

        [TestMethod]
        public void CheckOverBoundsAllCats_OneCatUnderHungerBarrier_ShouldNotAddThatCatToCatsOutOfBoundsList()
        {
            mockCatLevelService.CheckOverBoundsAllCats(cats);
            Assert.IsTrue(mockCatLevelService.catsOutOfBounds.Count == 0);
            Assert.IsFalse(mockCatLevelService.catsOutOfBounds.Contains(cats[0]));
        }




    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KittyKitchen.UnitsTests
{
    [TestClass]
    public class PlayroomTests
    {

        private Playroom mockPlayroom = new Playroom();

        [TestMethod]
        public void AddToys_MultipleToyTypesAddedToIToyList_ShouldBeSavedInList()
        {
            mockPlayroom.AddToys(new CatNip());
            mockPlayroom.AddToys(new Mouse());
            mockPlayroom.AddToys(new LaserPointer());

            Assert.IsTrue(mockPlayroom.GetToysList().Count == 3);
        }

        [TestMethod]
        public void ClearToys_ListClearedAfterItemsAdded_ListShouldBeEmpty()
        {
            mockPlayroom.AddToys(new String());
            mockPlayroom.AddToys(new Mouse());

            mockPlayroom.ClearToys();

            Assert.IsTrue(mockPlayroom.GetToysList().Count == 0);
        }


        [TestMethod]
        public void PlayWithToys_AddingEachTypeToList_ShouldExecuteEachTypeOfClassPlayMethodAndReturn115()
        {
            var testAmount = Toys.ToysConstants.CatNipPlayPower + 
                Toys.ToysConstants.FluffyBallPlayPower + 
                Toys.ToysConstants.FoiLBallPlayPower +
                Toys.ToysConstants.LaserPointerPlayPower + 
                Toys.ToysConstants.MousePlayPower + 
                Toys.ToysConstants.StringPlayPower;

            mockPlayroom.AddToys(new CatNip());
            mockPlayroom.AddToys(new FluffyBall());
            mockPlayroom.AddToys(new FoilBall()); 
            mockPlayroom.AddToys(new LaserPointer()); 
            mockPlayroom.AddToys(new Mouse());
            mockPlayroom.AddToys(new String());

            var actualAmount = mockPlayroom.PlayWithToys();

            Assert.AreEqual(testAmount, actualAmount);
        }
    }
}

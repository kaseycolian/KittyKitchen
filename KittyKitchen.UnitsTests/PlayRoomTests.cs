using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KittyKitchen.UnitsTests
{
    [TestClass]
    public class PlayroomTests
    {
        //private IToys mockIToys = new IToys();
        //private IList<IToys> _toys = new List<IToys>();
        private Playroom mockPlayroom = new Playroom();

        private CatNip mockCatNip = new CatNip();
        private FluffyBall mockFluffyBall = new FluffyBall();
        private FoilBall mockFoilBall = new FoilBall();
        private LaserPointer laserPointer = new LaserPointer();
        private Mouse mockMouse = new Mouse();
        private String mockString = new String();


        [TestMethod]
        public void AddToys_MultipleToyTypesAddedToIToyList_ShouldBeSavedInList()
        {
            mockPlayroom.AddToys(new CatNip());
            mockPlayroom.AddToys(new Mouse());
            mockPlayroom.AddToys(new LaserPointer());

            Assert.IsTrue(mockPlayroom._toys.Count == 3);
        }

        [TestMethod]
        public void ClearToys_ListClearedAfterItemsAdded_ListShouldBeEmpty()
        {
            mockPlayroom.AddToys(new String());
            mockPlayroom.AddToys(new Mouse());

            mockPlayroom.ClearToys();

            Assert.IsTrue(mockPlayroom._toys.Count == 0);
        }


        [TestMethod]
        public void PlayWithToys_AddingEachTypeToList_ShouldExecuteEachTypeOfClassPlayMethodAndReturn115()
        {
            // Should I test for hardcoded value of manually adding up return values 
            // or test for it as below, which is a very large mimic of the PlayWithToys method
            var toyArray = new Object[] { mockCatNip, mockFluffyBall, mockFoilBall, laserPointer, mockMouse, mockString };

            var testAmount = 0;

            foreach(var toy in toyArray)
            {
                testAmount += toy.Play();
            }

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

using System;
using System.Collections.Generic;


namespace KittyKitchen
{

    class Program
    {
        static void Main(string[] args)
        {
            var cats = new List<Cat>();

            cats.Add(new FloofCat("Tank", 5, "orange and white"));
            cats.Add(new FloofCat("Dozer", 5, "black and white"));
            cats.Add(new LazyCat("Mister Anderon", 13, "orange"));
            cats.Add(new CrankyCat("Chairman", 8, "grey"));
            cats.Add(new LazyCat("Chubington Mars Mellow III", 2, "orange"));
            cats.Add(new LazyCat("Nirvana", 4, "grey"));

            var catLevelService = new CatLevelsService();
          
            var i = 0;
                       
            while (true)
            {

                Console.WriteLine("What would you like to do? 1: Pet Cats, 2: Feed Cats, 3: Play with Cats, 4: Check on status of all cats, 5: Quit");
                var response = Console.ReadLine();
                var mainMenuOptions = 5;


                if (!Int32.TryParse(response, out i) || NumberValidator.isBeyondMenuRange(response, mainMenuOptions))
                {
                    Console.WriteLine("Please enter a valid number from 1-" + mainMenuOptions);
                    continue;
                }

                switch (int.Parse(response))
                {
                    case 1:
                        Console.WriteLine("Which cat would you like to pet? 1: Tank, 2: Dozer, 3: Mister Anderson, 4: Chairman, 5: Chubs, 6: Nirvana");
                        var catToPet = Console.ReadLine();

                        switch (int.Parse(catToPet))
                        {
                            case 1:
                                if (!catLevelService.CheckOverBoundsSingleCat(cats[0]))
                                {
                                    cats[0].Pet();
                                    Cat.MakeRandomSadness(cats, cats[0]);
                                }
                                break;
                            case 2:
                                if (!catLevelService.CheckOverBoundsSingleCat(cats[1]))
                                {
                                    cats[1].Pet();
                                    Cat.MakeRandomSadness(cats, cats[1]);
                                }
                                break;
                            case 3:
                                if (!catLevelService.CheckOverBoundsSingleCat(cats[2]))
                                {
                                    cats[2].Pet();
                                    Cat.MakeRandomSadness(cats, cats[2]);
                                }
                                    break;
                            case 4:
                                if (!catLevelService.CheckOverBoundsSingleCat(cats[3]))
                                {
                                    cats[3].Pet();
                                    Cat.MakeRandomSadness(cats, cats[3]);
                                }
                                break;
                            case 5:
                                if (!catLevelService.CheckOverBoundsSingleCat(cats[4]))
                                {
                                    cats[4].Pet();
                                    Cat.MakeRandomSadness(cats, cats[4]);
                                }
                                break;
                            case 6:
                                if (!catLevelService.CheckOverBoundsSingleCat(cats[5]))
                                {
                                    cats[5].Pet();
                                    Cat.MakeRandomSadness(cats, cats[5]);
                                }
                                break;
                        }

                        continue;

                    case 2:
                        var catDiner = new CatDiner();

                        while (true)
                        {
                            Console.WriteLine("What food do you want to give all the cats? 1: Chicken, 2: Beef, 3: Treats, 4: Quit Feeding");
                            var selectedFood = Console.ReadLine();
                            var numberOfFoodOptions = 4;

                            if (!Int32.TryParse(selectedFood, out i) || NumberValidator.isBeyondMenuRange(selectedFood, numberOfFoodOptions))
                            {
                                Console.WriteLine("Please enter a valid number from 1-" + numberOfFoodOptions);
                                continue;
                            }

                            switch (int.Parse(selectedFood))
                            {
                                case 1:
                                    catDiner.AddFood(new Chicken());
                                    continue;
                                case 2:
                                    catDiner.AddFood(new Beef());
                                    continue;
                                case 3:
                                    catDiner.AddFood(new Treats());
                                    continue;
                                case 4:
                                    var amount = 0;
                                    amount = catDiner.DinnerTime();
                                    foreach (var cat in cats)
                                    {
                                        cat.HungerLevel -= amount;
                                    }

                                    catLevelService.CheckOverBoundsAllCats(cats);

                                    break;
                            }

                            break ;
                        }

                        continue;
                    case 3:
                        var playroom = new Playroom();

                        while (true)
                        {
                            Console.WriteLine("What toy do you want to give the cats to play with? 1: CatNip, 2: Fluffy Ball, 3: Foil Ball, 4: Laser Pointer, 5: Mouse, 6: String, 7: No More Toys");
                            var selectedToy = Console.ReadLine();
                            var numberOfToyOptions = 7;

                            if (!Int32.TryParse(selectedToy, out i) || NumberValidator.isBeyondMenuRange(selectedToy, numberOfToyOptions))
                            {
                                Console.WriteLine("Please enter a valid number from 1-" + numberOfToyOptions);
                                continue;
                            }

                            switch(int.Parse(selectedToy))
                            {
                                case 1:
                                    playroom.AddToys(new CatNip());
                                    continue;
                                case 2:
                                    playroom.AddToys(new FluffyBall());
                                    continue;
                                case 3:
                                    playroom.AddToys(new FoilBall());
                                    continue;
                                case 4:
                                    playroom.AddToys(new LaserPointer());
                                    continue;
                                case 5:
                                    playroom.AddToys(new Mouse());
                                    continue;
                                case 6:
                                    playroom.AddToys(new String());
                                    continue;
                                case 7:
                                    var playAmount = playroom.PlayWithToys();

                                    foreach(var cat in cats)
                                    {
                                        cat.IncreaseHappy(playAmount);
                                        cat.IncreaseHunger(playAmount/4); 
                                    }

                                    catLevelService.CheckOverBoundsAllCats(cats);
                                    playroom.ClearToys();

                                    break;
                            }
                            break;
                        }

                        continue;
                    case 4:
                        foreach (var cat in cats)
                        {
                           Console.WriteLine(cat.ToString()); ;
                        }

                        continue;

                    case 5:
                        break;
                }
             
                break;
            }

        }
    }
}

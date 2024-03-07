using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Circustrein_V1;
using System.Diagnostics;
using System.Collections.Generic;

namespace UnitTestMethods
{
    [TestClass]
    public class UnitTestMethods
    {
        SortingLogic sortingLogic = new SortingLogic();

        [TestMethod]
        public void BiggerHerbivoreShouldBeAddedToSmallerCarnivore()
        {
            Animal SmallCarnivore = new Animal(AnimalSize.Small, Diet.Carnivore);       
            Animal MediumHerbivore = new Animal(AnimalSize.Medium, Diet.Herbivore);

            Wagon wagon = new Wagon();

            wagon.AddAnimalIfPossibleOtherwiseFalse(SmallCarnivore);
            wagon.AddAnimalIfPossibleOtherwiseFalse(MediumHerbivore);

            Assert.IsTrue(wagon.GetAnimals().Contains(MediumHerbivore));
        }

        [TestMethod]
        public void WagonsMaxCapacityIs10()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(2, train.GetWagons().Count);
        }
    }
}

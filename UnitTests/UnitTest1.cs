using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Circustrein_V1;
using System.Collections.Generic;
using System.Diagnostics;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        SortingLogic sortingLogic = new SortingLogic();

        [TestMethod]
        public void TestScernario_01()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(2, train.GetWagons().Count);
        }

        
        [TestMethod]
        public void TestScernario_02()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(2, train.GetWagons().Count);
        }

        [TestMethod]
        public void TestScernario_03()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(4, train.GetWagons().Count);
        }


        [TestMethod] 
        public void TestScernario_04()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(5, train.GetWagons().Count);
        }

        [TestMethod]
        public void TestScernario_05()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(2, train.GetWagons().Count);
        }

        [TestMethod]
        public void TestScernario_06()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(3, train.GetWagons().Count);
        }

        [TestMethod]
        public void TestScernario_07()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));

            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));

            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));


            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(13, train.GetWagons().Count);
        }


        [TestMethod]
        public void TestScernario_08()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            train = sortingLogic.SortAndDistribute(animals);

            Assert.AreEqual(0, train.GetWagons().Count);
        }
    }
}

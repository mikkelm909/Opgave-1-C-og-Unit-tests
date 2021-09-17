using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1_C_og_Unit_tests;

namespace FootballPlayerTest
{
    [TestClass]
    public class FootballPlayerTest
    {
        private FootballPlayer footballPlayer;

        [TestInitialize]
        public void SetUpFootballPlayer()
        {
            footballPlayer = new FootballPlayer();
        }

        [TestMethod]
        public void TestFootballPlayerId()
        {
            footballPlayer.Id = 0;
            Assert.AreEqual(0, footballPlayer.Id);
        }

        [TestMethod]
        public void TestFootballPlayerNameLegal()
        {
            footballPlayer.Name = "John Johnson";
            Assert.AreEqual("John Johnson", footballPlayer.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFootballPlayerNameIlegal()
        {

            footballPlayer.Name = "Bo";
        }


        [TestMethod]
        public void TestFootballPlayerPriceLegal()
        {
            footballPlayer.Price = 3;
            Assert.AreEqual(3, footballPlayer.Price);

            footballPlayer.Price = 1;
            Assert.AreEqual(1, footballPlayer.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFootballPlayerPriceIlegal()
        {
            footballPlayer.Price = 0;
        }

        [TestMethod]
        public void TestFootballPlayerShirtNumberLegal()
        {
            footballPlayer.ShirtNumber = 1;
            Assert.AreEqual(1, footballPlayer.ShirtNumber);

            footballPlayer.ShirtNumber = 100;
            Assert.AreEqual(100, footballPlayer.ShirtNumber);

            footballPlayer.ShirtNumber = 50;
            Assert.AreEqual(50, footballPlayer.ShirtNumber);
        }

        [TestMethod]
        public void TestFootballPlayerShirtNumberIlegal()
        {
            try
            {
                footballPlayer.ShirtNumber = 0;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
            }
            try
            {
                footballPlayer.ShirtNumber = 101;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
            }
        }
    }
}

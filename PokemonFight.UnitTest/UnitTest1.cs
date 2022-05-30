using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PokemonFight.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void testCountOfListCardWhenRemovedOneCard()
        {
            Card card1 = new Card();
            card1.Name = "Pikachu";
            Card card2 = new Card();
            card2.Name = "Charizard";

            User userTest = new User();
            userTest.addCard(card1);
            userTest.addCard(card2);
            
            Assert.AreEqual(2, userTest.getAllCard().Count);
            
            userTest.removeCard(card1);
            Assert.AreEqual(1, userTest.getAllCard().Count);
        }
    }
}

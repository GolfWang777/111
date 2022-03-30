using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoodStruct;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CreatingAndReadingMethod()
        {
            var foodProduct = new Food(250, 125);

            Assert.ThrowsException<Exception>(() => new Food(-5, 250));
            Assert.ThrowsException<Exception>(() => new Food(0, 0));

            Assert.AreEqual("250 г, калорийности 125 Ккал/100г.", foodProduct.ToString());
        }

        [TestMethod]
        public void EqualsMethod()
        {
            var firstProduct = new Food(250, 125);
            var secondProduct = new Food(125, 250);
            var thirdProduct = new Food(250, 125);

            Assert.IsFalse(firstProduct.Equals(secondProduct));
            Assert.IsTrue(firstProduct.Equals(thirdProduct));

            Assert.IsTrue(firstProduct.GetHashCode() == thirdProduct.GetHashCode());
            Assert.IsFalse(firstProduct.GetHashCode() == secondProduct.GetHashCode());
        }

        [TestMethod]
        public void OperationsMethod()
        {
            var firstProduct = new Food(200, 125);
            var secondProduct = new Food(125, 125);
            var thirdProduct = new Food(300, 100);

            Assert.AreEqual(new Food(325, 125), firstProduct + secondProduct);
            Assert.AreEqual(new Food(75, 125), firstProduct - secondProduct);

            Assert.ThrowsException<Exception>(() => firstProduct + thirdProduct);
        }
    }
}

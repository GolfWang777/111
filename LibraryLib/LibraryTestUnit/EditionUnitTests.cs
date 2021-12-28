using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryLib;
using System.IO;
using System;

namespace LibraryTestUnit
{
    [TestClass]
    public class EditionUnitTests
    {
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var alice = CreateTestEdition();
            Assert.AreEqual("Alice's Adventures in Wonderland", alice.Title);
            Assert.AreEqual("Lewis Carroll", alice.ListOfAuthors);
            Assert.AreEqual(2020, alice.YearPublished);
            Assert.AreEqual("CreateSpace Independent Publishing Platform", alice.Publisher);
            Assert.AreEqual(165329768432, alice.UniqueID);
            Assert.AreEqual(Location.Storage, alice.WhereBook);
        }
        [TestMethod]
        public void ToStringTestMethod()
        {
            var alice = CreateTestEdition();
            Assert.AreEqual("Книга: Alice's Adventures in Wonderland. Автор(ы): Lewis Carroll.", alice.ToString());
        }
        [TestMethod]
        public void PrintInfoTestMethod()
        {
            
            var alice = CreateTestEdition();
            var sherlock = new Edition("Sherlock Holmes", "Arthur Conan Sir Doyle", 1986, "Bantam Classics", 147852369, Location.Home);
            var consoleOut = new[] { "Книга: Alice's Adventures in Wonderland. Автор(ы): Lewis Carroll.", $"Год издания: 2020. Издатель: CreateSpace Independent Publishing Platform. Инвентарный номер: 165329768432. Статус: в хранилище.", "Книга: Sherlock Holmes. Автор(ы): Arthur Conan Sir Doyle.", $"Год издания: 1986. Издатель: Bantam Classics. Инвентарный номер: 147852369. Статус: выдана на дом." };


            TextWriter oldOut = Console.Out;
            StringWriter output = new StringWriter();
            Console.SetOut(output); 
            alice.PrintInfo();
            sherlock.PrintInfo();
            Console.SetOut(oldOut); 
            var outputArray = output.ToString().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); 

         
            Assert.AreEqual(4, outputArray.Length);
            for (var i = 0; i < consoleOut.Length; i++)
                Assert.AreEqual(consoleOut[i], outputArray[i]);
        }
        private Edition CreateTestEdition()
        {
            return new Edition("Alice's Adventures in Wonderland", "Lewis Carroll", 2020, "CreateSpace Independent Publishing Platform", 165329768432, Location.Storage);
        }
    }
}

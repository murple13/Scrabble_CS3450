using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Server.Tests
{
    [TestClass()]
    public class DictionaryTests
    {
        [TestMethod()]
        public void DictionaryTest()
        {
            Dictionary dictionary = new Dictionary("dictionary.txt");
            Assert.IsTrue(dictionary.containsWord("any"));
        }

        [TestMethod()]
        public void containsWordTest()
        {
            Dictionary dictionary = new Dictionary("dictionary.txt");
            Assert.IsTrue(dictionary.containsWord("ball"));
            Assert.IsFalse(dictionary.containsWord("jsjsjsjsjs"));
        }
    }
}
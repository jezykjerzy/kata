using NUnit.Framework;
using Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
    [TestFixture()]
    public class SortArrayByStringLengthTests
    {
        [Test()]
        public void SortByLengthTest()
        {
            Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, SortArrayByStringLength.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
            Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, SortArrayByStringLength.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
            Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, SortArrayByStringLength.SortByLength(new string[] { "Longer", "Longest", "Short" }));
        }
    }
}
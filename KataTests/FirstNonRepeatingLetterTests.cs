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
    public class FirstNonRepeatingLetterTests
    {
        [Test()]
        public void FirstNonRepeatingLetterInSentenceTest()
        {
            Assert.AreEqual("a", FirstNonRepeatingLetter.FirstNonRepeatingLetterInSentence("abb"));
            Assert.AreEqual("t", FirstNonRepeatingLetter.FirstNonRepeatingLetterInSentence("stress"));
            Assert.AreEqual("e", FirstNonRepeatingLetter.FirstNonRepeatingLetterInSentence("moonmen"));
            Assert.AreEqual("", FirstNonRepeatingLetter.FirstNonRepeatingLetterInSentence(""));
            Assert.AreEqual("", FirstNonRepeatingLetter.FirstNonRepeatingLetterInSentence("aaaaa"));
        }
    }
}
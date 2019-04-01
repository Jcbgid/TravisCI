using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }


        [Test]
        public void Add()
        {
            Assert.AreEqual(Program.Add("1", "2"), 3);
            Assert.AreEqual(Program.Add("2", "3"), 5);
            Assert.AreEqual(Program.Add("3", "4"), 7);
        }


        [Test]
        public void Mult()
        {
            Assert.AreEqual(Program.Multiply("1", "2"), 2);
            Assert.AreEqual(Program.Multiply("2", "3"), 6);
            Assert.AreEqual(Program.Multiply("3", "4"), 12);
        }


        [Test]
        public void Subtract()
        {
            Assert.AreEqual(Program.Subtract("1", "2"), -1);
            Assert.AreEqual(Program.Subtract("2", "3"), -1);
            Assert.AreEqual(Program.Subtract("3", "4"), -1);
        }



        [Test]
        public void Pow()
        {
            Assert.AreEqual(Program.Power("1", "2"), 1);
            Assert.AreEqual(Program.Power("2", "3"), 8);
            Assert.AreEqual(Program.Power("3", "4"), 81);
        }


    }
}

using System;
using static HomeWork2.Program;

namespace TestHomeWork2
{
    public class Tests
    {
        [Test]
        public void WhereTest()
        {
            Assert.That(Where(new int[] { 1, 2, 3, 4, 5 }, Odd), Is.EqualTo(new int[] { 1, 3, 5 }));
            Assert.That(Where(new int[] { 1, 2, 3, 4, 5 }, Even), Is.EqualTo(new int[] { 2, 4 }));
        }
        [Test]
        public void FlipHalvesTest() 
        {
            Assert.That(FlipHalves(new int[] { 1, 2, 3, 4 }), Is.EqualTo(new int[] { 3, 4, 1, 2 }));
        }
    }
}
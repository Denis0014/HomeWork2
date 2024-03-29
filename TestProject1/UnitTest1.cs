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
            Assert.That(FlipHalves(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(new int[] { 3, 4, 5, 1, 2 }));
            Assert.That(FlipHalves(new int[] { }), Is.EqualTo(new int[] { }));
        }
        [Test]
        public void SpliffingTest()
        {
            Assert.That(Spliffing(new int[,] { { 1, 2 }, { 3, 4 } }), Is.EqualTo(new int[,] { { 1, 2 }, { 4, 3 } }));
            Assert.That(Spliffing(new int[,] { }), Is.EqualTo(new int[,] { }));
        }
        [Test]
        public void MaxSumRowTest()
        {
            Assert.That(MaxSumRow(new int[,] { { 1, 2 }, { 3, 4 } }), Is.EqualTo((1, 7)));
            Assert.That(MaxSumRow(new int[,] { }), Is.EqualTo((0, 0)));
        }
        [Test]
        public void MaxAverageTest()
        {
            Assert.That(MaxAverage(new int[][] { new int[] { 1, 2 } , new int[] { 3, 4 } }), Is.EqualTo(3.5));
            Assert.That(MaxAverage(new int[][] { }), Is.EqualTo(0));
        }
    }
}
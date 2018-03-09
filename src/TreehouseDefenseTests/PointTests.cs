using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreehouseDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense.Tests
{
    [TestClass()]
    public class PointTests
    {
        [TestMethod()]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

            Assert.AreEqual(x, point.X);
            Assert.AreEqual(y, point.Y);
        }

        [TestMethod()]
        public void DistanceToWithPythagoreanTriple()
        {
            var point = new Point(3, 4);
            var target = new Point(0, 0);

            var expected = 5.0;

            var actual = target.DistanceTo(point);

            Assert.AreEqual(expected, actual, 2);
        }

        [TestMethod()]
        public void DistanceToPointAtSamePosition()
        {
            var point = new Point(3, 4);
            var target = new Point(3, 4);

            var expected = 0.0;

            var actual = target.DistanceTo(point);

            Assert.AreEqual(expected, actual, 2);
        }

        [TestMethod()]
        public void DoesNotEqualNull()
        {
            var target = new Point(0, 0);
            Assert.IsFalse(target.Equals(null));
        }

        [TestMethod()]
        public void DistinctObjectsAreEqual()
        {
            var target = new Point(4, 5);
            Assert.IsTrue(target.Equals(new Point(4, 5)));
        }

        [TestMethod()]
        public void PointsAreNotEqual()
        {
            var target = new Point(4, 5);
            Assert.IsFalse(target.Equals(new Point(4, 6)));
        }

        
        [TestMethod()]
        public void SimilarPointsHaveDifferentHashCodes1()
        {
            var target = new Point(4, 5);
            Assert.AreNotEqual(new Point(5, 4).GetHashCode(), target.GetHashCode());
        }

        [TestMethod()]
        public void SimilarPointsHaveDifferentHashCodes2()
        {
            var target = new Point(4, 5);
            Assert.AreNotEqual(new Point(4, 6).GetHashCode(), target.GetHashCode());
        }

        [TestMethod()]
        public void EqualPointsHaveSameHashCodes()
        {
            var target = new Point(4, 5);
            Assert.AreEqual(new Point(4, 5).GetHashCode(), target.GetHashCode());
        }
        



    }
}
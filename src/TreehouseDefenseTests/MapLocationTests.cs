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
    public class MapLocationTests
    {
        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void ShouldThrowIfNotOnMap()
        {
            var map = new Map(3, 3);
            new MapLocation(3, 3, map);
        }

        [TestMethod()]
        public void InRangeOfWithRange1()
        {
            var map = new Map(3, 3);
            var target = new MapLocation(0, 0, map);
            Assert.IsTrue(target.InRangeOf(new MapLocation(0, 1, map), 1));
        }
    }
}
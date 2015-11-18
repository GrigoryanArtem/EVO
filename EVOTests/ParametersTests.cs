using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVO.Parameters;

namespace EVOTests
{
    [TestClass]
    public class EVOTests
    {
        [TestMethod]
        public void CoordinateArithmeticTest()
        {
            Coordinate a = new Coordinate(0, 0);
            Coordinate b = new Coordinate(10, -15);
            Coordinate c;

            c = a + b;

            Assert.AreEqual(new Coordinate(10, -15), c);

            c = a - b;

            Assert.AreEqual(new Coordinate(-10, 15), c);

            c = -a;

            Assert.AreEqual(a, c);

            c = -b;
            Assert.AreEqual(new Coordinate(-10, 15), c);
        }

        [TestMethod]
        public void NullCoordinateTest()
        {
            Coordinate a = new Coordinate(0,0);

            Assert.IsFalse(a.IsNull());

            a = new NullCoordinate();

            Assert.IsTrue(a.IsNull());
        }
    }
}

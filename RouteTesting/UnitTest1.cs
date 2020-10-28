using NUnit.Framework;
using IDU.Point;
using System;

namespace RouteTesting
{
    public class Tests
    {
        private Route route;
        [SetUp]
        public void Setup()
        {
            route = new Route();
        }

        [Test]
        public void TestCreateRoute()
        {
            Assert.IsNotNull(route);
        }

        [Test]
        public void TestAddPoint()
        {
            route.add_point(2, 4, 0);
            int expectedCount = 1;
            int actual = route.points.Count;
            Assert.AreEqual(expectedCount, actual);            
        }

        [Test]
        public void TestRemovePoint()
        {
            route.remove_point(0);
            int expectedCount = 0;
            int actual = route.points.Count;
            Assert.AreEqual(expectedCount, actual);
        }

        [Test]
        public void TestGetLength()
        {
            route.add_point(1, 1,0);
            route.add_point(200, 1, 0);
            double expectedLength = 199;
            double actualLength = route.get_length();
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
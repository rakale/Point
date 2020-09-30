using NUnit.Framework;
using IDU.Point;
using System;

namespace PointTesting
{
    public class Tests
    {
        private Point TestPointA;
        [SetUp]
        public void Setup()
        {
            TestPointA = new Point(2, 4);
        }

        [Test]
        public void TestX()
        {
            double expected = 2;
            double result = TestPointA.X();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestY()
        {
            double expected = 4;
            double result = TestPointA.Y();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestRho()
        {
            double expected = 4.472;
            double result = TestPointA.Rho();
            Assert.AreEqual(expected, result,0.01);
        }

        [Test]
        public void TestTheta()
        {
            double expected = 1.107;
            double result = TestPointA.Theta();
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void TestVectorTo()
        {
            Point TestPointB = new Point(20, 10);
            Point C = TestPointA.vectorTo(TestPointB);
            double expectedX = 18;
            double expectedY = 6;
            Assert.AreEqual(expectedX, C.X());
            Assert.AreEqual(expectedY, C.Y());
        }

        [Test]
        public void TestDistance()
        {
            Point TestPointB = new Point(20, 10);
            double expected = 18.97;
            double result = TestPointA.Distance(TestPointB);
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void TestTranslate()
        {
            Point expected = new Point(10, 10);
            TestPointA.Translate(8, 6);

            Assert.AreEqual(expected.X(), TestPointA.X());
            Assert.AreEqual(expected.Y(), TestPointA.Y());
        }

        [Test]
        public void TestScale()
        {
            Point expected = new Point(20, 40);
            TestPointA.Scale(10);

            Assert.AreEqual(expected.X(), TestPointA.X());
            Assert.AreEqual(expected.Y(), TestPointA.Y());
        }

        [Test]
        public void TestCentre_Rotate()
        {
            TestPointA.Centre_Rotate(0.5);
            Point expected = new Point(-0.162, 4.469);
            Assert.AreEqual(expected.X(),TestPointA.X(),0.01);
            Assert.AreEqual(expected.Y(),TestPointA.Y(),0.01);
        }
        
        [Test]
        public void TestRotate()
        {
            Point TestPointA = new Point(10, 20);
            Point TestPointB = new Point(-20, 60);
            TestPointA.Rotate(TestPointB,Math.PI/3);
            double expectedX = 29.64;
            double expectedY = 65.98;

            Assert.AreEqual(expectedX,TestPointA.X(),0.01);
            Assert.AreEqual(expectedY,TestPointA.Y(),0.01);
        }
    }
}
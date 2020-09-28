using NUnit.Framework;
using IDU.Point;

namespace PointTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestX()
        {
            Point TestPointA = new Point(2, 4);
            double expected = 2;
            double result = TestPointA.X();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestY()
        {
            Point TestPointA = new Point(2, 4);
            double expected = 4;
            double result = TestPointA.Y();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestRho()
        {
            Point TestPointA = new Point(2, 4);
            double expected = 4.472;
            double result = TestPointA.Rho();
            Assert.AreEqual(expected, result,0.01);
        }

        [Test]
        public void TestTheta()
        {
            Point TestPointA = new Point(2, 4);
            double expected = 1.107;
            double result = TestPointA.Theta();
            Assert.AreEqual(expected, result, 0.01);
        }

        [Test]
        public void TestDistance()
        {
            Point TestPointA = new Point(2, 4);
            Point TestPointB = new Point(20, 10);
            double expected = 18.97;
            double result = TestPointA.Distance(TestPointB);
            Assert.AreEqual(expected, result, 0.01);
        }

        //[Test]
        //public void TestVectorTo()
        //{
        //    Point TestPointA = new Point(2, 4);
        //    Point TestPointB = new Point(20, 10);
        //    Point expected = 
        //    double result = TestPointA.Distance(TestPointB);
        //    Assert.AreEqual(expected, result, 0.01);
        //}

        [Test]
        public void TestTranslate()
        {
            Point TestPointA = new Point(2, 4);
            Point expected = new Point(10, 10);
            TestPointA.Translate(8, 6);

            Assert.AreEqual(expected.X(), TestPointA.X());
            Assert.AreEqual(expected.Y(), TestPointA.Y());
        }

        [Test]
        public void TestScale()
        {
            Point TestPointA = new Point(2, 4);
            Point expected = new Point(20, 40);
            TestPointA.Scale(10);

            Assert.AreEqual(expected.X(), TestPointA.X());
            Assert.AreEqual(expected.Y(), TestPointA.Y());
        }

        [Test]
        public void TestCentre_Rotate()
        {
            Point TestPointA = new Point(2, 4);
            TestPointA.Centre_Rotate(0.5);
            Point expected = new Point(-0.162, 4.469);
            Assert.AreEqual(expected.X(),TestPointA.X(),0.01);
            Assert.AreEqual(expected.Y(),TestPointA.Y(),0.01);
        }
    }
}
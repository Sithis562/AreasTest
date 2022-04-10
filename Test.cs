using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreasTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Area_3and4and5_6returned()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            double actual = Areas.Triangle.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_5and5and8_12returned()
        {
            double a = 5;
            double b = 5;
            double c = 8;
            double expected = 12;

            double actual = Areas.Triangle.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_25and15and20_150returned()
        {
            double a = 25;
            double b = 15;
            double c = 20;
            double expected = 150;

            double actual = Areas.Triangle.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Area_5_78returned()
        {
            double r = 5;
            double expected = 78.53981633974483;

            double actual = Areas.Circle.Area(r);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_48_7238returned()
        {
            double r = 48;
            double expected = 7238.229473870883;

            double actual = Areas.Circle.Area(r);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_9_254returned()
        {
            double r = 9;
            double expected = 254.46900494077323;

            double actual = Areas.Circle.Area(r);

            Assert.AreEqual(expected, actual);
        }
    }
}

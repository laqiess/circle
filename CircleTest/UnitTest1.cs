
using Circle;
namespace CircleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            CircleClass f1 = new CircleClass(1);
            Assert.AreEqual(3.14159265358979, f1.get_area(),0.0001);
            Assert.AreEqual(6.28318530717959, f1.get_circum(),0.0001);
            Assert.AreEqual(2, f1.get_diameter());

            CircleClass f2 = new CircleClass(2);
            Assert.AreEqual(12.5663706143592, f2.get_area(), 0.0001);
            Assert.AreEqual(12.5663706143592, f2.get_circum(), 0.0001);
            Assert.AreEqual(4, f2.get_diameter());

            CircleClass f3 = new CircleClass(9);
            Assert.AreEqual( 254.469004940773, f3.get_area(), 0.0001);
            Assert.AreEqual(56.5486677646163, f3.get_circum(), 0.0001);
            Assert.AreEqual(18, f3.get_diameter());
        }

        [TestMethod]
        public void TestMethod_set_get()
        {
            CircleClass f1 = new CircleClass();
            f1.setradius(5);
            Assert.AreEqual(78.5398163397448, f1.get_area(), 0.0001);
            Assert.AreEqual(31.4159265358979, f1.get_circum(), 0.0001);
            Assert.AreEqual(10, f1.get_diameter());

            CircleClass f2 = new CircleClass();
            f2.setradius(3);
            Assert.AreEqual(28.2743338823081, f2.get_area(), 0.0001);
            Assert.AreEqual(18.8495559215388, f2.get_circum(), 0.0001);
            Assert.AreEqual(6, f2.get_diameter());

            CircleClass f3 = new CircleClass();
            f3.setradius(7);
            Assert.AreEqual(153.93804002589985, f3.get_area(), 0.0001);
            Assert.AreEqual(43.982297150257104, f3.get_circum(), 0.0001);
            Assert.AreEqual(14, f3.get_diameter());
        }
        [TestMethod]
        public void TestMethod_to_string()
        {
            CircleClass f1 = new CircleClass(5);
            Assert.AreEqual("diameter: " + 10 +
                "\ncircum: " + 31.42 +
            "\narea: " + 78.54, f1.ToString());

            CircleClass f2 = new CircleClass(7);
            Assert.AreEqual("diameter: " + 14.00 +
                "\ncircum: " + 43.98 +
            "\narea: " + 153.94, f2.ToString());

            CircleClass f3 = new CircleClass(3);
            Assert.AreEqual("diameter: " + 6.00 +
                "\ncircum: " + 18.85 +
            "\narea: " + 28.27, f3.ToString());
        }
    }
}
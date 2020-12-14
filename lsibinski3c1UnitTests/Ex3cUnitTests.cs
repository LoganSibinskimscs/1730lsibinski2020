using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lsibinski3c1;

namespace lsibinski3c1UnitTests
{
    [TestClass]
    public class Ex3cUnitTests
    {
        [TestMethod]
        public void Calc0_IndexBelowRange()
        {
            Assert.AreEqual("Invalid index", Ex3cCalculations.Calc0(0));
        }
        [TestMethod]
        public void Calc0_IndexAboveRange()
        {
            Assert.AreEqual("Invalid index", Ex3cCalculations.Calc0(8));
        }
        [TestMethod]
        public void Calc0_Sunday()
        {
            Assert.AreEqual("Sunday", Ex3cCalculations.Calc0(1));
        }
        [TestMethod]
        public void Calc0_Saturday()
        {
            Assert.AreEqual("Saturday", Ex3cCalculations.Calc0(7));
        }
        [TestMethod]
        public void Calc1_SearchStringNotFound()
        {
            Assert.AreEqual("Invalid input", Ex3cCalculations.Calc1(""));
        }
        [TestMethod]
        public void Calc1_Sunday()
        {
            Assert.AreEqual("Closed", Ex3cCalculations.Calc1(" sUnDAy "));
        }
        [TestMethod]
        public void Calc1_Saturday()
        {
            Assert.AreEqual("8am - 4pm", Ex3cCalculations.Calc1(" saTuRDAy "));
        }
        [TestMethod]
        public void Calc2()
        {
            int[] numbers = { 2, 16, 7, 22, 35 };
            Assert.AreEqual(82, Ex3cCalculations.Calc2(numbers));
        }
        [TestMethod]
        public void Calc3_InvalidCount()
        {
            double[] numbers = { 2.3, 16.1, 7.9, 22.3, 35.4 };
            Assert.AreEqual(0.0, Ex3cCalculations.Calc3(numbers, -1));
        }
        [TestMethod]
        public void Calc3_Count4of5()
        {
            double[] numbers = { 2.3, 16.1, 7.9, 22.3, 35.4 };
            Assert.AreEqual(48.6, Math.Round(Ex3cCalculations.Calc3(numbers, 4), 1));
        }
        [TestMethod]
        public void Calc5()
        {
            double[] numbers = { 2.3, 16.1, 7.9, 22.3, 35.4 };
            Assert.AreEqual(16.8, Math.Round(Ex3cCalculations.Calc5(numbers), 2));
        }
        [TestMethod]
        public void Calc6()
        {
            double[] numbers = { 2.3, 16.1, 7.9, 22.3, 35.4 };
            double[] aboveAvg = Ex3cCalculations.Calc6(numbers);
            Assert.AreEqual(22.3, aboveAvg[0]);
            Assert.AreEqual(35.4, aboveAvg[1]);
        }
    }
}

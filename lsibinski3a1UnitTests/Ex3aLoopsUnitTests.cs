using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lsibinski3a1;

namespace lsibinski3a1UnitTests
{
    [TestClass]
    public class Ex3aLoopsUnitTests
    {
        [TestMethod]
        public void Calc0_InvalidMonths()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc0("", "100.0", "0.005"));
        }
        [TestMethod]
        public void Calc0_InvalidPayment()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc0("24", "", "0.005"));
        }
        [TestMethod]
        public void Calc0_InvalidRate()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc0("24", "100.0", ""));
        }
        [TestMethod]
        public void Calc0_12Mo100US()
        {
            Assert.AreEqual("1,231.66", Ex3aLoops.Calc0("12", "100.0", "0.004"));
        }
        [TestMethod]
        public void Calc0_120Mo20US()
        {
            Assert.AreEqual("2,892.37", Ex3aLoops.Calc0("120", "20.0", "0.003"));
        }
        [TestMethod]
        public void Calc0_0Mo100US()
        {
            Assert.AreEqual("0.00", Ex3aLoops.Calc0("0", "100.0", "0.005"));
        }
        [TestMethod]
        public void Calc1_InvalidMonths()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc1("", "100.0", "0.005"));
        }
        [TestMethod]
        public void Calc1_InvalidPayment()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc1("24", "", "0.005"));
        }
        [TestMethod]
        public void Calc1_InvalidRate()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc1("24", "100.0", ""));
        }
        [TestMethod]
        public void Calc1_12Mo100US()
        {
            Assert.AreEqual("1,231.66", Ex3aLoops.Calc1("12", "100.0", "0.004"));
        }
        [TestMethod]
        public void Calc1_120Mo20US()
        {
            Assert.AreEqual("2,892.37", Ex3aLoops.Calc1("120", "20.0", "0.003"));
        }
        [TestMethod]
        public void Calc1_0Mo100US()
        {
            Assert.AreEqual("100.50", Ex3aLoops.Calc1("0", "100.0", "0.005"));
        }
        [TestMethod]
        public void Calc2_InvalidMonths()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc2("", "100.0", "0.005"));
        }
        [TestMethod]
        public void Calc2_InvalidPayment()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc2("24", "", "0.005"));
        }
        [TestMethod]
        public void Calc2_InvalidRate()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc2("24", "100.0", ""));
        }
        [TestMethod]
        public void Calc2_12Mo100US()
        {
            Assert.AreEqual("1,231.66", Ex3aLoops.Calc2("12", "100.0", "0.004"));
        }
        [TestMethod]
        public void Calc2_120Mo20US()
        {
            Assert.AreEqual("2,892.37", Ex3aLoops.Calc2("120", "20.0", "0.003"));
        }
        [TestMethod]
        public void Calc2_0Mo100US()
        {
            Assert.AreEqual("0.00", Ex3aLoops.Calc2("0", "100.0", "0.005"));
        }
        [TestMethod]
        public void Calc3_InvalidStart()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc3("", "10", "3"));
        }
        [TestMethod]
        public void Calc3_InvalidEnd()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc3("3", "", "3"));
        }
        [TestMethod]
        public void Calc3_InvalidIncrement()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc3("3", "10", ""));
        }
        [TestMethod]
        public void Calc3_IncrementLE0()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc3("3", "10", "0"));
        }
        [TestMethod]
        public void Calc3_Start3End10Incr3()
        {
            Assert.AreEqual("3 6 9 ", Ex3aLoops.Calc3("3", "10", "3"));
        }
        [TestMethod]
        public void Calc3_Start3End0Incr3()
        {
            Assert.AreEqual("", Ex3aLoops.Calc3("3", "0", "3"));
        }
        [TestMethod]
        public void Calc3_Start4End20Incr5()
        {
            Assert.AreEqual("4 9 14 19 ", Ex3aLoops.Calc3("4", "20", "5"));
        }
        [TestMethod]
        public void Calc4_InvalidStart()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc4("", "10", "3"));
        }
        [TestMethod]
        public void Calc4_InvalidEnd()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc4("3", "", "3"));
        }
        [TestMethod]
        public void Calc4_InvalidIncrement()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc4("3", "10", ""));
        }
        [TestMethod]
        public void Calc4_IncrementLE0()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc4("3", "10", "0"));
        }
        [TestMethod]
        public void Calc4_Start3End10Incr3()
        {
            Assert.AreEqual("3 6 9 ", Ex3aLoops.Calc4("3", "10", "3"));
        }
        [TestMethod]
        public void Calc4_Start4End20Incr5()
        {
            Assert.AreEqual("4 9 14 19 ", Ex3aLoops.Calc4("4", "20", "5"));
        }
        [TestMethod]
        public void Calc4_Start3End0Incr3()
        {
            Assert.AreEqual("3 ", Ex3aLoops.Calc4("3", "0", "3"));
        }
        [TestMethod]
        public void Calc5_InvalidStart()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc5("", "10", "3"));
        }
        [TestMethod]
        public void Calc5_InvalidEnd()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc5("3", "", "3"));
        }
        [TestMethod]
        public void Calc5_InvalidIncrement()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc5("3", "10", ""));
        }
        [TestMethod]
        public void Calc5_IncrementLE0()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc5("3", "10", "0"));
        }
        [TestMethod]
        public void Calc5_Start3End10Incr3()
        {
            Assert.AreEqual("3 6 9 ", Ex3aLoops.Calc5("3", "10", "3"));
        }
        [TestMethod]
        public void Calc5_Start3End0Incr3()
        {
            Assert.AreEqual("", Ex3aLoops.Calc5("3", "0", "3"));
        }
        [TestMethod]
        public void Calc5_Start4End20Incr5()
        {
            Assert.AreEqual("4 9 14 19 ", Ex3aLoops.Calc5("4", "20", "5"));
        }
        [TestMethod]
        public void Calc6_InvalidNumbers()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc6("10 a12 14 16 ", "4"));
        }
        [TestMethod]
        public void Calc6_InvalidCount1()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc6("10 12 14 16 ", "1a"));
        }
        [TestMethod]
        public void Calc6_InvalidCount2()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc6("11 29 32 48 ", "5"));
        }
        [TestMethod]
        public void Calc6_Sum100()
        {
            Assert.AreEqual("100", Ex3aLoops.Calc6("11 29 32 28 ", "4"));
        }
        [TestMethod]
        public void Calc6_Sum200()
        {
            Assert.AreEqual("200", Ex3aLoops.Calc6("21 39 42 58 33 7 ", "6"));
        }
        [TestMethod]
        public void Calc6_Sum0()
        {
            Assert.AreEqual("0", Ex3aLoops.Calc6("21 39 42 58 33 7 ", "0"));
        }
        [TestMethod]
        public void Calc7_InvalidNumbers()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc7("10 a12 14 16 ", "4"));
        }
        [TestMethod]
        public void Calc7_InvalidCount1()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc7("10 12 14 16 ", "1a"));
        }
        [TestMethod]
        public void Calc7_InvalidCount2()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc7("11 29 32 48 ", "5"));
        }
        [TestMethod]
        public void Calc7_Sum100()
        {
            Assert.AreEqual("100", Ex3aLoops.Calc7("11 29 32 28 ", "4"));
        }
        [TestMethod]
        public void Calc7_Sum200()
        {
            Assert.AreEqual("200", Ex3aLoops.Calc7("21 39 42 58 33 7 ", "6"));
        }
        [TestMethod]
        public void Calc7_Sum0()
        {
            Assert.AreEqual("21", Ex3aLoops.Calc7("21 39 42 58 33 7 ", "0"));
        }
        [TestMethod]
        public void Calc8_InvalidNumbers()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc8("10 a12 14 16 ", "4"));
        }
        [TestMethod]
        public void Calc8_InvalidCount1()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc8("10 12 14 16 ", "1a"));
        }
        [TestMethod]
        public void Calc8_InvalidCount2()
        {
            Assert.AreEqual("Invalid input", Ex3aLoops.Calc8("11 29 32 48 ", "5"));
        }
        [TestMethod]
        public void Calc8_Sum100()
        {
            Assert.AreEqual("100", Ex3aLoops.Calc8("11 29 32 28 ", "4"));
        }
        [TestMethod]
        public void Calc8_Sum200()
        {
            Assert.AreEqual("200", Ex3aLoops.Calc8("21 39 42 58 33 7 ", "6"));
        }
        [TestMethod]
        public void Calc8_Sum0()
        {
            Assert.AreEqual("0", Ex3aLoops.Calc8("21 39 42 58 33 7 ", "0"));
        }
    }
}

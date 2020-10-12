using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using lsibinski2f1;

namespace lsibinski2f1UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class Ex2fUnitTests
        {
            [TestMethod]
            public void Test01AInputGE100()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc01("100.0"));
            }
            [TestMethod]
            public void Test01AInputLT100()
            {
                Assert.AreEqual("0.00", Ex2fCalculations.Calc01("99.99"));
            }
            [TestMethod]
            public void Test02AInputGE100()
            {
                Assert.AreEqual("Bulk rate: 0.20", Ex2fCalculations.Calc02("100.00"));
            }
            [TestMethod]
            public void Test02AInputLT100()
            {
                Assert.AreEqual("Standard rate: ", Ex2fCalculations.Calc02("99.99"));
            }
            [TestMethod]
            public void Test03AInputGE100()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc03("100.00"));
            }
            [TestMethod]
            public void Test03AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc03("99.99"));
            }
            [TestMethod]
            public void Test04AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc04("99.99"));
            }
            [TestMethod]
            public void Test04AInputGE100LT200A()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc04("100.00"));
            }
            [TestMethod]
            public void Test04AInputGE100LT200B()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc04("199.99"));
            }
            [TestMethod]
            public void Test04AInputGE200LT300A()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc04("200.00"));
            }
            [TestMethod]
            public void Test04AInputGE200LT300B()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc04("299.99"));
            }
            [TestMethod]
            public void Test04AInputGE300()
            {
                Assert.AreEqual("0.40", Ex2fCalculations.Calc04("300.00"));
            }
            [TestMethod]
            public void Test05AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc05("99.99"));
            }
            [TestMethod]
            public void Test05AInputGE100LT200A()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc05("100.00"));
            }
            [TestMethod]
            public void Test05AInputGE100LT200B()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc05("199.99"));
            }
            [TestMethod]
            public void Test05AInputGE200LT300A()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc05("200.00"));
            }
            [TestMethod]
            public void Test05AInputGE200LT300B()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc05("299.99"));
            }
            [TestMethod]
            public void Test05AInputGE300()
            {
                Assert.AreEqual("0.40", Ex2fCalculations.Calc05("300.00"));
            }
            [TestMethod]
            public void Test06AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc06("99.99", "R"));
            }
            [TestMethod]
            public void Test06AInputGE100LT200A()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc06("100.00", "R"));
            }
            [TestMethod]
            public void Test06BInputNotR()
            {
                Assert.AreEqual("0.40", Ex2fCalculations.Calc06("100.00", "Z"));
            }
            [TestMethod]
            public void Test07AInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc07(""));
            }
            [TestMethod]
            public void Test07AInput100()
            {
                Assert.AreEqual("20,000.00", Ex2fCalculations.Calc07("100.00"));
            }
            [TestMethod]
            public void Test08AInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc08("", "2.00"));
            }
            [TestMethod]
            public void Test08BInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc08("25.00", ""));
            }
            [TestMethod]
            public void Test08TotalLT50()
            {
                Assert.AreEqual("54.98", Ex2fCalculations.Calc08("24.99", "2.00"));
            }
            [TestMethod]
            public void Test08TotalGE50()
            {
                Assert.AreEqual("50.00", Ex2fCalculations.Calc08("25.00", "2.00"));
            }
            [TestMethod]
            public void Test09AInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc09("", "11000"));
            }
            [TestMethod]
            public void Test09BInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc09("10000", ""));
            }
            [TestMethod]
            public void Test09A_GT_BInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc09("11000", "10000"));
            }
            [TestMethod]
            public void Test0ValidDiff1000()
            {
                Assert.AreEqual("100.00", Ex2fCalculations.Calc09("10000", "11000"));
            }
            [TestMethod]
            public void Test10AInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc10("", "2"));
            }
            [TestMethod]
            public void Test10BInputEmpty()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc10("2", ""));
            }
            [TestMethod]
            public void Test10InputA0()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc10("0", "1"));
            }
            [TestMethod]
            public void Test10InputB0()
            {
                Assert.AreEqual("Invalid input", Ex2fCalculations.Calc10("1", "0"));
            }
            [TestMethod]
            public void Test10Valid4Div2()
            {
                Assert.AreEqual("2.00", Ex2fCalculations.Calc10("4", "2"));
            }
            [TestMethod]
            public void Test10Valid2Div4()
            {
                Assert.AreEqual("2.00", Ex2fCalculations.Calc10("2", "4"));
            }
            [TestMethod]
            public void Test10Valid4Div4()
            {
                Assert.AreEqual("1.00", Ex2fCalculations.Calc10("4", "4"));
            }
        }
    }
}

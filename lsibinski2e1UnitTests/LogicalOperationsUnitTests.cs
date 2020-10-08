using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using lsibinski2e1;

namespace lsibinski2e1UnitTests
{
    [TestClass]
    public class LogicalOperationsUnitTests
    {
            [TestMethod]
            public void TestQ01BelowRange()
            {
                Assert.IsFalse(LogicalOperations.q01(249));
            }
            [TestMethod]
            public void TestQ01AtMin()
            {
                Assert.IsTrue(LogicalOperations.q01(250));
            }
            [TestMethod]
            public void TestQ01AtMax()
            {
                Assert.IsTrue(LogicalOperations.q01(499));
            }
            [TestMethod]
            public void TestQ01AboveRange()
            {
                Assert.IsFalse(LogicalOperations.q01(500));
            }
            [TestMethod]
            public void TestQ02BelowRange()
            {
                Assert.IsTrue(LogicalOperations.q02(4));
            }
            [TestMethod]
            public void TestQ02BottomOfExcludedRange()
            {
                Assert.IsFalse(LogicalOperations.q02(5));
            }
            [TestMethod]
            public void TestQ02TopOfExcludedRange()
            {
                Assert.IsFalse(LogicalOperations.q02(11));
            }
            [TestMethod]
            public void TestQ02AboveRange()
            {
                Assert.IsTrue(LogicalOperations.q02(12));
            }
            [TestMethod]
            public void TestQ03Invalid()
            {
                Assert.IsFalse(LogicalOperations.q03(false, 0, 0));
            }
            [TestMethod]
            public void TestQ03CounterLessThanYears()
            {
                Assert.IsTrue(LogicalOperations.q03(true, 1, 0));
            }
            [TestMethod]
            public void TestQ03CounterNotLessThanYears()
            {
                Assert.IsFalse(LogicalOperations.q03(true, 0, 0));
            }
            [TestMethod]
            public void TestQ04Invalid()
            {
                Assert.IsFalse(LogicalOperations.q04(false, 1, 0));
            }
            [TestMethod]
            public void TestQ04CounterLessThanYears()
            {
                Assert.IsTrue(LogicalOperations.q04(true, 1, 0));
            }
            [TestMethod]
            public void TestQ04CounterNotLessThanYears()
            {
                Assert.IsFalse(LogicalOperations.q04(true, 1, 1));
            }
            [TestMethod]
            public void TestQ05IsValidTrue()
            {
                Assert.IsTrue(LogicalOperations.q05(true, 0, 0));
            }
            [TestMethod]
            public void TestQ05CounterLessThanYears()
            {
                Assert.IsTrue(LogicalOperations.q05(false, 1, 0));
            }
            [TestMethod]
            public void TestQ05CounterNotLessThanYears()
            {
                Assert.IsFalse(LogicalOperations.q05(false, 0, 0));
            }
            [TestMethod]
            public void TestQ06IsValidTrue()
            {
                Assert.IsTrue(LogicalOperations.q06(true, 0, 0));
            }
            [TestMethod]
            public void TestQ06CounterLessThanYears()
            {
                Assert.IsTrue(LogicalOperations.q06(false, 1, 0));
            }
            [TestMethod]
            public void TestQ06CounterNotLessThanYears()
            {
                Assert.IsFalse(LogicalOperations.q06(false, 0, 0));
            }
            [TestMethod]
            public void TestQ07IsValidTrue()
            {
                Assert.IsTrue(LogicalOperations.q07(
                    DateTime.Parse("1/1/2019"),
                    DateTime.Parse("2/1/2019"),
                    DateTime.Parse("2/2/2019"),
                    true));
            }
            [TestMethod]
            public void TestQ07DateBelowRange()
            {
                Assert.IsFalse(LogicalOperations.q07(
                    DateTime.Parse("1/1/2019"),
                    DateTime.Parse("2/1/2019"),
                    DateTime.Parse("1/1/2019"),
                    false));
            }
            [TestMethod]
            public void TestQ07DateAtMinRange()
            {
                Assert.IsTrue(LogicalOperations.q07(
                    DateTime.Parse("1/1/2019"),
                    DateTime.Parse("2/1/2019"),
                    DateTime.Parse("1/2/2019"),
                    false));
            }
            [TestMethod]
            public void TestQ07DateAtMaxRange()
            {
                Assert.IsTrue(LogicalOperations.q07(
                    DateTime.Parse("1/1/2019"),
                    DateTime.Parse("2/1/2019"),
                    DateTime.Parse("1/31/2019"),
                    false));
            }
            [TestMethod]
            public void TestQ07DateAboveRange()
            {
                Assert.IsFalse(LogicalOperations.q07(
                    DateTime.Parse("1/1/2019"),
                    DateTime.Parse("2/1/2019"),
                    DateTime.Parse("2/1/2019"),
                    false));
            }
            [TestMethod]
            public void TestQ08PartTimeValidYears()
            {
                Assert.IsTrue(LogicalOperations.q08(
                    0, 0, "Part time", 2018, 2019));
            }
            [TestMethod]
            public void TestQ08ValidYTD_NotPartTime_ValidYears()
            {
                Assert.IsTrue(LogicalOperations.q08(
                    1, 0, "", 2018, 2019));
            }
            [TestMethod]
            public void TestQ08InvalidYTD_NotPartTime_ValidYears()
            {
                Assert.IsFalse(LogicalOperations.q08(
                    0, 0, "", 2018, 2019));
            }
            [TestMethod]
            public void TestQ08PartTime_InvalidYears()
            {
                Assert.IsFalse(LogicalOperations.q08(
                    0, 0, "Part time", 2019, 2019));
            }
            [TestMethod]
            public void TestQ09InvalidCounter()
            {
                Assert.IsFalse(LogicalOperations.q09(0, 0));
            }
            [TestMethod]
            public void TestQ09ValidCounter()
            {
                Assert.IsTrue(LogicalOperations.q09(0, 1));
            }

        [TestMethod]
        public void TestQ10ValidRanges()
        {
            Assert.IsTrue(LogicalOperations.q10(1, 2, 3, 4));
        }
        [TestMethod]
        public void TestQ10CNotLessThanD()
        {
            Assert.IsFalse(LogicalOperations.q10(1, 1, 4, 4));
        }
        [TestMethod]
        public void TestQ10CLessThanD()
        {
            Assert.IsTrue(LogicalOperations.q10(1, 1, 3, 4));
        }
        [TestMethod]
        public void TestQ10BInRange()
        {
            Assert.IsTrue(LogicalOperations.q10(2, 1, 3, 0));
        }
        [TestMethod]
        public void TestQ11NotFreeShipping()
        {
            Assert.IsFalse(LogicalOperations.q11(false, 24.99m, 1.1f));
        }
        [TestMethod]
        public void TestQ11FreeShippingToMembers()
        {
            Assert.IsTrue(LogicalOperations.q11(true, 24.99m, 1.1f));
        }
        [TestMethod]
        public void TestQ11FreeShippingOver25()
        {
            Assert.IsTrue(LogicalOperations.q11(false, 25m, 1.1f));
        }
        [TestMethod]
        public void TestQ11FreeShipping1OunceOrLess()
        {
            Assert.IsTrue(LogicalOperations.q11(false, 24.99m, 1.0f));
        }
        [TestMethod]
        public void TestQ12NotFreeShipping()
        {
            Assert.IsFalse(LogicalOperations.q12(false, 24.99m, 1.0f));
        }
        [TestMethod]
        public void TestQ12FreeShippingToMembers()
        {
            Assert.IsTrue(LogicalOperations.q12(true, 24.99m, 1.0f));
        }
        [TestMethod]
        public void TestQ12FreeShippingPriceOver25WeightUnder1()
        {
            Assert.IsTrue(LogicalOperations.q12(false, 25.0m, 0.99f));
        }
        [TestMethod]
        public void TestQ13NoTaxOutsideMN()
        {
            Assert.IsFalse(LogicalOperations.q13("AA", "Electronics"));
        }
        [TestMethod]
        public void TestQ13NoTaxNoTaxClothing()
        {
            Assert.IsFalse(LogicalOperations.q13("MN", "Clothing"));
        }
        [TestMethod]
        public void TestQ13NoTaxNoTaxFood()
        {
            Assert.IsFalse(LogicalOperations.q13("MN", "Food"));
        }
        [TestMethod]
        public void TestQ13TaxMN()
        {
            Assert.IsTrue(LogicalOperations.q13("MN", "Electronics"));
        }

    }
}


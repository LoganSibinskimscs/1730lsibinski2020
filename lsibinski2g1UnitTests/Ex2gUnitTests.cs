using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lsibinski2g1;

namespace lsibinski2g1UnitTests
{
    [TestClass]
    public class Ex2gUnitTests
    {
        [TestMethod]
        public void TestSwitch01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.Switch01("R"));
        }
        [TestMethod]
        public void TestSwitch01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.Switch01("C"));
        }
        [TestMethod]
        public void TestSwitch01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.Switch01("Z"));
        }
        [TestMethod]
        public void TestIf01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.If01("R"));
        }
        [TestMethod]
        public void TestIf01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.If01("C"));
        }
        [TestMethod]
        public void TestIf01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.If01("Z"));
        }
        [TestMethod]
        public void TestElseIf01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.ElseIf01("R"));
        }
        [TestMethod]
        public void TestElseIf01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIf01("C"));
        }
        [TestMethod]
        public void TestElseIf01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.ElseIf01("Z"));
        }
        [TestMethod]
        public void TestNestedIfElse01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.NestedIfElse01("R"));
        }
        [TestMethod]
        public void TestNestedIfElse01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIfElse01("C"));
        }
        [TestMethod]
        public void TestNestedIfElse01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.NestedIfElse01("Z"));
        }
        [TestMethod]
        public void TestSwitchDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.SwitchDefault01("R"));
        }
        [TestMethod]
        public void TestSwitchDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.SwitchDefault01("C"));
        }
        [TestMethod]
        public void TestSwitchDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.SwitchDefault01("Z"));
        }
        [TestMethod]
        public void TestIfDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.IfDefault01("R"));
        }
        [TestMethod]
        public void TestIfDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.IfDefault01("C"));
        }
        [TestMethod]
        public void TestIfDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.IfDefault01("Z"));
        }
        [TestMethod]
        public void TestElseIfDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.ElseIfDefault01("R"));
        }
        [TestMethod]
        public void TestElseIfDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIfDefault01("C"));
        }
        [TestMethod]
        public void TestElseIfDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.ElseIfDefault01("Z"));
        }
        [TestMethod]
        public void TestNestedIfElseDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.NestedIfElseDefault01("R"));
        }
        [TestMethod]
        public void TestNestedIfElseDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIfElseDefault01("C"));
        }
        [TestMethod]
        public void TestNestedIfElseDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.NestedIfElseDefault01("Z"));
        }
        [TestMethod]
        public void TestSwitch02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.Switch02("R"));
        }
        [TestMethod]
        public void TestSwitch02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.Switch02("C"));
        }
        [TestMethod]
        public void TestSwitch02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.Switch02("T"));
        }
        [TestMethod]
        public void TestSwitch02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.Switch02("Z"));
        }
        [TestMethod]
        public void TestIf02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.If02("R"));
        }
        [TestMethod]
        public void TestIf02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.If02("C"));
        }
        [TestMethod]
        public void TestIf02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.If02("T"));
        }
        [TestMethod]
        public void TestIf02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.If02("Z"));
        }
        [TestMethod]
        public void TestElseIf02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIf02("R"));
        }
        [TestMethod]
        public void TestElseIf02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIf02("C"));
        }
        [TestMethod]
        public void TestElseIf02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.ElseIf02("T"));
        }
        [TestMethod]
        public void TestElseIf02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.ElseIf02("Z"));
        }
        [TestMethod]
        public void TestNestedIfElse02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIfElse02("R"));
        }
        [TestMethod]
        public void TestNestedIfElse02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIfElse02("C"));
        }
        [TestMethod]
        public void TestNestedIfElse02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.NestedIfElse02("T"));
        }
        [TestMethod]
        public void TestNestedIfElse02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.NestedIfElse02("Z"));
        }
    }
}
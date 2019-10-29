using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input1 = new Class1() { One = "string" };
            var input2 = new Class1() { Two = "string B Two" };
            var test = Class2.returnBoolean(input1, input2);
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input1 = new Class1() { One = "string" };
            var input2 = new Class1() { One = "string B Two" };
            var test = Class2.returnBoolean(input1, input2);
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input1 = new Class1() { One = "string" };
            var input2 = new Class1() { One = "string" };
            var test = Class2.returnBoolean(input1, input2);
            Assert.IsTrue(test);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMethod4()
        {
            var input1 = new Class1() { One = "string" };
            Class1 input2 = null;
            var test = Class2.returnBoolean(input1, input2);
            Assert.IsFalse(test);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMethod5()
        {
            var input1 = new Class1() { One = "string" };
            Class1 input2 = null;
            var test = Class2.checkOnNullProperty(input1, input2);
            Assert.IsFalse(test);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMethod6()
        {
            Class1 input1 =  null;
            Class1 input2 = new Class1() { One = "string" };
            var test = Class2.checkOnNullProperty(input1, input2);
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void BareNullCompare()
        {
            Class1 input1 = new Class1() { One = null };
            Class1 input2 = new Class1() { One = "not null" };
            var test = Class2.checkOnNullProperty(input1, input2);
            Assert.IsFalse(test);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BareEquals()
        {
            Class1 input1 = new Class1() { One = null };
            Class1 input2 = new Class1() { One = "not null" };
            var test = Class2.CheckEquality(input1, input2);
            Assert.IsFalse(test);

        }

    }
}

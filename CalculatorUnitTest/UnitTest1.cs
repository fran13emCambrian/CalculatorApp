using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Logic;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Addition Tests
        //Test 1
        [TestMethod]
        public void AdditionTest1()
        {
            double num1 = 0;
            double num2 = 0;
            double expected = 0;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 2
        [TestMethod]
        public void AdditionTest2()
        {
            double num1 = 4;
            double num2 = 3;
            double expected = 7;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 3
        [TestMethod]
        public void AdditionTest3()
        {
            double num1 = 1;
            double num2 = 1;
            double expected = 2;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 4
        [TestMethod]
        public void AdditionTest4()
        {
            double num1 = 22;
            double num2 = 22;
            double expected = 44;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 5
        [TestMethod]
        public void AdditionTest5()
        {
            double num1 = 3;
            double num2 = 9;
            double expected = 12;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 6
        [TestMethod]
        public void AdditionTest6()
        {
            double num1 = 20;
            double num2 = 10;
            double expected = 30;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 7
        [TestMethod]
        public void AdditionTest7()
        {
            double num1 = 13;
            double num2 = 7;
            double expected = 20;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 8
        [TestMethod]
        public void AdditionTest8()
        {
            double num1 = 1;
            double num2 = 3;
            double expected = 4;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 9
        [TestMethod]
        public void AdditionTest9()
        {
            double num1 = 9;
            double num2 = 9;
            double expected = 18;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 10
        [TestMethod]
        public void AdditionTest10()
        {
            double num1 = 44;
            double num2 = 11;
            double expected = 55;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Substractios Tests
        //Test 1
        [TestMethod]
        public void SubtractionTest1()
        {
            double num1 = 5;
            double num2 = 4;
            double expected = 1;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 2
        [TestMethod]
        public void SubtractionTest2()
        {
            double num1 = 10;
            double num2 = 6;
            double expected = 4;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 3
        [TestMethod]
        public void SubtractionTest3()
        {
            double num1 = 20;
            double num2 = 14;
            double expected = 6;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 4
        [TestMethod]
        public void SubtractionTest4()
        {
            double num1 = 14;
            double num2 = 11;
            double expected = 3;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 5
        [TestMethod]
        public void SubtractionTest5()
        {
            double num1 = 8;
            double num2 = 5;
            double expected = 3;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 6
        [TestMethod]
        public void SubtractionTest6()
        {
            double num1 = 12;
            double num2 = 8;
            double expected = 4;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 7
        [TestMethod]
        public void SubtractionTest7()
        {
            double num1 = 88;
            double num2 = 7;
            double expected = 81;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 8
        [TestMethod]
        public void SubtractionTest8()
        {
            double num1 = 90;
            double num2 = 30;
            double expected = 60;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 9
        [TestMethod]
        public void SubtractionTest9()
        {
            double num1 = 8;
            double num2 = 4;
            double expected = 4;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 10
        [TestMethod]
        public void SubtractionTest10()
        {
            double num1 = 969;
            double num2 = 69;
            double expected = 900;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Multiplication Tests
        //Test 1
        [TestMethod]
        public void MultiplicationTest1()
        {
            double num1 = 1;
            double num2 = 1;
            double expected = 1;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 2
        [TestMethod]
        public void MultiplicationTest2()
        {
            double num1 = 4;
            double num2 = 4;
            double expected = 16;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 3
        [TestMethod]
        public void MultiplicationTest3()
        {
            double num1 = 4;
            double num2 = 5;
            double expected = 20;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 4
        [TestMethod]
        public void MultiplicationTest4()
        {
            double num1 = 20;
            double num2 = 2;
            double expected = 40;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 5
        [TestMethod]
        public void MultiplicationTest5()
        {
            double num1 = 15;
            double num2 = 5;
            double expected = 75;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 6
        [TestMethod]
        public void MultiplicationTest6()
        {
            double num1 = 13;
            double num2 = 12;
            double expected = 156;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 7
        [TestMethod]
        public void MultiplicationTest7()
        {
            double num1 = 1;
            double num2 = 9;
            double expected = 9;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 8
        [TestMethod]
        public void MultiplicationTest8()
        {
            double num1 = 11;
            double num2 = 33;
            double expected = 363;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 9
        [TestMethod]
        public void MultiplicationTest9()
        {
            double num1 = 120;
            double num2 = 2;
            double expected = 240;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 10
        [TestMethod]
        public void MultiplicationTest10()
        {
            double num1 = 88;
            double num2 = 11;
            double expected = 968;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Division Tests
        //Test 1
        [TestMethod]
        public void DivisionTest1()
        {
            double num1 = 1;
            double num2 = 1;
            double expected = 1;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 2
        [TestMethod]
        public void DivisionTest2()
        {
            double num1 = 4;
            double num2 = 2;
            double expected = 2;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 3
        [TestMethod]
        public void DivisionTest3()
        {
            double num1 = 12;
            double num2 = 3;
            double expected = 4;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 4
        [TestMethod]
        public void DivisionTest4()
        {
            double num1 = 100;
            double num2 = 10;
            double expected = 10;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 5
        [TestMethod]
        public void DivisionTest5()
        {
            double num1 = 99;
            double num2 = 9;
            double expected = 11;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 6
        [TestMethod]
        public void DivisionTest6()
        {
            double num1 = 120;
            double num2 = 40;
            double expected =  3;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 7
        [TestMethod]
        public void DivisionTest7()
        {
            double num1 = 84;
            double num2 = 7;
            double expected = 12;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 8
        [TestMethod]
        public void DivisionTest8()
        {
            double num1 = 36;
            double num2 = 12;
            double expected = 3;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 9
        [TestMethod]
        public void DivisionTest9()
        {
            double num1 = 555;
            double num2 = 5;
            double expected = 111;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

        //Test 10
        [TestMethod]
        public void DivisionTest10()
        {
            double num1 = 1000;
            double num2 = 1;
            double expected = 1000;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(expected, actualResult);
        }

    }
}

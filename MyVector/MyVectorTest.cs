using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    class MyVectorTest
    {
        MyVector<int> vector;

        [SetUp]
        public void init()
        {
            vector = new MyVector<int>(3);
            vector.pushBack(1);
            vector.pushBack(2);
            vector.pushBack(3);
        }

        [Test,TestCase(3)]
        public void whenCreatingVectorValuesInClassShouldBeCorrect(int expectedCappacity)
        {
            Assert.AreEqual(expectedCappacity, vector.m_cappacity);
        }

        [Test,TestCase(new int[] { 1, 2, 3 })]
        public void whenAddingElementToEndOFVectorShouldContainsThisElement(int[] expectedValue)
        {
            Assert.AreEqual(expectedValue[2], vector[2]);
        }

        [Test,TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        public void whenAddingElementToFullVectorCappacityShouldBeIncrease(int[] shouldContainsAtLeast , int expectedNewCappacity)
        {
            vector.pushBack(4);
            vector.pushBack(5);

            Assert.AreEqual(expectedNewCappacity, vector.m_cappacity);
            Assert.That(vector[4], Is.EqualTo(shouldContainsAtLeast[4]));
        }

        [Test]
        public void whenCallIndexingOutOfArrayShouldThrowException()
        {
            Assert.That(() => vector[6],
            Throws.Exception
              .TypeOf<IndexOutOfRangeException>());
        }

        [Test,TestCase(5)]
        public void whenAddingElementOutOfArrayByIndexingCappacityShouldBeIncrease(int expectedNewCappacity)
        {
            vector[4] = 4;

            Assert.AreEqual(4, vector[4]);
            Assert.AreEqual(expectedNewCappacity, vector.m_cappacity);
        }

        [Test]
        public void whenCallIndexingWithMinusValueShouldThrowException()
        {
            Assert.That(() => vector[-1],
            Throws.Exception
              .TypeOf<IndexOutOfRangeException>());
        }
    }
}

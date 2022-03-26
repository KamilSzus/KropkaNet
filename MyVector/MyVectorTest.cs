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
        [Test]
        public void whenCreatingVectorValuesInClassShouldBeCorrect()
        {
            int expectedCappacity = 5;
            int expectedSize = 0;

            MyVector<int> vector = new MyVector<int>(expectedCappacity);

            Assert.AreEqual(expectedCappacity, vector.m_cappacity);
            Assert.AreEqual(expectedSize, vector.m_size);
        }

        [Test,TestCase(new int[] { 1, 2, 3 })]
        public void whenAddingElementToEndOFVectorShouldContainsThisElement(int[] expectedValue)
        {
            MyVector<int> vector = new MyVector<int>(3);

            vector.pushBack(1);
            vector.pushBack(2);
            vector.pushBack(3);

            Assert.AreEqual(expectedValue[2], vector[2]);
        }

        [Test,TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        public void whenAddingElementToFullVectorCappacityShouldBeIncrease(int[] shouldContainsAtLeast , int expectedNewCappacity)
        {
            MyVector<int> vector = new MyVector<int>(3);

            vector.pushBack(1);
            vector.pushBack(2);
            vector.pushBack(3);
            vector.pushBack(4);
            vector.pushBack(5);

            Assert.AreEqual(expectedNewCappacity, vector.m_cappacity);
            Assert.That(vector[4], Is.EqualTo(shouldContainsAtLeast[4]));
        }

        [Test]
        public void whenCallIndexingOutOfArrayShouldThrowException()
        {
            MyVector<int> vector = new MyVector<int>(3);
            Assert.That(() => vector[6],
            Throws.Exception
              .TypeOf<IndexOutOfRangeException>());
        }
    }
}

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

            MyVector vector = new MyVector(expectedCappacity);

            Assert.AreEqual(expectedCappacity, vector.m_cappacity);
            Assert.AreEqual(expectedSize, vector.m_size);
        }

        [Test,TestCase(new int[] { 1, 2, 3 })]
        public void whenAddingElementToEndOFVectorShouldContainsThisElement(int[] expectedValue)
        {
            MyVector vector = new MyVector(3);

            vector.pushBack(1);
            vector.pushBack(2);
            vector.pushBack(3);

            Assert.AreEqual(expectedValue, vector.m_myVector);
        }

        [Test,TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        public void whenAddingElementToFullVectorCappacityShouldBeIncrease(int[] shouldContainsAtLeast , int expectedNewCappacity)
        {
            MyVector vector = new MyVector(3);

            vector.pushBack(1);
            vector.pushBack(2);
            vector.pushBack(3);
            vector.pushBack(4);
            vector.pushBack(5);

            Assert.That(shouldContainsAtLeast, Is.SubsetOf(vector.m_myVector));
            Assert.AreEqual(expectedNewCappacity, vector.m_cappacity);
        }
    }
}

using ArrayCRUD;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayCRUDTest
{
    public class RemoveTest
    {
        [Fact]
        public void VerifyCountAfterRemove()
        {
            var sut = new IntArray();
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);
            sut.Add(4);
            sut.Add(5);
            sut.Remove(2);
            Assert.Equal(7, sut.Count());
        }
        [Fact]
        public void VerifyElementsAfterRemove()
        {
            var sut = new IntArray();
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);
            sut.Add(4);
            sut.Add(5);
            sut.Remove(2);
            Assert.Equal(3, sut.Element(1));
            Assert.Equal(4, sut.Element(2));
        }

        [Fact]
        public void RemoveAnInexistentElement()
        {
            var sut = new IntArray();
            sut.Add(1);
            sut.Add(2);
            sut.Add(3);
            sut.Add(4);
            sut.Add(5);
            Action act = () => sut.Remove(9);
            var exception = Assert.Throws<System.Exception>(act);
            Assert.Equal("Element not found", exception.Message);
        }
    }
}

using ArrayCRUD;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayCRUDTest
{
    public class AddElementTest
    {
       [Fact]
        public void AddOneValue()
        {
            
            var sut = new IntArray();
            sut.Add(0);
            sut.Add(2);
            sut.Add(3);
            sut.Add(4);
            sut.Add(5);
            sut.Add(6);
            sut.Add(0);
            sut.Add(8);
            sut.Add(9);
            sut.Add(10);

            Assert.Equal(3, sut.Element(2));
            Assert.Equal(16, sut.Count());
        }

      
    }
}

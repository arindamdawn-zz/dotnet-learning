using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var x = 5;
            var y = 1;
            var actual = x + y;
            var expected = 6;
            //act
            var sum = x + y;
            //assert
            Assert.Equal(expected, sum);
        }
    }
}

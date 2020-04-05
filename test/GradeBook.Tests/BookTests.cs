using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(25.34);
            book.AddGrade(23.3);
            var result = book.GetStatistics();
            //act
            //assert
            Assert.Equal(23.3, result.Low);
            Assert.Equal(25.34, result.High);
            Assert.Equal(24.32, result.Average);
        }
    }
}

using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new InMemoryBook("");
            book.AddGrade(25.34);
            book.AddGrade(23.3);
            //act
            var result = book.GetStatistics();
            //assert
            Assert.Equal(23.3, result.Low);
            Assert.Equal(25.34, result.High);
            Assert.Equal(24.3, result.Average, 1);
            Assert.Equal('F', result.Letter);
        }

    }
}

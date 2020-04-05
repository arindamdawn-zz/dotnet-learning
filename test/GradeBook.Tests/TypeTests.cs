using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CSharpCanPassByReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal(book1.Name, "New Name");

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal(book1.Name, "Book 1");

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal(book1.Name, "New Name");

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.NotSame(book1, book2);

        }
        public void TwoVarsCanReferenceSameObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

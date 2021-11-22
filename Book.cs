using System;

namespace Last_Lab
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;

        public Book()
        {

        }
        public Book(string isbn, string title, Author author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }
        public void SetISBN(string isbn)
        {
            this.isbn = isbn;
        }
        public string GetISBN()
        {
            return isbn;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetAuthor(Author author)
        {
            this.author = author;
        }
        public Author GetAuthor()
        {
            return author;
        }
        public string ToStringBook()
        {
            return "isbn = " + isbn + "title = " + title + "author = " + author.ToStringAuthor();
        }
    }
}
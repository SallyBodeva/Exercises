using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Book
    {

        private string bookId;
        private Book next;

        public Book(string bookId)
        {
            this.bookId = bookId;
        }

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public Book Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"Book {this.BookId}";
        }
    }


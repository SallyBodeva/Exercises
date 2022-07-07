﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Shelf
    {
        private Book Head;
        private Book Tail;
        public int Count { get;  set; }
        public void AddBook(string bookId)
        {
            Book book = new Book(bookId);
            if (this.Count == 0)
            {
                this.Head = this.Tail = book;

            }
            else
            {
                this.Tail.Next = book;
            }
            this.Count++;
        }
        public void AddSpecialBook(string bookId)
        {
            Book book = new Book(bookId);
            book.Next = this.Head;
            this.Head = book;
            this.Count++;
        }
        public Book CheckBookIsPresent(string bookId)
        {
            Book current = this.Head;
            while (current != null)
            {
                if (current.BookId == bookId)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public bool ReleaseBook(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                return false;
            }
            Book current = this.Head;
            int currentIndex = 0;
            while (current != null)
            {
                if (currentIndex == index)
                {
                    if (index == 0)
                    {
                        this.Head = this.Head.Next;
                    }
                    else
                    {
                        Book beforeCurrent = this.Head;
                        for (int i = 0; i < currentIndex - 1; i++)
                        {
                            beforeCurrent = beforeCurrent.Next;
                        }
                        beforeCurrent = beforeCurrent.Next;
                        if (currentIndex == this.Count - 1)
                        {
                            this.Tail = beforeCurrent;
                        }
                    }
                    this.Count--;
                    return true;
                }
                currentIndex++;
                current = current.Next;
            }
            return false;
        }
        public bool ReleaseBook(string bookId)
        {
            Book currentBook = this.Head;
            int index = -1;
            int removedIndex = -1;
            while (currentBook != null)
            {
                index++;
                if (currentBook.BookId == bookId)
                {
                    removedIndex = index;
                    break;

                }
                currentBook = currentBook.Next;
            }
            return ReleaseBook(removedIndex);
        }
        public StringBuilder ShelfInformation()
        {
            if (this.Head == null)
            {
                return new StringBuilder("Shelf is empty");
            }
            StringBuilder sb = new StringBuilder();
            Book currentBook = this.Head;
            while (currentBook != null)
            {
                sb.AppendLine(currentBook.ToString());
                currentBook = currentBook.Next;
            }
            return sb;
        }


    }


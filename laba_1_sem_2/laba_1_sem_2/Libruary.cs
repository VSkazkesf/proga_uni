using System;
using System.Collections.Generic;
using System.Linq;

namespace laba_1_sem_2
{
    public class Library
    {
        public List<Book> Books { get; }
        public List<Member> Members { get; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterMember(Member member)
        {
            Members.Add(member);
        }

        public void LoanBook(Book book, Member member)
        {
            book.IsAvailable = false;
            member.LoanedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            book.IsAvailable = true;
        }

        public List<Book> GetLoans()
        {
            List<Book> loans = Books.Where(x => !x.IsAvailable).ToList();
            return loans;
        }

        public Book SearchBook(string title)
        {
            var foundBook = Books.FirstOrDefault(x => x.Title == title);
            if (foundBook != null)
            {
                return foundBook;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public List<Book> GetAvailableBooks()
        {
            List<Book> avavailableBooks = Books.Where(x => x.IsAvailable).ToList();
            return avavailableBooks;
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public List<Member> GetMembers()
        {
            return Members;
        }
    }
}

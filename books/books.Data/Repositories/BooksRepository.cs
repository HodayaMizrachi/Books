using books.Data.DataContext;
using books.Data.Entities;
using books.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksContext = books.Data.DataContext.BooksContext;

namespace books.Data.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private BooksContext _booksDB;

        public BooksRepository(BooksContext booksDB)
        {
            _booksDB = booksDB;
        }


        public List<Book> GetAllBooks()
        {
            return _booksDB.Books.ToList();
        }

        public int CreateBook(Book book)
        {
            _booksDB.Books.Add(book); 
            _booksDB.SaveChanges();
            return book.BookId; // מחזיר את ה-ID של הספר החדש שנוצר
        }

        public void DeleteBook(int bookId)
        {
            Book book = _booksDB.Books.SingleOrDefault(b => b.BookId == bookId); // מציאת הספר לפי BookId
            if (book != null)
            {
                _booksDB.Books.Remove(book); 
                _booksDB.SaveChanges(); 
            }
        }

        public Book UpdateBook(Book book)
        {
            _booksDB.Entry(book).State = EntityState.Modified; 
            _booksDB.SaveChanges();
            return book; // מחזיר את הספר לאחר העדכון
        }
    }
}

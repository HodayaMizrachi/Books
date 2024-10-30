using books.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books.Data.Interfaces
{
    public interface IBooksRepository
    {
        public List<Book> GetAllBooks();
        public int CreateBook(Book book);
        public void DeleteBook(int bookId);
        public Book UpdateBook(Book book);
    }
}

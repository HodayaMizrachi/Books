using AutoMapper;
using books.BusinessLogic.Interfaces;
using books.Data.Entities;
using books.Data.Interfaces;
using books.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books.BusinessLogic.Services
{
    public class BooksService : IBooksService
    {
        private IBooksRepository _booksRepository;
        private readonly IMapper _mapper;
        public BooksService(IBooksRepository br, IMapper mapper)
        {
            _booksRepository = br;
            _mapper = mapper;
        }

        public List<Book> GetAllBooks()
        {
            return _booksRepository.GetAllBooks();
        }

        public int CreateBook(Book book)
        {
            return _booksRepository.CreateBook(book);
        }

        public void DeleteBook(int bookId)
        {
           _booksRepository.DeleteBook(bookId);
        }

        public Book UpdateBook(Book book)
        {
            return _booksRepository.UpdateBook(book); 
        }

       

    }
}

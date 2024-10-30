using AutoMapper;
using books.BusinessLogic.Interfaces;
using books.Data.Entities;
using books.DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace books.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private IBooksService _booksService;
        private readonly IMapper _mapper;

        public BooksController(IBooksService bs, IMapper mapper)
        {
            _booksService = bs;
            _mapper = mapper;
        }

        [HttpGet]
        public List<BookDTO> GetAllBooks()
        {

            var books = _booksService.GetAllBooks();
            return _mapper.Map<List<BookDTO>>(books);

        }

        [HttpPost]
        public int CreateBook([FromBody] BookDTO book)
        {

            return _booksService.CreateBook(_mapper.Map<Book>(book));
        }

        [HttpDelete("{bookId}")]
        public void DeleteBook(int bookId)
        {
            _booksService.DeleteBook(bookId);
        }


        [HttpPut]
        public BookDTO UpdateBook([FromBody] BookDTO book)
        {
            var bookEntity = _mapper.Map<Book>(book); // מיפוי ל-Entity בקונטרולר
            var updatedBook = _booksService.UpdateBook(bookEntity); // שליחה של ה-Entity לשירות
            return _mapper.Map<BookDTO>(updatedBook); // מיפוי חזרה ל-DTO בקונטרולר לאחר העדכון
        }




    }
}
///////סתם בדיקה עבור הגיט
///עוד אחת
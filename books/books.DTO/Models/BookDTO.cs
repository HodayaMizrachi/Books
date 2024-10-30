using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books.DTO.Models
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public DateOnly PublishedDate { get; set; }

        public float Price { get; set; }
    }
}

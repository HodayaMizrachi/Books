using System;
using System.Collections.Generic;

namespace books.Data.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public DateOnly PublishedDate { get; set; }

    public float Price { get; set; }
}

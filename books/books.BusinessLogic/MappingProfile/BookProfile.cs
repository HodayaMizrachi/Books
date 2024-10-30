using AutoMapper;
using books.Data.Entities;
using books.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books.BusinessLogic.MappingProfile
{
    public class BookProfile :Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}

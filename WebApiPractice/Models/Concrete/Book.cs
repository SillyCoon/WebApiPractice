using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPractice.Models.Concrete
{
    public class Book : IBook
    {
        public int? Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
    }
}
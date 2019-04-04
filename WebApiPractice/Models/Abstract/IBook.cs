using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPractice.Models.Concrete
{
    public interface IBook
    {
        int? Id { get; set; }
        string Author { get; set; }
        string Title { get; set; } 
    }
}
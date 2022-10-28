using System;
using System.Collections.Generic;

namespace API_EF_Assignment.Entities
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public int? Price { get; set; }
        public string? Author { get; set; }
        public string? Lang { get; set; }
        public string? Publisher { get; set; }
    }
}

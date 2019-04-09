using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite;

namespace Book
{
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string title { get; set; }
        public string firstAuthor { get; set; }
        public int publishYear { get; set; }
    }
}
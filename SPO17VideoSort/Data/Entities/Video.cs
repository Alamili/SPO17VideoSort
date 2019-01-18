using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPO17VideoSort.Data.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}

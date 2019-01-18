using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPO17VideoSort.Data.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend6.Models
{
    public class ForumCategory
    {
        public int Id { get; set; } 

        [Required]
        public String Name { get; set; }
    }
}

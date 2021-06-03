using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend6.Models
{
    public class Folder
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public ICollection<File> Files { get; set; }

        [Required]
        public String Name { get; set; }
    }
}

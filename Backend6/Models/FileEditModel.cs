using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Backend6.Models
{
    public class FileEditModel
    {
        public IFormFile file { get; set; }

        public String Name { get; set; }

        public String Extension { get; set; }

        public Int64 Size { get; set; }
    }
}

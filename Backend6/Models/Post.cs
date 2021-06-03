using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend6.Models
{
    public class Post
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Text { get; set; }

        public int? CategoryId { get; set; }

        public ForumCategory Category { get; set; }
    }
}

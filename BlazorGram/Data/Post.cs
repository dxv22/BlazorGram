using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGram.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Details { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Content> Contents { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

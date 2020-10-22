using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Content
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public string Body { get; set; }
        [Required]
        public string Author { get; set; }
        public string PublishDate { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Content()
        {

        }
        public Content(int id, string title, string body, string author, string publishDate)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyCustomBlogEngine.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
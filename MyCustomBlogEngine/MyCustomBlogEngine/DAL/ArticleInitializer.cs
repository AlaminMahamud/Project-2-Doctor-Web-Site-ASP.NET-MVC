using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCustomBlogEngine.Models;

namespace MyCustomBlogEngine.DAL
{
    public class ArticleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            var articles = new List<Article> {
                new Article
                {
                    Title = "This is My First Post",
                    Body  = "Hello World",
                    PublishedDate = DateTime.Now
                }
            };

            articles.ForEach(a=>context.Articles.Add(a));
            context.SaveChanges();
        }
    }
}
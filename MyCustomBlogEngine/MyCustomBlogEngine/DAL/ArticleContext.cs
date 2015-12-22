using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCustomBlogEngine.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyCustomBlogEngine.DAL
{
    public class ArticleContext :DbContext
    {
        // Constructor is called because if you pass a string in base then
        // you are renaming the Database as your name
        // if you pass a connection string then it will use 
        // this connection string instead
        // rather than default connection
        public ArticleContext() : base("MyArticles")
        { }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
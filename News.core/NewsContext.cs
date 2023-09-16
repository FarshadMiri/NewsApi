using Microsoft.EntityFrameworkCore;
using News.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.core
{
    public class NewsContext:DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options)
       : base(options)
        {
        }
        public DbSet<Root> roots { get; set; }
        public DbSet<Article> articles { get; set; }
    }
}

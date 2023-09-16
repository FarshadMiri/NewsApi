using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.domain
{
    public class Article
    {
        [Key]
        public string Id { get; set; } 
        
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
        public string   SourceId { get; set; }
        public string SourceName { get; set; }

        public int RootId { get; set; } 
        public virtual Root Root { get; set; } 
        
  
    }
}

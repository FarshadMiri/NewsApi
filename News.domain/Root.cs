using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.domain
{
    public class Root
   
    {
        public Root()
        {
            Articles = new List<Article>();

        }
        [Key]
            public int Id { get; set; } 
            public string Status { get; set; }
            public int TotalResults { get; set; }
            public virtual List<Article> Articles { get; set; }
        


    }
}

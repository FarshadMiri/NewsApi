using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private NewsContext _newsContext { get; }
        public Repository(NewsContext newsContext)
        {
            _newsContext = newsContext; 

        }
        public void Create(T entity)
        {
            _newsContext.Set<T>().Add(entity);    
            _newsContext.SaveChanges(); 
        }

        public void Delete(T entity)
        {
            _newsContext.Set<T>().Remove(entity);
            _newsContext.SaveChanges();
        }

        public List<T> List()
        {
            return _newsContext.Set<T>().ToList();  
        }

        public void Update(T entity)
        {
            _newsContext.Set<T>().Update(entity);
            _newsContext.SaveChanges();
            
        }
    }
}

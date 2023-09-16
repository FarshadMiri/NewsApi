using News.core;
using News.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.service
{
    public class ArticleService : IArticleService
    {
        private IRepository<Article> _repository { get; }

        public ArticleService(IRepository<Article> repository)
        {
            _repository = repository;
        }
        public void Create(Article entity)
        {
            _repository.Create(entity);
        }
        public void Update(Article entity)
        {
            _repository.Update(entity);
        }
        public void Delete(Article entity)
        {
            _repository.Delete(entity);
        }
        public List<Article> List()
        {
            return _repository.List();
        }

        //public Article Find(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Article Find(int id)
        //{
        //    throw new NotImplementedException();
        //}
        // به دلیل مشکل داشتن ای دی گرفته شده از وب سرویس این متود قابل استفاده نیست
        //public Article Find(int= id)
        //{
        //    return List().FirstOrDefault(x => x.Id == id);
        //}


    }
}

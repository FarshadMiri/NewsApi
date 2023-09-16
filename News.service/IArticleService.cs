using News.domain;

namespace News.service
{
    public interface IArticleService
    {
        void Create(Article entity);
        void Delete(Article entity);
        //Article Find(int id);
        List<Article> List();
        void Update(Article entity);
    }
}
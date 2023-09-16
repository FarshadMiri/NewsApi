using News.domain;

namespace News.service
{
    public interface IRootService
    {
        void Create(Root entity);
        Root Find(int id);
        List<Root> List();
        void Update(Root entity);
    }
}
using News.core;
using News.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.service
{
    public class RootService : IRootService
    {
        private IRepository<Root> _repository { get; }
        public RootService(IRepository<Root> repository)
        {
            _repository = repository;

        }
        public void Create(Root entity)
        {
            _repository.Create(entity);
        }
        public void Update(Root entity)
        {
            _repository.Update(entity);
        }
        public List<Root> List()
        {
            return _repository.List();
        }
        public Root Find(int id)
        {
            return List().FirstOrDefault(x => x.Id == id);
        }
    }
}

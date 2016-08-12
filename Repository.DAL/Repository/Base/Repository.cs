using Repository.DAL.Context;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository.DAL.Repository.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        readonly DbContext _dbContext;

        public Repository(IUnitOfWork unitOfWork)
        {
            _dbContext = unitOfWork.Context;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return _dbContext.Set<TEntity>().Find(key);
        }

        public void Update(TEntity obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
        }

        public void Save(TEntity obj)
        {
            _dbContext.Set<TEntity>().Add(obj);
        }

        public void Remove(Func<TEntity, bool> predicate)
        {
            _dbContext.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => _dbContext.Set<TEntity>().Remove(del));

        }
    }
}

using System.Linq.Expressions;
using GameLibrary.Application.Common;

namespace GameLibrary.Infrastructure.Persistence;

public abstract class RepositoryBase<T> : IRepository<T>
    where T : class
{
    protected IAppDbContext DbContext { get; set; }

    public RepositoryBase(IAppDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public IQueryable<T> FindAll() => DbContext.Set<T>();
    
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition) => DbContext.Set<T>().Where(condition);

    public T? FindFirstByCondition(Expression<Func<T, bool>> condition) => DbContext.Set<T>().First(condition);

    public void Create(T entity) => DbContext.Set<T>().Add(entity);

    public void Update(T entity) => DbContext.Set<T>().Update(entity);

    public void Delete(T entity) => DbContext.Set<T>().Remove(entity);
}
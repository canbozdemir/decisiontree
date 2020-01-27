namespace KnowledgeBase.Core.Infrastructure.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get();
    }
}
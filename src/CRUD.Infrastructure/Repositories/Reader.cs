namespace CRUD.Infrastructure.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    using POCOs;

    using Specifications;

    public interface IReader<TEntity> where TEntity : class
    {
        TResult Get<TResult, TPredicateResult>(
            Expression<Func<TEntity, TPredicateResult>> predicate,
            Func<IQueryable<TEntity>, Expression<Func<TEntity, TPredicateResult>>, TResult> func,
            ISpecification<TEntity> specification = null);
    }

    public class Reader<TEntity> : IReader<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> table;

        public Reader(IADWContext context)
        {
            this.table = context.Set<TEntity>();
        }

        public TResult Get<TResult, TPredicateResult>(
            Expression<Func<TEntity, TPredicateResult>> predicate,
            Func<IQueryable<TEntity>, Expression<Func<TEntity, TPredicateResult>>, TResult> func,
            ISpecification<TEntity> specification = null)
        {
            IQueryable<TEntity> query = this.table;
            var entitySpecification = specification ?? new DefaultSpecification<TEntity>();
            entitySpecification.Includes.ForEach(spec => query = query.Include(spec));
            return func(query.AsNoTracking(), predicate);
        }
    }
}
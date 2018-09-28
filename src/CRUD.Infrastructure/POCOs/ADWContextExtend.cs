namespace CRUD.Infrastructure.POCOs
{
    using System.Data.Entity;

    public partial interface IADWContext
    {
        void SetState<TEntity>(TEntity entity, EntityState entityType)
            where TEntity : class;
    }

    public partial class ADWContext
    {
        public void SetState<TEntity>(TEntity entity, EntityState entityType)
            where TEntity : class
        {
            this.Entry(entity).State = entityType;
        }
    }
}
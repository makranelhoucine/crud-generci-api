namespace CRUD.Infrastructure.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface ISpecification<T>
    {
        List<Expression<Func<T, object>>> Includes { get; }
    }

    public abstract class SpecificationBase<T> : ISpecification<T>
    {
        protected SpecificationBase()
        {
            this.AddSpecfications();
        }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        protected internal abstract void OnAdd(Action<Expression<Func<T, object>>> add);

        private void AddSpecfications()
        {
            this.OnAdd(this.Includes.Add);
        }
    }
}
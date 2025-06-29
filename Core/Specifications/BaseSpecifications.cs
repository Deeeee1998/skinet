using System;
using System.Linq.Expressions;
using Core.Interfaces;

namespace Infrastructure.Specifications;

public class BaseSpecifications<T>(Expression<Func<T, bool>>? criteria) : ISpectification<T>
{
    protected BaseSpecifications() : this(null) { }
    public Expression<Func<T, bool>>? Criteria => criteria;

    public Expression<Func<T, object>>? OrderBy { get; private set; }
    public Expression<Func<T, object>>? OrderByDescending { get; private set; }
    public bool IsDistinct { get; private set; }

    protected void AddOrderBy(Expression<Func<T, object>> orderbyExpression)
    {
        OrderBy = orderbyExpression;
    }
    protected void AddOrderByDescending(Expression<Func<T, object>> orderbyDescExpression)
    {
        OrderByDescending = orderbyDescExpression;
    }

    protected void ApplyDistinct()
    {
        IsDistinct = true;
    }
}

public class BaseSpecifications<T, TResult>(Expression<Func<T, bool>> criteria)
: BaseSpecifications<T>(criteria), ISpectification<T, TResult>
{
    protected BaseSpecifications() : this(null!) { }
    public Expression<Func<T, TResult>>? Select { get; private set; }


    protected  void AddSelect(Expression<Func<T, TResult>> selectExpression)
    {
        Select = selectExpression;
    }
}

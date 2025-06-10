using System;
using System.Linq.Expressions;

namespace Core.Interfaces;

public interface ISpectification<T>
{
    Expression<Func<T, bool>>? Criteria { get; }

    Expression<Func<T, object>>? OrderBy { get; }
    Expression<Func<T, object>>? OrderByDescending { get; }
    bool IsDistinct { get; }
}
public interface ISpectification<T, TResult> : ISpectification<T>
{
    Expression<Func<T, TResult>>? Select { get; }
    
    
}

using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsyns(int id);
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T?> GetEntityWithSpec(ISpectification<T> spec);
    Task<IReadOnlyList<T>> ListAsync(ISpectification<T> spec);
    Task<TResult?> GetEntityWithSpec<TResult>(ISpectification<T, TResult> spec);
    Task<IReadOnlyList<TResult>> ListAsync<TResult>(ISpectification<T, TResult> spec);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);

    Task<bool> SaveAllAsync();
    bool Exists(int id);

}

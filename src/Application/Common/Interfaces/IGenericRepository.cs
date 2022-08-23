﻿namespace Application.Common.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        IEnumerable<T> Find(ISpecification<T> specification = null);
    }
}

using ApplicationCore.Entities;
// Install-Package Ardalis.Specification
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllAsync();
        Task<List<T>> ListAlllAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task CountAsync(ISpecification<T> spec);
        Task FirstAsync(ISpecification<T> spec);
        Task FirstOrDefaultAsync(ISpecification<T> spec);
    }
}

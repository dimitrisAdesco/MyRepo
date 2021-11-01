using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteBook.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        //Get All Entities
        Task<IEnumerable<T>> All();

        //Get Entity based on id
        Task<T> GetById(Guid id);
        Task<bool> Add(T entity);
        Task<bool> Delete(Guid id, string userId);

        //Update entity or add if not exist
        Task<bool> Upsert(T entity);

    }
}
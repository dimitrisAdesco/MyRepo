using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteBook.DbSet;

namespace NoteBook.IRepository
{
    public interface IUsersRepository : IGenericRepository<User>
    {

    }
}
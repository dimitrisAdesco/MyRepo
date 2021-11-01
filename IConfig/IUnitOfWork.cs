using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteBook.IRepository;
using NoteBook.Data;

namespace NoteBook.IConfig
{
    public interface IUnitOfWork
    {
        IUsersRepository Users { get; }
        Task CompleteAsync();

    }
}
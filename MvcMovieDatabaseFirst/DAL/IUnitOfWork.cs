using MvcMovieDatabaseFirst.DAL;
using MvcMovieDatabaseFirst.Models;
using System;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        IGenericRepository<Movie> MovieRepository { get; }
        
    }
}

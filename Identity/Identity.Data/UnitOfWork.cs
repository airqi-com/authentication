using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Data
{
    public class UnitOfWork : IUnitOfWork
    {
       // private readonly DbContext _context;
        private Dictionary<Type, object> _repositories;

        //public UnitOfWork(DbContext context)
        //{
        //    _context = context;
        //    _repositories = new Dictionary<Type, object>();
        //}

        public void Commit()
        {
          //  _context.SaveChanges();
        }

        public void Rollback()
        {
            // Rollback changes if needed
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IRepository<TEntity>)_repositories[typeof(TEntity)];
            }

            // var repository = new Repository<TEntity>(_context);
            //_repositories.Add(typeof(TEntity), repository);
            //return repository;
            throw new Exception();
        }

        public void Dispose()
        {
           // _context.Dispose();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }

}

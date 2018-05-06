using MinhaPrimeiraLoja.Repositorie.Context;
using MinhaPrimeiraLojaVirtual.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MinhaPrimeiraLoja.Repositorie.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private LojaVirtualContext db =new LojaVirtualContext();
        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
        }

        public void Dispose()
        {
            Dispose();
        }

        public TEntity GetById(int Id)
        {
            return db.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> List()
        {
            return db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
    }
}

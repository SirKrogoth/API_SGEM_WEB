using API.Model.Base;
using API.Model.Context;
using API.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MysqlContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MysqlContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public void Delete(long codigo)
        {
            var result = dataset.SingleOrDefault(p => p.Codigo.Equals(codigo));

            try
            {
                if (result != null)
                    dataset.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exist(long? codigo)
        {
            return dataset.Any(p => p.Codigo.Equals(codigo));
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long codigo)
        {
            return dataset.SingleOrDefault(p => p.Codigo.Equals(codigo));
        }

        public T Update(T item)
        {
            if (!Exist(item.Codigo)) return null;

            var result = dataset.SingleOrDefault(p => p.Codigo.Equals(item.Codigo));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}

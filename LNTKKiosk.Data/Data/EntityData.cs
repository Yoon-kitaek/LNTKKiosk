using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class EntityData<T> where T:class
    {
        protected LNTKEntities CreateContext()
        {
            LNTKEntities context = new LNTKEntities();
            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }

        public List<T> GetAll()
        {
            var context = CreateContext();

            return context.Set<T>().ToList();
            
        }

        public int GetCount()
        {
            var context = CreateContext();

            return context.Set<T>().Count();
        }

        public void Insert(T entity)
        {
            var context = CreateContext();

            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var context = CreateContext();

            context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var context = CreateContext();

            context.Entry(entity).State = EntityState.Deleted;

            context.SaveChanges();
        }
    }
}

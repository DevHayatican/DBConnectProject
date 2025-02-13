using DBConnectProject.repository.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.repository
{
    internal class CrudRepository<T, ID> : ICrudRepository<T, ID> where T : class
    {
        DbBaglan DbBaglan;

        DbSet<T> dbBaglanTablolar;

        public CrudRepository()
        {
            // TODO : yanlis sekilde birakıyorum const metodu talep etmeli.
            DbBaglan = new DbBaglan();
            dbBaglanTablolar = DbBaglan.Set<T>();
        }

        public void Add(T x)
        {
           dbBaglanTablolar.Add(x);
           DbBaglan.SaveChanges();
    
        }

        public List<T> GetAll()
        {
            return dbBaglanTablolar.ToList();
        }

        public T GetByİd(ID id)
        {
            return dbBaglanTablolar.Find(id);
        }

        public void Remove(T x)
        {
            dbBaglanTablolar.Remove(x);
            DbBaglan.SaveChanges();
        }

        public void Update(T entity, ID id)
        {
            T x = GetByİd(id);

          
            dbBaglanTablolar.Update(x);
            DbBaglan.SaveChanges();
        }
    }
}

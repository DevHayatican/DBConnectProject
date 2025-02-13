using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.repository
{
    internal interface ICrudRepository<T, ID>
    {
        List<T> GetAll();

        void Add(T x);

        void Remove(T x);

        T GetByİd(ID id);

        void Update(T entity, ID id);


    }
}

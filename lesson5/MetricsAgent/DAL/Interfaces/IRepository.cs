using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.DAL
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();

        IList<T> GetCluster(long fromTime, long toTime);

        T GetByID(int id);

        void Create(T item);
        void Update(T item);
        void Delete(int id);

    }
}

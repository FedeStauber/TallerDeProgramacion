using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.DAL
{
    interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity pEntity);
        void Remove(TEntity pEntity);
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();
       
    }
}

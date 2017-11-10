using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.AccountManager.DAL
{
    interface IRepository
    {
        public void Add(TEntity pEntity){}
        public void Remove(TEntity pEntity){}
        public TEntity Get(int pId){}
        public IEnumerable<TEntity> GetAll(){}
    }
}

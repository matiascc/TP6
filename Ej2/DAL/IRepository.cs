using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Agrega una tupla a la tabla
        void Add(TEntity pEntity);
        //Elimina una tupla de la tabla
        void Remove(TEntity pEntity);
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();
    }
}

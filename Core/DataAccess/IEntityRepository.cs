
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generics constraint
    //Class : referans tip olma sarti getirir
    //IEntity : IEntity ya da IEntity ile iplemente edilmis bir nesne sinirlamasi
    //New() : New lene bilirlik sarti getirir. Mesela interfaceleri parametre olarak almaz  
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entitys);
        void Update(T entitys);
        void Delete(T entitys);
    }
}
